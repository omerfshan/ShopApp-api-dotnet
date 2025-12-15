# ShopApp (.NET) – shop Management Application

ShopApp is an  shop management application developed using ASP.NET Core with a layered architecture.  
The project separates business logic, data access, web UI, and REST API layers to provide a scalable and maintainable structure.

## Features
- Product management
- Category management
- Cart operations
- Order workflow infrastructure
- Entity Framework Core integration
- Repository & Unit of Work patterns
- ASP.NET Core MVC (Razor) Web UI
- ASP.NET Core Web API (REST)

## Project Structure
shopapp.sln
- shopapp.entity     → Domain entities
- shopapp.data       → EF Core, Repositories, UnitOfWork, Migrations
- shopapp.business   → Business logic & services
- shopapp.webui      → ASP.NET Core MVC (Razor)
- shopapp.webapi     → ASP.NET Core REST API

## Technologies
- C#
- ASP.NET Core
- Entity Framework Core
- LINQ
- SQL Server
- HTML / CSS / Bootstrap

## Requirements
- .NET SDK (9)
- SQL Server

## Setup
1. Clone repository
git clone https://github.com/username/shopapp.git

2. Restore packages
dotnet restore

3. Configure database connection
Update the ConnectionStrings section in appsettings.json

4. Apply migrations
dotnet ef database update --project shopapp.data --startup-project shopapp.webui

## Run
Web UI:
dotnet run --project shopapp.webui

Web API:
dotnet run --project shopapp.webapi

## Notes
- bin, obj, and .vs folders are excluded from version control
- This project is developed for learning and portfolio purposes

## License
Educational / Portfolio project
