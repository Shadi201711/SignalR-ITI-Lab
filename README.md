# SignalR Employee Demo

## Introduction
This project demonstrates a simple use case of SignalR in a .NET application. The task involves adding and displaying employee information in real-time using SignalR. SignalR is a library for ASP.NET that simplifies the process of adding real-time web functionality to applications, allowing server-side code to push content to clients instantly.

## Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- Visual Studio or Visual Studio Code
- Basic knowledge of C# and ASP.NET Core

## Project Structure
```
/SignalRDemo
|-- /ClientApp
|-- /Hubs
|   |-- EmployeeHub.cs
|-- /Models
|   |-- Employee.cs
|-- /Controllers
|   |-- EmployeeController.cs
|-- /wwwroot
|   |-- index.html
|-- Startup.cs
|-- Program.cs
|-- SignalRDemo.csproj
```

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/Shadi201711/SignalR-ITI-Lab.git
   cd SignalR-ITI-Lab
   ```

2. Restore the dependencies:
   ```sh
   dotnet restore
   ```

3. Build the project:
   ```sh
   dotnet build
   ```

## Usage
1. Run the application:
   ```sh
   dotnet run
   ```

2. Open your browser and navigate to `http://localhost:5000`. You should see a simple UI to add and display employees.

## Features
- **Add Employee:** Fill out the form with the employee's name and position, then submit to add a new employee.
- **Real-time Display:** Newly added employees are displayed in real-time without refreshing the page, thanks to SignalR.

## File Descriptions

### Employee Model (`/Models/Employee.cs`)
Defines the `Employee` class with properties for ID, Name, and Position.

### Employee Hub (`/Hubs/EmployeeHub.cs`)
Handles the SignalR hub for real-time communication.

### Employee Controller (`/Controllers/EmployeeController.cs`)
Manages HTTP requests to add and display employees.

### Startup Configuration (`/Startup.cs`)
Configures the services and middleware for the application, including SignalR.

### HTML and JavaScript (`/wwwroot/index.html`)
Provides the front-end interface to interact with the application and display employee data in real-time.

## Conclusion
This simple task demonstrates the basics of using SignalR to add and display employee information in real-time. You can extend this application by adding more features like updating and deleting employees, authentication, and authorization. For more information on SignalR, visit the [official documentation](https://docs.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-5.0).
