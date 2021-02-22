using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class InitialCustomerTableAddZipCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                type: "TEXT",
                maxLength: 2,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CellNumber", "City", "DateAdded", "FirstName", "LastName", "MoviesRented", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { 1, "8532 Dewey Road", "330-956-0175", "Montville", new DateTime(2021, 2, 7, 14, 59, 13, 602, DateTimeKind.Local).AddTicks(5430), "Everett", "Buddenberg", 0, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");
        }
    }
}
