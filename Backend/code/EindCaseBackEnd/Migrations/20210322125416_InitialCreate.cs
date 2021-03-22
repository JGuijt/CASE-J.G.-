using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EindCaseBackEnd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursussen",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Duur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursussen", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "CursusInstanties",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CursusCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursusInstanties", x => x.Code);
                    table.ForeignKey(
                        name: "FK_CursusInstanties_Cursussen_CursusCode",
                        column: x => x.CursusCode,
                        principalTable: "Cursussen",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CursusInstanties_CursusCode",
                table: "CursusInstanties",
                column: "CursusCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursusInstanties");

            migrationBuilder.DropTable(
                name: "Cursussen");
        }
    }
}
