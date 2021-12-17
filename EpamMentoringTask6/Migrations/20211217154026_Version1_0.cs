using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EpamMentoringTask6.Migrations
{
    public partial class Version1_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // пусто чтобы работало на существующей, у неё нет миграций.
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCustomerDemo",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "EmployeeTerritories",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Order Details",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "CustomerDemographics",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Territories",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Region",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Shippers",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "Northwind");

            migrationBuilder.DropTable(
                name: "Suppliers",
                schema: "Northwind");
        }
    }
}
