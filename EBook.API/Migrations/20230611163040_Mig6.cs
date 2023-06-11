using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBook.API.Migrations
{
    /// <inheritdoc />
    public partial class Mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "ddc1ddb9-2495-40d6-b278-633bc6ca29c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "78a31b6e-8082-4e66-96fb-7ff7c8e3b0b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "7a7fbf2b-ab87-4c6f-8782-06133345426c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "0ed5d1db-67b7-4d76-a3c8-6210128d2be7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5bbdfd3-b266-4567-83e6-4a8fe2e749dd", "AQAAAAEAACcQAAAAELqE5bbhYDImyafyPH4xWMkt0XCz8c70RjPiJhBZZVmswlu1c5DfL6qT4NhqwP0d1g==", "43e72f8c-4135-4d89-8a71-b3d0048c08c3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthLevel", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "59f65e3a-706c-4056-a0bc-c4597e08599e", 0, 1, "193e2ded-770b-4b40-a873-3add802ed3f1", "yoni@email.com", true, false, null, "YONI@EMAIL.COM", "YONI", "AQAAAAEAACcQAAAAEOAv+H4GUxqKV3jeEQsQk/5hSqkjCsiZTLcmLSJkPPRkXI6VFQnW/IhPNJuzzMqtog==", null, false, "f03159ec-91e6-42cb-af6f-0e95c064d8b1", false, "Yoni" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "59f65e3a-706c-4056-a0bc-c4597e08599e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "59f65e3a-706c-4056-a0bc-c4597e08599e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "c8c470be-4cbc-4c51-a1b4-e13fa1a801cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "e39f4a96-80ca-410c-849a-f413f0c26f9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "cece3b2b-82f6-46f1-9d5b-5258e4ecc431");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2e66c89-b519-4ba7-bd94-86e1081d5db1", "AQAAAAEAACcQAAAAEPVgIpL1l9O+8jC5SiACTHei4li7EnTIOCAfKijGjk5L9q+Z5wriDpjBs+6yY7JpsA==", "426f0abf-4d40-4dc3-a699-6f69c9d77aa4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthLevel", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", 0, 1, "724d9cf3-df65-4b84-b50b-ea34838e915f", "yoni@email.com", true, false, null, "YONI@EMAIL.COM", "YONI", "AQAAAAEAACcQAAAAEC48sGEJLnX/7FUyTCKzxWm/zs/nNhGg8EdQ0I29zPT0QkMYFuxccWUKdTMl8G0t/Q==", null, false, "f68535b2-c1a3-4b70-acd4-e839c5b720c5", false, "Yoni" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "ddc1ddb9-2495-40d6-b278-633bc6ca29c6" });
        }
    }
}
