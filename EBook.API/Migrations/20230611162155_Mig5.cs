using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBook.API.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "724d9cf3-df65-4b84-b50b-ea34838e915f", "AQAAAAEAACcQAAAAEC48sGEJLnX/7FUyTCKzxWm/zs/nNhGg8EdQ0I29zPT0QkMYFuxccWUKdTMl8G0t/Q==", "f68535b2-c1a3-4b70-acd4-e839c5b720c5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "152bff91-a41e-4eed-8e95-c58eb6c9474c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "a6dffab2-c671-458f-969c-d2c5191e1185");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "4e01fce2-ce77-49c7-87f6-ccebcc9da53b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fceeab94-e3b1-4b60-bf74-2d43007e7374", "AQAAAAEAACcQAAAAEADMIxTI/dinE5gofGqLOp2unV8S0iamTLbAka/f9n8pSOqMna9Mg9Ub7lngc4mo7Q==", "b6daeffc-4a0b-4ac4-a36f-03b112c73ed8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82af888a-c614-49df-b5d0-90aa90fb07b0", "AQAAAAEAACcQAAAAEMJamm/lEn1pkjCA4jnWwakNmHKRZx58jYa4wbxRJrYMJsUJPZyFeddQCUZuBaQ5Ag==", "d74918f7-e4da-427b-a421-18dbe80a4379" });
        }
    }
}
