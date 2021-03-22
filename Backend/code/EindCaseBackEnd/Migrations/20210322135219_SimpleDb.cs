using Microsoft.EntityFrameworkCore.Migrations;

namespace EindCaseBackEnd.Migrations
{
    public partial class SimpleDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CursusInstanties_Cursussen_CursusCode",
                table: "CursusInstanties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursussen",
                table: "Cursussen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CursusInstanties",
                table: "CursusInstanties");

            migrationBuilder.DropIndex(
                name: "IX_CursusInstanties_CursusCode",
                table: "CursusInstanties");

            migrationBuilder.DropColumn(
                name: "CursusCode",
                table: "CursusInstanties");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Cursussen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Cursussen",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "CursusInstanties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "CursusID",
                table: "CursusInstanties",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CursusID1",
                table: "CursusInstanties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursussen",
                table: "Cursussen",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CursusInstanties",
                table: "CursusInstanties",
                column: "CursusID");

            migrationBuilder.CreateIndex(
                name: "IX_CursusInstanties_CursusID1",
                table: "CursusInstanties",
                column: "CursusID1");

            migrationBuilder.AddForeignKey(
                name: "FK_CursusInstanties_Cursussen_CursusID1",
                table: "CursusInstanties",
                column: "CursusID1",
                principalTable: "Cursussen",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CursusInstanties_Cursussen_CursusID1",
                table: "CursusInstanties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursussen",
                table: "Cursussen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CursusInstanties",
                table: "CursusInstanties");

            migrationBuilder.DropIndex(
                name: "IX_CursusInstanties_CursusID1",
                table: "CursusInstanties");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Cursussen");

            migrationBuilder.DropColumn(
                name: "CursusID",
                table: "CursusInstanties");

            migrationBuilder.DropColumn(
                name: "CursusID1",
                table: "CursusInstanties");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Cursussen",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "CursusInstanties",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CursusCode",
                table: "CursusInstanties",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursussen",
                table: "Cursussen",
                column: "Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CursusInstanties",
                table: "CursusInstanties",
                columns: new[] { "StartDatum", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_CursusInstanties_CursusCode",
                table: "CursusInstanties",
                column: "CursusCode");

            migrationBuilder.AddForeignKey(
                name: "FK_CursusInstanties_Cursussen_CursusCode",
                table: "CursusInstanties",
                column: "CursusCode",
                principalTable: "Cursussen",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
