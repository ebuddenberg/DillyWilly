using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class CustomerStoreName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "StoreName",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CellNumber", "City", "DateAdded", "FirstName", "LastName", "MoviesRented", "PhoneNumber", "State", "StoreName", "ZipCode" },
                values: new object[] { 2, "56 Wedge Road West", "566-788-9090", "St. Louis", new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "Michael", "Cohaart", 0, null, "MO", null, "23455" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CellNumber", "City", "DateAdded", "FirstName", "LastName", "MoviesRented", "PhoneNumber", "State", "StoreName", "ZipCode" },
                values: new object[] { 3, "8532 Dewey Road", "440-567-7861", "Montville", new DateTime(2021, 2, 7, 17, 26, 13, 781, DateTimeKind.Local).AddTicks(2692), "Rebecca", "Buddenberg", 0, null, "OH", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "StoreName",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CellNumber", "City", "DateAdded", "FirstName", "LastName", "MoviesRented", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { 1, "8532 Dewey Road", "330-956-0175", "Montville", new DateTime(2021, 2, 7, 14, 59, 13, 602, DateTimeKind.Local).AddTicks(5430), "Everett", "Buddenberg", 0, null, null, null });
        }
    }
}
