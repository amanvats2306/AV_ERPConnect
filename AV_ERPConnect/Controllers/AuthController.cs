using AV_ERP_DATA_BUSINESS.Authentication;
using AV_ERP_DATA_BUSINESS.Data;
using AV_ERP_DATA_DOMAIN.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace AV_ERP_DATA_API.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly JwtTokenService _jwtTokenService;

        public AuthController(AppDbContext appDbContext, JwtTokenService jwtTokenService)
        {
            _appDbContext = appDbContext;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserERP userERP)
        {
            userERP.PasswordHash = HashPassword(userERP.PasswordHash);
            _appDbContext.users.Add(userERP);
            await _appDbContext.SaveChangesAsync();
            return Ok("User Registered succesfully");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserERP userERP)
        {
            var dbUser = await _appDbContext.users.FirstOrDefaultAsync(u => u.Email == userERP.Email);
            if (dbUser == null || dbUser.PasswordHash != HashPassword(userERP.PasswordHash))
                return Unauthorized("Invalid credentials!");

            var token = _jwtTokenService.GenerateToken(dbUser);
            return Ok(new { token });
        }
        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));

        }
    }
}
