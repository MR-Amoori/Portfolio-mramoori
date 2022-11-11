using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.DataLayer.Migrations
{
    public partial class UpdateMappings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Personal_PersonalId",
                table: "Skills");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Personal_PersonalId",
                table: "Skills",
                column: "PersonalId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Personal_PersonalId",
                table: "Skills");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Personal_PersonalId",
                table: "Skills",
                column: "PersonalId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
