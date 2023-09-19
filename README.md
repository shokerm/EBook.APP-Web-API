## ![favicon-32x32](https://github.com/shokerm/EBook.APP-Web-API/assets/96984377/c0e6f574-5459-4839-a274-967ee5732692) EBook App Web API 
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
- Hosting: Azure - [EBook-Azure-Api](https://ebookapi20230627230225.azurewebsites.net/swagger) - <em><strong> temporarily disabled </strong></em>.



## API Access
| User              | Password                   | Access       |  Access & Abilities           |        
| :---------------  | :------------------------- | :----------- | :-----------
| admin@email.com   | Aa@1234                    | Administrator|  Full access to any page in the app and observe <strong>any user & order</strong> details.<br> Purchase products.<br>Add/Edit/Delete products, any user's orders and accounts <br> Modify <strong>any user's</strong> account details: username/email/password.<br> Can Change the permission levels of <strong>all users</strong>.<br>The only one who can see the buttons for adding, editing and deleting products.|
| user@email.com    | Bb@4321                    | User         |Full access to any page in the app and observe <strong>its own</strong> user details.<br> Purchase products.<br>Observe <strong>its own</strong> user details.<br>Add/Edit/Delete <strong>its own</strong> orders.<br> Modify <strong>its own</strong> account's details:  username/email/password. |
| visitor@email.com | Cc@1324                    | Visitor      |Limited access.<br> Purchase products. <br> Observe <strong>its own</strong> user details.<br>Add/Edit/Delete <strong>its own</strong> orders.<br> Modify <strong>its own</strong> account's details: username/email/password.<br><strong>Not authorized</strong> to see "my book" page. |

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

  

