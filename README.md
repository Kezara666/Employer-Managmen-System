
# Employee Management System

[![C# version](https://img.shields.io/badge/C%23-%3E%3D%207.0-brightgreen.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![MS SQL version](https://img.shields.io/badge/MS%20SQL-%3E%3D%202012-brightgreen.svg)](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

![Employee Management System](https://user-images.githubusercontent.com/87107996/128591883-d50c4c4f-7b4c-47ad-b7b1-6f08a7f058a6.png)

## Description
This project is an employee management system that allows companies to manage their employee data in a centralized database. The system allows HR managers to add, edit, and delete employee information, as well as generate reports on employee data.

## Features
- Add new employee information (name, email, phone number, address, etc.)
- Edit employee information
- Delete employee information
- Search for employee information by name or email
- Generate reports on employee data (e.g. employee directory, employee contact list)

## Technologies Used
- Backend: C# (.NET Framework or .NET Core)
- Database: MS SQL Server

## Prerequisites
Before you begin, ensure you have met the following requirements:
- C# 7.0 or later
- MS SQL Server 2012 or later

## Installation
To install the Employee Management System, follow these steps:
1. Clone this repository to your local machine.
```bash
git clone https://github.com/your-username/employee-management-system.git

Open the solution in Visual Studio.
Edit the appsettings.json file with your MS SQL Server connection string.
Build and run the solution in Visual Studio.
Navigate to http://localhost:3000 in your web browser to use the system.
Database Schema
Here's the SQL script to create the Employee table in the MS SQL Server database:

sql
Copy code
CREATE TABLE [dbo].[Employee] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR(50)  NOT NULL,
    [Email]     NVARCHAR(50)  NOT NULL,
    [Phone]     NVARCHAR(20)  NOT NULL,
    [Address]   NVARCHAR(100) NOT NULL,
    [CreatedAt] DATETIME2     NOT NULL,
    [UpdatedAt] DATETIME2     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
License
This project is licensed under the MIT License.

Feel free to customize this template to fit your specific project needs. Good luck with your project!
```
![Employee Management System](https://user-images.githubusercontent.com/87107996/214102284-f537eeb1-7f66-4ec8-91bf-fe29d645df7e.png)


