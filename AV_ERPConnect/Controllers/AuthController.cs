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


    }
}
