using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.DataLayer.Migrations
{
    public partial class UpdateTbls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Personal_PersonalId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_PersonalId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "Percentage",
                table: "Skills",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percentage",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_PersonalId",
                table: "Skills",
                column: "PersonalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Personal_PersonalId",
                table: "Skills",
                column: "PersonalId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
