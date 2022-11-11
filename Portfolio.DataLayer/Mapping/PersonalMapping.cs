using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.Mapping
{
    class PersonalMapping : IEntityTypeConfiguration<Personal>
    {
        public void Configure(EntityTypeBuilder<Personal> builder)
        {
            builder.ToTable("Personal");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasMaxLength(20).IsRequired().HasDefaultValue("محمدرضا");

            builder.Property(x => x.LastName).HasMaxLength(20).IsRequired().HasDefaultValue("عموری");

            builder.Property(x => x.Email).HasMaxLength(70).IsRequired()
                .HasDefaultValue("mohamad.reza.amoori99@gmail.com");

            builder.Property(x => x.Address).HasMaxLength(250).IsRequired().HasDefaultValue("خرمشهر");

            builder.Property(x => x.Github).HasMaxLength(100).IsRequired().HasDefaultValue("MR-Amoori");

            builder.Property(x => x.Instagram).HasMaxLength(100).IsRequired().HasDefaultValue("MR__Amoori");

            builder.Property(x => x.Age).HasMaxLength(2).IsRequired().HasDefaultValue(18);

            builder.Property(x => x.Bio).HasMaxLength(2000).IsRequired();

            //builder.Property(x => x.Bio).HasMaxLength(2000).IsRequired().HasDefaultValue(
            //    @"توسعه دهنده Full Stack وب هستم.
            //    <br/>
            //    علاقه مند به ساختن برنامه‌ های کاربردی تحت وب، ویندوز و ربات بوده و اکثر مطالعاتم در این حوزه می باشد.
            //    <br/>
            //    متولد 1383 ساکن استان خوزستان هستم؛ فعالیتم در حوزه برنامه نویسی و آی تی رو از سال 1397 با برخی از تکنولوژی ها شروع کردم و از سال 1399 بصورت جدی وارد این دنیای بی انتها شدم.
            //    <br/>
            //    سال هاست تمرکز خودم رو روی تکنولوژی های NET. گذاشتم و تقریبا روی تمام تکنولوژی های مایکروسافت تسلط کافی دارم.
            //    من به زبان برنامه نویسی سی شارپ مسلطم و معمولا برای وب، تکنولوژی این زبان یعنی Asp.Net Core رو کار می کنم. همچنین برای اپلیکیشن های تحت دسکتاپ و ویندوز هم از تکنولوژی های WinForms و WPF استفاده می کنم.
            //    <br/>
            //    تخصص من در زمینه برنامه نویسی هست اما در زمینه های امنیت، شبکه، پشتیبانی، گرافیک و فتوشاپ هم مهارت دارم.
            //    برنامه نویسی برای ربات های اینستاگرام و تلگرام هم جز علایق من بوده که در این زمینه هم مهارتی دارم.
            //    <br/>
            //    در حال حاظر محصل رشته شبکه و نرم افزار هستم.");


            builder.Property(x => x.Linkedin).HasMaxLength(100).IsRequired()
                .HasDefaultValue("mohamadreza-amoori-967ab8224");

            builder.Property(x => x.Mobile).HasMaxLength(15).IsRequired().HasDefaultValue("+989035170373");

            builder.Property(x => x.Twitter).HasMaxLength(100).IsRequired().HasDefaultValue("mr__amoori");

            builder.Property(x => x.Telegram).HasMaxLength(20).IsRequired().HasDefaultValue("Doitik");

            builder.HasMany(x => x.Skills).WithOne(x => x.Personal).HasForeignKey(x => x.PersonalId);
        }
    }
}