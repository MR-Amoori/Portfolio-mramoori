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
                    Languages = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "فارسی"),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValue: "+989035170373"),
                    Freelancer = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, defaultValue: "آزاد"),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValue: "خرمشهر"),
                    Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, defaultValue: "mohamad.reza.amoori99@gmail.com"),
                    Instagram = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "MR__Amoori"),
                    Twitter = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "mr__amoori"),
                    Github = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "MR-Amoori"),
                    Linkedin = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValue: "mohamadreza-amoori-967ab8224")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personal");
        }
    }
}
