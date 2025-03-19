# AV_ERP Solution README

## Project Name
AV_ERPConnect

## Description
This is a .NET-based enterprise resource planning (ERP) solution using Clean Architecture. The solution consists of multiple projects:
- **AV_ERP_COMMON**: Common utilities and shared components
- **AV_ERP_DATA_API**: API layer for handling requests
- **AV_ERP_DATA_BUSINESS**: Business logic layer, Authentication services, DBObject class, migrations, smtp service.
- **AV_ERP_DATA_DOMAIN**: Domain models and entities
- **AV_ERP_AzureFunction**: Azure Functions implementation Localhost

## Technologies Used
- .NET SDK 8
- ASP.NET Core
- Azure Functions
- Entity Framework Core (Code-First)
- JWT Authentication
- SMTP for email notifications
- Serilog for logging
- GitHub Actions for CI/CD
- SQL Server (Local DB)
- Postman & Swagger UI for API testing

## Prerequisites
Ensure you have the following installed before setting up the project:
- [.NET SDK 8](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Azure Functions Core Tools](https://learn.microsoft.com/en-us/azure/azure-functions/functions-run-local)
- [Visual Studio](https://visualstudio.microsoft.com/)
- [Postman](https://www.postman.com/) (for API testing)

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/amanvats2306/AV_ERPConnect.git
   ```
2. Navigate to the project directory:
   ```sh
   cd AV_ERPConnect
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Set up the database:
   - Update the `appsettings.json` with your SQL Server connection string.
   - Run migrations (if using EF Core):
     ```sh
     dotnet ef database update
     ```

## Running the Project
1. Build the solution:
   ```sh
   dotnet build
   ```
2. Run the API:
   ```sh
   dotnet run --project AV_ERP_DATA_API
   ```

## Authentication & Security
- The project uses **JWT authentication** for securing API endpoints.

## Email Notifications
- SMTP is configured for sending emails.

## Logging
- Logging is implemented using **Serilog**.
- Logs are saved to a file on daily basis.

## CI/CD Pipeline
- **GitHub Actions** is configured for building and running tests.
- Every commit triggers a build process.

## API Documentation
- The API endpoints can be tested using **Postman**.
  ```

## Folder Structure
```
/AV_ERPConnect
│-- /AV_ERP_COMMON
│-- /AV_ERP_DATA_API
│-- /AV_ERP_DATA_BUSINESS
│-- /AV_ERP_DATA_DOMAIN
│-- /AV_ERP_AzureFunction
│-- appsettings.json
│-- Program.cs
│-- Startup.cs
```

## Contributing
1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Create a pull request.

## Contact
For any queries, contact **Aman Vats** at [amanvats230675@gmail.com].

