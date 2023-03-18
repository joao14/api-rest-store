using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApiRest.Migrations
{
    /// <inheritdoc />
    public partial class setdataintableClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Correo", "Edad", "Nombre" },
                values: new object[,]
                {
                    { "1", "alexmerino67@gmail.com", "39", "Alexander Merino" },
                    { "2", "mariaemilia@gmail.com", "3", "Maria Emilia Merino" },
                    { "3", "martina67@gmail.com", "6", "Martina Merino" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
