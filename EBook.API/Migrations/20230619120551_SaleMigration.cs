using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBook.API.Migrations
{
    /// <inheritdoc />
    public partial class SaleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "e84c0736-46c0-45c2-89a3-e9e02915a285");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "587ea8b1-92e5-40a1-bced-2cd587072f80");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "8608af6c-f6c6-477a-a862-f44f4973dc2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "108aa570-1f0f-44dd-a581-2d32bb24775e", "AQAAAAEAACcQAAAAEGsMcwQccSS51wmS6f62K0cA+oJaK1aXA9WpqHNI1t27AcHD6AwpT5izSFaSpaWcew==", "90d9f52d-91da-426f-8954-493e9f8bd23f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1734de43-8b98-4361-a56c-9f4b2274ca03", "AQAAAAEAACcQAAAAEKvQpSXqe0eqKc9So2v+4TxXyGTHKgIuG7Yb7KKYY3tiNQ+lPfYWvJ84yGZvsrSwMQ==", "c95d643b-d6d6-4b02-adc9-b702ebfce956" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "88a2d6b7-c596-457a-8b62-f0b2ab9a4c84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "9d3cb5bd-41ec-4591-87f2-8776e057a774");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "34a0177d-efa5-438c-a4af-dd6733edc56e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "657578bd-cf60-47d1-9f59-3e2e06c02174", "AQAAAAEAACcQAAAAEPrrtnPEFiskc5apZAMHidbMKfOTFarAngtFbG7ee4NMh9vm+qe2P3s2A1W+U4DkOQ==", "2fb8baca-2366-4f86-abac-063f1afe96ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "890beae1-56a7-4999-9e17-6acc8b6b84cf", "AQAAAAEAACcQAAAAEH+ZjZkvjJe+EqgZQOYyq6IMURWjbC+VAqjrgSADY5t2Kng4exaT2doBvJAC9+s6oQ==", "4badb265-615b-4cfb-abff-3124e8feb81f" });
        }
    }
}
