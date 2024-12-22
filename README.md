# C#
# Build
  dotnet build
# Run
  dotnet run
  Learning DBContext and Entiity Framework installation and Configuration
  To Install
  # Install Pakages
  dotnet add package " Name of Packages:"
  Like 
# Install EF Core and SQL Server packages
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

# Update Programm.cs 
// ...existing code...
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// ...existing code...
# Add connection string in appsettings.json:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=WebAppV1Db;Trusted_Connection=True;TrustServerCertificate=True;"
  },
  // ...existing code...
}
# Create and apply migration:
# Create migration
dotnet ef migrations add InitialCreate

# Update database
dotnet ef database update
# Update README.md:
# C#
# Build
  dotnet build
# Run
  dotnet run

# Entity Framework Core Commands
  dotnet add package Microsoft.EntityFrameworkCore
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
  dotnet add package Microsoft.EntityFrameworkCore.Design

# Run Your SQL Server Instance First
For Running in Docker Container use Command like 
1- Stop All ready Running SQL server or use same password or running server
docker run -d --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=SqlServer2024" -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest
# Database Migrations
  dotnet ef migrations add [MigrationName]
  dotnet ef database update

<!-- By Tommorroe Start from Data Migtration -->

 
