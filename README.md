# User Management Application
A full-stack **User Management System** built with **.NET 8 Web API**, **Entity Framework Core**, **SQL Server**, and **ReactJS**. This project provides CRUD operations for users with a layered architecture.

---

## Table of Contents

- [Tech Stack](#tech-stack)  
- [Project Structure](#project-structure)  
- [Prerequisites](#prerequisites)  
- [Getting Started](#getting-started)  
  - [Clone Repository](#clone-repository)  
  - [Backend Setup](#backend-setup)  
  - [Frontend Setup](#frontend-setup)  
- [Database Migration](#database-migration)  
- [Running the Application](#running-the-application)  
- [Unit Tests](#unit-tests)  
- [Testing](#testing)  
- [Screenshots](#screenshots)  
- [Notes](#notes)  

---

## Tech Stack

**Backend:**  
- .NET 8 Web API  
- C#  
- Entity Framework Core  
- SQL Server  

**Frontend:**  
- ReactJS  
- Axios for API calls  
- Bootstrap 

**Tools:**  
- Visual Studio 2022  
- Node.js & npm  
- SQL Server Management Studio  

---

## Project Structure

**Backend (`UserManagement.Api`)**  
- `Controllers/` – API endpoints  
- `Models/` – Database entities  
- `Data/` – DbContext and migrations  
- `Services/` – Business logic layer  
- `Program.cs` – Application entry point  

**Frontend (`usermanagement.web`)**  
- `src/components/` – React components  
- `src/services/` – Axios API calls  
- `src/App.js` – Root component  
- `package.json` – npm dependencies  

**Unit Tests (`UserManagement.Tests`)**  
- Contains unit tests for backend services and controllers using **xUnit**  

---

## Prerequisites

1. **.NET 8 SDK** – [Download](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
2. **Node.js (v18+) & npm** – [Download](https://nodejs.org/)  
3. **SQL Server** – [Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)  
4. **Visual Studio 2022**  

---

## Getting Started

### Clone Repository

```bash
git clone https://github.com/sajidperwez2001/UserManagementApp.git
cd UserManagementApp
```

---

### Backend Setup

1. Open the backend project in **Visual Studio**: `UserManagement.Api/UserManagement.Api.csproj`  
2. Restore NuGet packages:

```bash
dotnet restore
```

3. Update the SQL Server connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=UserManagementDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
}
```

4. Apply EF Core migrations to create the database:

```bash
dotnet ef database update -p UserManagement.Api -s UserManagement.Api
```

---

### Frontend Setup

1. Navigate to the frontend folder:

```bash
cd usermanagement.web
```

2. Install dependencies:

```bash
npm install
```

3. Start the frontend development server:

```bash
npm start
```

Frontend will run on `http://localhost:3000` by default.

---

## Database Migration

If you make changes to entities, create a new migration and update the database:

```bash
dotnet ef migrations add MigrationName -p UserManagement.Api -s UserManagement.Api
dotnet ef database update -p UserManagement.Api -s UserManagement.Api
```

---

## Running the Application

1. Run the backend API from **Visual Studio** (or via command line):

```bash
dotnet run --project UserManagement.Api
```

API will run at `https://localhost:7172` &  `http://localhost:5131` by default.

2. Run the frontend React app:

```bash
cd usermanagement.web
npm start
```

3. Access the application:  
- Frontend: `http://localhost:3000`  
- Backend API: `https://localhost:7172/api/users`   &  `http://localhost:5131/api/users`

---

## Unit Tests

**Project:** `UserManagement.Tests`

This project contains unit tests for backend services and controllers using **xUnit**.

### Running Tests

1. Build the solution to restore dependencies:

```bash
dotnet build
```

2. Run all tests via command line:

```bash
dotnet test UserManagement.Tests/UserManagement.Tests.csproj
```

3. Or run tests from Visual Studio using **Test Explorer**.  
All tests should pass if the backend services are correctly configured.

---

## Testing

- Backend API: Use **Postman** or **Swagger UI** (`http://localhost:5131/swagger`)  
- Frontend: Open in browser and verify user CRUD operations  

---

## Screenshots
- Please refer the screenshots in the Docs folder.
 

---

## Notes

- Ensure SQL Server is running before running migrations.  
- Use `dotnet restore` and `npm install` whenever cloning the repo on a new machine.  
- If ports conflict, you can change frontend port in `.env` (`PORT=3001`) or backend ports in `launchSettings.json`.

