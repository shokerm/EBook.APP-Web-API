using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBook.API.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "5480e795-444b-4e8d-a750-8861e8ea1f09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "d009e1f3-ac12-4623-8dd5-58296f39ae37");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "8fc475bb-d285-4976-bad0-712fe5f1aca3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa8773e6-582d-46e0-922b-4b80957c2cef", "AQAAAAEAACcQAAAAEDasiyuDJ9Kue3AgPJlWS5kbDIXW/DVQTRZVguCJy/Arrcfdu2x0Ki88ZINRDpFm7w==", "8733a87d-cad5-4e57-8594-13c5e96fc58a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "887b8513-80cb-4779-8637-9e35a8e0ebb5", "AQAAAAEAACcQAAAAEK2moFPPdufxc96efr2pONtkn4PmSKwyASe0eVnf5F4TLrQlZvIGe1Bvd/fxztK8dg==", "409c9984-9edc-4269-a913-c81eacf425ba" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "d6b89710-834f-46d5-837a-52534d0817d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "8f39608b-3cae-43e3-9fdf-a1874b898cab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "5c4735a0-9bbb-4d88-abfc-cf4721742b2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98be207b-0a69-4385-82d8-01c7a10f7d41", "AQAAAAEAACcQAAAAEJXyuJK1rrUP5582VQtORtjm/V5ptu0ohRxAkjS7t+BVytcSG32+v/qA8Q6Ui2C1XA==", "cd26d46a-2a76-4bad-8134-48be21a6d0bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbeb4df2-a18e-46ad-8890-72f062de415a", "AQAAAAEAACcQAAAAENPA4RWhN5IciMP5ufyStPQ+/ZZSAwMq5PgMfE9ven1EQEtQRyXlMiQD6xjz15RhRw==", "16af9321-04b3-41ee-9312-aa5170233de9" });
        }
    }
}
