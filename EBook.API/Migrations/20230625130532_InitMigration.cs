using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EBook.API.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AuthLevel = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LikeToggleStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29", "e8861960-b964-4be4-af16-e1f6c8a2239e", "Visitor", "VISITOR" },
                    { "c32f66ed-c960-4cb7-a468-90662e1fb37a", "6a62e6e6-a895-49aa-99a6-5d0d111b3433", "Admin", "ADMIN" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "3f87ca5f-c95f-42a1-958f-f99459ffcb38", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthLevel", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "59f65e3a-706c-4056-a0bc-c4597e08599e", 0, 1, "38d2894c-561e-41fd-ba1c-1b0c39d1c312", "user@email.com", true, false, null, "USER@EMAIL.COM", "USER", "AQAAAAEAACcQAAAAEFQXudt3UYYuFsQ84fzX8pEsksCDjtDkFIf2L0+eppJ7ZPO5fnmSeYXyIY4LRc95bQ==", null, false, "efad9272-8fa5-4067-a54a-04bdddd30e97", false, "User" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, 2, "d5aa61cf-548f-40fd-824e-56f106a1236e", "admin@email.com", true, false, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEPTHY9KoJVs3RNReeSM7ESBLg4I1KOUWrRqoNm0b9NDkz3w2XvUQNF9Ui4eSwwd27A==", null, false, "6dfa6596-4843-4e6e-8f94-0a32992fd6a5", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ImageAlt", "ImageUrl", "LikeToggleStatus", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "javascript-book", "../../../../assets//images/store-images/javascript-book.jpg", "favorite_border", "JavaScript", 99.900000000000006, 1 },
                    { 2, "entity-framework-book", "../../../../assets//images/store-images/entity-framework-book.jpg", "favorite_border", "Entity Framework", 79.900000000000006, 1 },
                    { 3, "jQuery", "../../../../assets//images/store-images/jquery-book.jpg", "favorite_border", "jQuery", 59.899999999999999, 1 },
                    { 4, "Powershell", "../../../../assets//images/store-images/powershell-book.jpg", "favorite_border", "Powershell", 49.899999999999999, 1 },
                    { 5, "ReactJS", "../../../../assets//images/store-images/reactjs-book.jpg", "favorite_border", "ReactJS", 299.89999999999998, 1 },
                    { 6, "Git", "../../../../assets//images/store-images/git-book.jpg", "favorite_border", "Git", 99.900000000000006, 1 },
                    { 7, "Ruby on Rails", "../../../../assets//images/store-images/ruby-on-rails-book.jpg", "favorite_border", "Ruby on Rails", 99.900000000000006, 1 },
                    { 8, "Oracle Database", "../../../../assets//images/store-images/oracle-database-book.jpg", "favorite_border", "Oracle Database", 99.900000000000006, 1 },
                    { 9, "image-3", "../../../../assets//images/store-images/ios-developer-book.jpg", "favorite_border", "IOS Developer ", 149.90000000000001, 1 },
                    { 10, "Visual Basic .NET", "../../../../assets//images/store-images/visual-basic-dotnet-book.jpg", "favorite_border", "Visual Basic .NET", 49.899999999999999, 1 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "ItemId", "Quantity", "SaleDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 6, 25, 16, 5, 32, 52, DateTimeKind.Local).AddTicks(2835), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 2, 2, 2, new DateTime(2023, 6, 25, 16, 5, 32, 52, DateTimeKind.Local).AddTicks(2870), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 3, 3, 1, new DateTime(2023, 6, 25, 16, 5, 32, 52, DateTimeKind.Local).AddTicks(2873), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 4, 4, 3, new DateTime(2023, 6, 25, 16, 5, 32, 52, DateTimeKind.Local).AddTicks(2875), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 5, 5, 1, new DateTime(2023, 6, 25, 16, 5, 32, 52, DateTimeKind.Local).AddTicks(2877), "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { 6, 6, 1, new DateTime(2023, 6, 25, 16, 5, 32, 52, DateTimeKind.Local).AddTicks(2879), "59f65e3a-706c-4056-a0bc-c4597e08599e" },
                    { 7, 7, 1, new DateTime(2023, 6, 25, 16, 5, 32, 52, DateTimeKind.Local).AddTicks(2881), "59f65e3a-706c-4056-a0bc-c4597e08599e" },
                    { 8, 8, 1, new DateTime(2023, 6, 25, 16, 5, 32, 52, DateTimeKind.Local).AddTicks(2884), "59f65e3a-706c-4056-a0bc-c4597e08599e" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "59f65e3a-706c-4056-a0bc-c4597e08599e" },
                    { "c32f66ed-c960-4cb7-a468-90662e1fb37a", "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
