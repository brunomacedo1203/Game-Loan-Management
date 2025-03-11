using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_Loan_Management.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Borrower = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Lender = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Game = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Genre = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LoanDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");
        }
    }
}
