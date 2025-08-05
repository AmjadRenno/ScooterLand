# BlazorAppClientServer - Scooterland Workshop Management System

A comprehensive workshop management system built with **Blazor WebAssembly** and **ASP.NET Core** for managing scooter repair and maintenance services.

## 🚀 Project Overview

This application is designed for scooter workshop management, providing functionality to manage:
- **Customers** (Kunder)
- **Mechanics** (Mekanikere) 
- **Work Orders** (Ordrer)
- **Services** (Ydelser)
- **Brands** (Mærker)
- **Invoices** (Fakturaer)

## 🏗️ Architecture

**Client-Server Architecture:**
- **Frontend**: Blazor WebAssembly (Client)
- **Backend**: ASP.NET Core Web API (Server)
- **Database**: SQL Server with Entity Framework Core
- **UI Components**: Radzen Blazor Components

## 📋 Prerequisites

Before running this application, ensure you have:

- **.NET 8.0 SDK** or later
- **SQL Server** or **SQL Server LocalDB**
- **Visual Studio 2022** or **Visual Studio Code**
- **Google Chrome** or any modern web browser

## 🛠️ Setup Instructions

### 1. Clone the Repository
```bash
git clone https://github.com/AmjadRenno/ScooterLand.git
cd ScooterLand
```

### 2. Database Setup
The application uses Entity Framework Core with SQL Server LocalDB by default.

**Connection String** (in `Server/appsettings.json`):
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(local);DataBase=ScooterlandDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True"
  }
}
```

### 3. Apply Database Migrations
```bash
cd Server
dotnet ef database update
```

### 4. Restore Dependencies
```bash
dotnet restore
```

## 🚀 Running the Application

### Method 1: Using Visual Studio
1. Open `BlazorAppClientServer.sln` in Visual Studio
2. Set **Server** project as startup project
3. Press `F5` or click "Start Debugging"

### Method 2: Using Command Line
```bash
cd Server
dotnet run
```

### 3. Access the Application
Once the server is running, open your browser and navigate to:
- **HTTPS**: `https://localhost:7081`
- **HTTP**: `http://localhost:5135`

## 📱 Application Features

### 🏠 Main Dashboard (Forside)
- Overview of today's orders
- Active mechanics summary
- Quick navigation to all sections

### 👥 Customer Management (Kunde Oversigt)
- View all customers
- Add new customers
- Edit customer information
- Link customers to specific scooter brands

### 🔧 Mechanics Management (Mekaniker Oversigt)
- Manage workshop mechanics
- Assign mechanics to work orders
- Track mechanic specializations

### 📋 Order Management (Ordre Oversigt)
- Create new work orders
- View order details with services
- Track order status and completion
- Calculate order totals automatically

### 🛠️ Services Management (Ydelse Oversigt)
- Define available services
- Set service prices and time estimates
- Categorize services by type

### 🏷️ Brand Management (Mærke)
- Manage scooter brands
- Link brands to mechanics and customers

### 🧾 Invoice Management (Faktura)
- Generate invoices from completed orders
- View invoice history
- Track payment status

## 🗂️ Project Structure

```
BlazorAppClientServer/
├── Client/                    # Blazor WebAssembly Frontend
│   ├── Pages/                # Razor Pages/Components
│   ├── Services/             # HTTP Client Services
│   ├── Shared/               # Shared Components
│   └── wwwroot/              # Static Files
├── Server/                   # ASP.NET Core Backend
│   ├── Controllers/          # Web API Controllers
│   ├── Repositories/         # Data Access Layer
│   ├── Models/               # Database Context
│   └── Migrations/           # EF Core Migrations
├── Shared/                   # Shared Models
│   └── Models/               # Data Models
└── Tests/                    # Unit Tests
```

## 🔧 Technologies Used

- **Frontend**: Blazor WebAssembly, Radzen Blazor Components
- **Backend**: ASP.NET Core 8.0, Web API
- **Database**: Entity Framework Core, SQL Server
- **UI**: Bootstrap, Radzen UI Components
- **Authentication**: (Ready for implementation)

## 📊 Database Schema

### Main Entities:
- **Kunde** (Customer): Customer information and contact details
- **Mekaniker** (Mechanic): Mechanic profiles and specializations
- **Ordre** (Order): Work orders with status tracking
- **Ydelse** (Service): Available services with pricing
- **YdelseTilOrdre** (OrderServices): Many-to-many relationship between orders and services
- **Mærke** (Brand): Scooter brands
- **Faktura** (Invoice): Invoice generation and tracking

## 🚨 Troubleshooting

### Common Issues:

1. **Database Connection Issues**:
   - Ensure SQL Server LocalDB is installed
   - Check connection string in `appsettings.json`
   - Run `dotnet ef database update` to create database

2. **CORS Issues in External Browsers**:
   - Clear browser cache (`Ctrl + Shift + Delete`)
   - Try incognito/private browsing mode
   - Use `Ctrl + F5` for hard refresh

3. **Loading Issues**:
   - Check browser console (F12) for JavaScript errors
   - Ensure all API endpoints return 200 status codes
   - Verify Blazor WebAssembly files are loading correctly

## 🔐 Security Notes

- CORS is configured for development (AllowAll policy)
- For production, update CORS policy to specific origins
- Connection string is configured in appsettings.json - update for your environment
- Consider implementing authentication and authorization
- Database connection uses Windows Authentication by default
- **Important**: Update the connection string in `appsettings.json` and `appsettings.Production.json` for your environment

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is part of a university assignment for workshop management system development.

## 👨‍💻 Development Team

Developed by **Amjad Renno** as a university project at UCL for scooter workshop management system during 2nd semester.

## 🎯 For Recruiters & Hiring Managers

This project demonstrates proficiency in:

### **Frontend Development**
- **Blazor WebAssembly**: Modern C# web framework
- **Radzen Components**: Professional UI component library
- **Responsive Design**: Bootstrap-based responsive layouts
- **State Management**: Efficient client-side data handling

### **Backend Development**
- **ASP.NET Core Web API**: RESTful API development
- **Entity Framework Core**: Database ORM and migrations
- **Repository Pattern**: Clean architecture implementation
- **Dependency Injection**: Modern software design patterns

### **Database Design**
- **Relational Database Design**: Normalized database schema
- **Entity Relationships**: Complex many-to-many relationships
- **Data Migrations**: Version-controlled database changes
- **SQL Server**: Enterprise database management

### **Software Engineering Practices**
- **Clean Code**: Well-structured and documented codebase
- **SOLID Principles**: Object-oriented design principles
- **API Design**: RESTful service architecture
- **Version Control**: Git workflow and project organization

### **Technical Skills Demonstrated**
- C# / .NET 8
- HTML5, CSS3, JavaScript
- SQL Server / T-SQL
- Visual Studio / VS Code
- Git version control
- Agile development practices

---

**Ready to manage your scooter workshop efficiently! 🛵✨**