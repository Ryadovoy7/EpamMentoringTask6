using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EpamMentoringTask6.Migrations
{
    public partial class Version1_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Region",
                schema: "Northwind",
                newName: "Regions",
                newSchema: "Northwind");

            migrationBuilder.AddColumn<DateTime>(
                name: "FoundationDate",
                schema: "Northwind",
                table: "Customers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 17, 20, 42, 23, 997, DateTimeKind.Local).AddTicks(1341));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoundationDate",
                schema: "Northwind",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Regions",
                schema: "Northwind",
                newName: "Region",
                newSchema: "Northwind");
        }
    }
}
