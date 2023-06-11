using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBook.API.Migrations
{
    /// <inheritdoc />
    public partial class Mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LikeToggleStatus",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LikeToggleStatus",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "014c1923-4747-40d5-bfd9-007cb9ce5382");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "4238e436-ebcd-4a47-b863-8b3912679993");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "ec00c397-62d8-4261-a1ab-945964dcfe95");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "631e516a-a243-4c14-b8fd-f15469f2e5fe", "AQAAAAEAACcQAAAAEPMlDdeERqrLeIqfn3YZf3p3SWQn/zPn30dZi4b2cJng9vQlL6EZ5zV3kawIm6mWOA==", "cdfdf299-2aa2-4919-b13b-d8ba6eb8ba7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d21ce609-c0a1-443d-a0b8-2435df7dc381", "AQAAAAEAACcQAAAAEIKU/if+22SqjHEfQ8BDBrbprRkqekbYugcIDbVD/NInDn6VVcwj9bavGM0nlpH03A==", "1e9b60e6-059a-46af-83b0-7d7c01655754" });
        }
    }
}
