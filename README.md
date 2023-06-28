## EBook App Web API 
- RESTful API for user & products management.
- CRUD oprations.

## Table of Contents

- [Features](#features)
- [API Access](#api-access)
- [Installation](#installation)



## Features:
- SQL Database with Entity Framework Code First.
- Data is seeded on installation.
- LINQ Queries.
- Usage of AutoMapper & DTO's.
- JWT Authentication & Identity Core.
- Authorization: 3 user roles - ["Visitor", "User", "Admin"].

## API Access
| User              | Password                   | Access       |            
| :---------------  | :------------------------- | :----------- | 
| admin@email.com   | Aa@1234                    | Administrator|  
| user@email.com    | Bb@4321                    | User         |  
| visitor@email.com | Cc@1324                    | Visitor      |  

## Installation

To install the EBook API, follow these steps:
- Clone the repository to your local machine using the following command:
```bash
git clone https://github.com/shokerm/EBook.APP-Web-API.git
```
- Open the solution file EBook.sln in Visual Studio.
- Build the solution to restore NuGet packages and compile the project.
- Create a new Microsoft SQL Server database to store the application data.
- Open the file appsettings.json located in the EBook project folder and modify the following connection string with your own Microsoft SQL Server database connection string:
```bash
"ConnectionStrings": {
  "ConnectionString": "Server=<your-server-name>;Database=EBookDB;Trusted_Connection = True;TrustServerCertificate= True;"
}
```
- Open the file secrets.json located in the EBook project folder and set the following key:
```bash
"Keys": {
"Key": "this is my amazing very Secret key for authentication"
}
```

- Open the Package Manager Console in Visual Studio, select the EBook.Data project, and run the following command to create the database schema:
```bash
update-database
```
- Run the project in Visual Studio, The API server should now be running on your local machine & you should see Swagger Api Documentation.
- User Registration: - User must register himself by filling some personal details.
- User Login: After registration user will enter Email and password for logging in order to get access to the system.
- Personal: User can edit personal details, Admininstrator can edit/delete all users details.

  

