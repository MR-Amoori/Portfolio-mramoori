using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.DataLayer.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "محمدرضا"),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "عموری"),
                    Age = table.Column<int>(type: "int", maxLength: 2, nullable: false, defaultValue: 18),
                    Bio = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValue: "+989035170373"),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValue: "خرمشهر"),
                    Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, defaultValue: "mohamad.reza.amoori99@gmail.com"),
                    Instagram = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "MR__Amoori"),
                    Twitter = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "mr__amoori"),
                    Github = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "MR-Amoori"),
                    Linkedin = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "mohamadreza-amoori-967ab8224"),
                    Telegram = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Doitik")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Decription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ClassIcon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_PersonalId",
                table: "Skills",
                column: "PersonalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Personal");
        }
    }
}
