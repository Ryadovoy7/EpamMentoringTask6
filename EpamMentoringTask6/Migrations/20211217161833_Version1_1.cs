using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EpamMentoringTask6.Migrations
{
    public partial class Version1_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Credit Cards",
                schema: "Northwind",
                columns: table => new
                {
                    CardNumber = table.Column<string>(type: "nchar(16)", fixedLength: true, maxLength: 16, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardHolder = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credit Cards", x => x.CardNumber);
                    table.ForeignKey(
                        name: "FK_CreditCards_Employees",
                        column: x => x.EmployeeId,
                        principalSchema: "Northwind",
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "CardHolder",
                schema: "Northwind",
                table: "Credit Cards",
                column: "CardHolder");

            migrationBuilder.CreateIndex(
                name: "EmployeeId",
                schema: "Northwind",
                table: "Credit Cards",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "ExpirationDate",
                schema: "Northwind",
                table: "Credit Cards",
                column: "ExpirationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credit Cards",
                schema: "Northwind");
        }
    }
}
