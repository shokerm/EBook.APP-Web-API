using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBook.API.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
