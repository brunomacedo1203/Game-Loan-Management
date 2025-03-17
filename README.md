# Game Loan Management Web Application 🚀

I’d like to share a project I’ve been working on! This web app allows users to manage game loan records. I built it using C#, .NET Core MVC, Entity Framework, Oracle, and Bootstrap, focusing on creating a responsive and dynamic design. Users can create, read, update, and delete game loan records, as well as export data to Excel.

This project showcases my skills in full-stack development, with a particular focus on backend development and data management.

## 🛠 Technologies Used
- **Backend:** C# with .NET Core MVC  
- **Frontend:** HTML, Bootstrap, and jQuery DataTable  
- **Database:** Entity Framework with Oracle  

---

## 🚀 Getting Started

### Prerequisites

Ensure you have the following installed:

- .NET SDK  
- Node.js  
- Oracle Database  

---

## 🔧 Backend Setup

Navigate to the backend folder:
```sh
cd backend
```
Install dependencies:
```sh
dotnet restore
```
Apply migrations:
```sh
dotnet ef database update
```
Run the API:
```sh
dotnet run
```
---

## 🛠 Required NuGet Packages
Make sure to install these dependencies in your backend project:

```sh
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Oracle.EntityFrameworkCore
```

---

## 🔗 Database Connection Configuration

To connect to your Oracle database, update the connection string in `appsettings.json`:

```json
{
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    },
    "ConnectionStrings": {
        "DefaultConnection": "User Id=YOUR_USER;Password=YOUR_PASSWORD;Data Source=YOUR_HOST:1521/YOUR_DB"
    },
    "AllowedHosts": "*"
}
```
Replace `YOUR_USER`, `YOUR_PASSWORD`, `YOUR_HOST`, and `YOUR_DB` with your actual database credentials.

---

## 🚀 Running the Project

Once the backend and frontend are set up, you can run both simultaneously:

- Start the backend:  
  ```sh
  dotnet run
  ```
- Start the frontend:  
  ```sh
  ng serve
  ```
Now, your application should be running locally!

---

## 📂 Repository

Check out the full project on GitHub:  
🔗 [Game Loan Management Repository](https://github.com/brunomacedo1203/Game-Loan-Management)

---

## 🏷️ Tags
#WebDevelopment #FullStackDeveloper #Portfolio #CSharp #DotNetCore #EntityFramework #Oracle #Bootstrap #WebApp #GameLoanManagement
