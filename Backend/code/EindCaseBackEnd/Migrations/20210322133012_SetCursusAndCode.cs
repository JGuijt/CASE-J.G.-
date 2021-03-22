using Microsoft.EntityFrameworkCore.Migrations;

namespace EindCaseBackEnd.Migrations
{
    public partial class SetCursusAndCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CursusInstanties",
                table: "CursusInstanties");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CursusInstanties",
                table: "CursusInstanties",
                columns: new[] { "StartDatum", "Code" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CursusInstanties",
                table: "CursusInstanties");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CursusInstanties",
                table: "CursusInstanties",
                column: "Code");
        }
    }
}
