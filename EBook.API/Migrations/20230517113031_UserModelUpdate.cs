using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EBook.API.Migrations
{
    /// <inheritdoc />
    public partial class UserModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ImageAlt", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "javascript-book", "../../../../assets//Images/store-images/javascript-book.jpg", "JavaScript", 99.900000000000006 },
                    { 2, "entity-framework-book", "../../../../assets//Images/store-images/entity-framework-book.jpg", "Entity Framework", 79.900000000000006 },
                    { 3, "jQuery", "../../../../assets//Images/store-images/jquery-book.jpg", "jQuery", 59.899999999999999 },
                    { 4, "Powershell", "../../../../assets//Images/store-images/powershell-book.jpg", "Powershell", 49.899999999999999 },
                    { 5, "ReactJS", "../../../../assets//Images/store-images/reactjs-book.jpg", "ReactJS", 299.89999999999998 },
                    { 6, "Git", "../../../../assets//Images/store-images/git-book.jpg", "Git", 99.900000000000006 },
                    { 7, "Ruby on Rails", "../../../../assets//Images/store-images/ruby-on-rails-book.jpg", "Ruby on Rails", 99.900000000000006 },
                    { 8, "Oracle Database", "../../../../assets//Images/store-images/oracle-database-book.jpg", "Oracle Database", 99.900000000000006 },
                    { 9, "image-3", "../../../../assets//Images/store-images/ios-developer-book.jpg", "IOS Developer ", 149.90000000000001 },
                    { 10, "Visual Basic .NET", "../../../../assets//Images/store-images/visual-basic-dotnet-book.jpg", "Visual Basic .NET", 49.899999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthLevel", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 1, "user1@gmail.com", "User 1", "User1234" },
                    { 2, 1, "user2@gmail.com", "User 2", "User4321" },
                    { 3, 1, "user3@gmail.com", "User 3", "User35678" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ItemId",
                table: "Sales",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_UserId",
                table: "Sales",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
