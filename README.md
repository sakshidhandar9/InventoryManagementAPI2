# InventoryManagementAPI

This is a RESTful API built with ASP.NET Core for managing inventory, products, suppliers, and categories. It follows a clean architecture using services, DTOs, and validation with FluentValidation.

## 🛠️ Tech Stack

- ASP.NET Core Web API (.NET 6+)
- Entity Framework Core
- SQL Server
- FluentValidation
- Swagger / Swashbuckle
- Visual Studio 2022
  
## 📁 Project Structure
InventoryManagementAPI/
├── Controllers/
├── DTOs/
├── Models/
├── Services/
├── Validators/
├── Infrastructure/
├── Migrations/
├── appsettings.json
├── Program.cs

## 🔐 Features

- ✅ CRUD operations for:
  - Products
  - Categories
  - Suppliers
- ✅ Validation using FluentValidation
- ✅ Dependency Injection (DI) setup
- ✅ Swagger UI for API testing
- ✅ SQL Server integration via EF Core
- ✅ DTOs to decouple domain and API contracts


### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
- Visual Studio 2022 (or Visual Studio Code)

### Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/sakshidhandar9/InventoryManagementAPI.git

