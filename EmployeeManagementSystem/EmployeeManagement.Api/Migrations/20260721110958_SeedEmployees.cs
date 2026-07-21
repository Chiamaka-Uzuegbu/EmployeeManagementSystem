using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateHired", "DateOfBirth", "Department", "Email", "FirstName", "IsActive", "LastName", "PhoneNumber", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "john.casor@company.com", "John", true, "Casor", "08012345678", 350000m },
                    { 2, new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "mary.johnson@company.com", "Mary", true, "Johnson", "08087654321", 420000m },
                    { 3, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "david.brown@company.com", "David", true, "Brown", "08111222333", 510000m },
                    { 4, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "sarah.uche@company.com", "Sarah", true, "Uche", "07099887766", 290000m },
                    { 5, new DateTime(2019, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "obiageli.taylor@company.com", "Obiageli", true, "Taylor", "08155667788", 600000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
