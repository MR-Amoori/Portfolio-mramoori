using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.DataLayer.Migrations
{
    public partial class AddBusinessLicenseAndCertificates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Personal",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "توسعه دهنده Full Stack وب هستم.<br/>علاقه‌مند به ساختن برنامه‌ های کاربردی تحت وب، ویندوز و ربات بوده و اکثر مطالعاتم در این حوزه می‌باشد.<br/>متولد 1383 و ساکن استان خوزستان هستم؛ فعالیتم در حوزه برنامه نویسی و آی تی رو از سال 1397 با برخی از تکنولوژی ها شروع کردم و از سال 1399 بصورت جدی وارد این دنیای بی انتها شدم.<br/>سال هاست تمرکز خودم رو روی تکنولوژی های NET. گذاشتم و تقریبا روی تمام تکنولوژی های مایکروسافت تسلط کافی دارم.<br/>من به زبان برنامه نویسی سی شارپ مسلطم و معمولا برای وب، تکنولوژی این زبان یعنی Asp.Net Core رو کار می کنم. همچنین برای اپلیکیشن های تحت دسکتاپ و ویندوز هم از تکنولوژی های WinForms و WPF استفاده می کنم.<br/>تخصص من در زمینه برنامه نویسی هست اما در زمینه های امنیت، شبکه، پشتیبانی و گرافیک هم مهارت دارم.<br/>برنامه نویسی برای ربات های اینستاگرام و تلگرام هم جزء علایق من بوده که در این زمینه هم فعالیت می‌کنم.<br/>در حال حاضر پس از گذراندن دوره دانشجویی در رشته مهندسی نرم افزار دانشگاه تبریز، در دوران مقدس سربازی (در خرمشهر) به سر می‌برم.",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.CreateTable(
                name: "BusinessLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    VerificationLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessLicenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    VerificationLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessLicenses");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Personal",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldDefaultValue: "توسعه دهنده Full Stack وب هستم.<br/>علاقه‌مند به ساختن برنامه‌ های کاربردی تحت وب، ویندوز و ربات بوده و اکثر مطالعاتم در این حوزه می‌باشد.<br/>متولد 1383 و ساکن استان خوزستان هستم؛ فعالیتم در حوزه برنامه نویسی و آی تی رو از سال 1397 با برخی از تکنولوژی ها شروع کردم و از سال 1399 بصورت جدی وارد این دنیای بی انتها شدم.<br/>سال هاست تمرکز خودم رو روی تکنولوژی های NET. گذاشتم و تقریبا روی تمام تکنولوژی های مایکروسافت تسلط کافی دارم.<br/>من به زبان برنامه نویسی سی شارپ مسلطم و معمولا برای وب، تکنولوژی این زبان یعنی Asp.Net Core رو کار می کنم. همچنین برای اپلیکیشن های تحت دسکتاپ و ویندوز هم از تکنولوژی های WinForms و WPF استفاده می کنم.<br/>تخصص من در زمینه برنامه نویسی هست اما در زمینه های امنیت، شبکه، پشتیبانی و گرافیک هم مهارت دارم.<br/>برنامه نویسی برای ربات های اینستاگرام و تلگرام هم جزء علایق من بوده که در این زمینه هم فعالیت می‌کنم.<br/>در حال حاضر پس از گذراندن دوره دانشجویی در رشته مهندسی نرم افزار دانشگاه تبریز، در دوران مقدس سربازی (در خرمشهر) به سر می‌برم.");
        }
    }
}
