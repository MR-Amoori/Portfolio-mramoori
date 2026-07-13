# Portfolio Project - Mr. Amoori

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

---

## 📌 Introduction

This is a personal portfolio website built with **ASP.NET Core 5.0** and **Entity Framework Core**. The project showcases my skills, services, and projects in a professional manner.

---

## 🚀 Features

- **Responsive Design**: Works on all devices.
- **User Authentication**: Secure login and registration system.
- **Admin Panel**: Manage portfolio content easily.
- **Blog Section**: Share articles and updates.
- **Contact Form**: Easy way for visitors to get in touch.

---

## 🛠️ Technologies Used

- **Backend**: ASP.NET Core 5.0
- **Frontend**: HTML, CSS, JavaScript, Bootstrap
- **Database**: SQL Server (Entity Framework Core)
- **Authentication**: ASP.NET Core Identity
- **Deployment**: GitHub Pages, Azure (optional)

---

## 📂 Project Structure

```
Portfolio/
├── Portfolio.DataLayer/       # Data access layer
│   ├── Models/               # Entity models
│   ├── Repositories/         # Repository interfaces
│   ├── Services/             # Repository implementations
│   ├── ViewModels/           # View models
│   └── Context/              # Database context
│
├── Portfolio/                # Main web application
│   ├── Pages/                # Razor Pages
│   ├── wwwroot/              # Static files
│   └── Program.cs            # Entry point
│
├── Publishes/                # Deployment files
│   └── Config.txt            # Configuration for production
│
└── README.md                # Project documentation
```

---

## 🔧 Installation

### Prerequisites

- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (recommended)

### Steps

1. **Clone the repository**:
   ```bash
   git clone https://github.com/MR-Amoori/Portfolio-mramoori.git
   cd Portfolio-mramoori
   ```

2. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

3. **Update database**:
   ```bash
   dotnet ef database update
   ```

4. **Run the project**:
   ```bash
   dotnet run --project Portfolio
   ```

5. **Open in browser**:
   - Navigate to `http://localhost:5000` or `https://localhost:5001`.

---

## 📝 License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---

## 📞 Contact

For any questions or suggestions, feel free to reach out:

- **Email**: mohamad.amoori@example.com
- **GitHub**: [MR-Amoori](https://github.com/MR-Amoori)

---

# پروژه پورتفولیو - آقای عموری

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

---

## 📌 معرفی

این پروژه یک وب‌سایت پورتفولیو شخصی است که با استفاده از **ASP.NET Core 5.0** و **Entity Framework Core** ساخته شده است. این پروژه برای نمایش مهارت‌ها، خدمات و پروژه‌های من به صورت حرفه‌ای طراحی شده است.

---

## 🚀 ویژگی‌ها

- **طراحی ریسپانسیو**: سازگار با تمام دستگاه‌ها.
- **سیستم احراز هویت**: ورود و ثبت‌نام امن.
- **پنل مدیریت**: مدیریت آسان محتوا.
- **بخش وبلاگ**: به اشتراک گذاری مقالات و به‌روزرسانی‌ها.
- **فرم تماس**: راهی آسان برای ارتباط با بازدیدکنندگان.

---

## 🛠️ تکنولوژی‌های استفاده شده

- **بک‌اند**: ASP.NET Core 5.0
- **فرانت‌اند**: HTML، CSS، JavaScript، Bootstrap
- **دیتابیس**: SQL Server (Entity Framework Core)
- **احراز هویت**: ASP.NET Core Identity
- **استقرار**: GitHub Pages، Azure (اختیاری)

---

## 📂 ساختار پروژه

```
Portfolio/
├── Portfolio.DataLayer/       # لایه دسترسی به داده
│   ├── Models/               # مدل‌های موجودیت
│   ├── Repositories/         # اینترفیس‌های ریپازیتوری
│   ├── Services/             # پیاده‌سازی ریپازیتوری‌ها
│   ├── ViewModels/           # ویومدل‌ها
│   └── Context/              # کانتکست دیتابیس
│
├── Portfolio/                # برنامه وب اصلی
│   ├── Pages/                # صفحات Razor
│   ├── wwwroot/              # فایل‌های استاتیک
│   └── Program.cs            # نقطه ورود
│
├── Publishes/                # فایل‌های استقرار
│   └── Config.txt            # تنظیمات برای محیط Production
│
└── README.md                # مستندات پروژه
```

---

## 🔧 نصب و راه‌اندازی

### پیش‌نیازها

- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (پیشنهادی)

### مراحل نصب

1. **کلون کردن مخزن**:
   ```bash
   git clone https://github.com/MR-Amoori/Portfolio-mramoori.git
   cd Portfolio-mramoori
   ```

2. **بازگردانی وابستگی‌ها**:
   ```bash
   dotnet restore
   ```

3. **به‌روزرسانی دیتابیس**:
   ```bash
   dotnet ef database update
   ```

4. **اجرای پروژه**:
   ```bash
   dotnet run --project Portfolio
   ```

5. **باز کردن در مرورگر**:
   - به آدرس `http://localhost:5000` یا `https://localhost:5001` بروید.

---

## 📝 مجوز

این پروژه تحت **مجوز MIT** منتشر شده است. برای جزئیات بیشتر، فایل [LICENSE](LICENSE) را مشاهده کنید.

---

## 📞 تماس با من

برای هرگونه سوال یا پیشنهاد، می‌توانید با من تماس بگیرید:

- **ایمیل**: mohamad.amoori@example.com
- **GitHub**: [MR-Amoori](https://github.com/MR-Amoori)

---

**با تشکر از شما برای بازدید از پروژه من! 😊**