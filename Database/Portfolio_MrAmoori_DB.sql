USE [master]
GO
/****** Object:  Database [Portfolio_MrAmoori_DB]    Script Date: 11/19/2022 16:42:07 ******/
CREATE DATABASE [Portfolio_MrAmoori_DB] ON  PRIMARY 
( NAME = N'Portfolio_MrAmoori_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Portfolio_MrAmoori_DB.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Portfolio_MrAmoori_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Portfolio_MrAmoori_DB_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Portfolio_MrAmoori_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET ARITHABORT OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET  ENABLE_BROKER
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET READ_COMMITTED_SNAPSHOT ON
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET  READ_WRITE
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET RECOVERY FULL
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET  MULTI_USER
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Portfolio_MrAmoori_DB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Portfolio_MrAmoori_DB', N'ON'
GO
USE [Portfolio_MrAmoori_DB]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221110140957_Init-Db', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221111093304_UpdateMappings', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221111100454_AddBlogTbl', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221111101320_AddContactsTbl', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221111102005_AddAdminTbl', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221111124843_Update-Tbls', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221111125352_AddSkillDisplayTbl', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221111170913_RepaierPortfolioTbl', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221111175226_RemoveSkillsDisplayTbl', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221115112117_UpdateContactTbl', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221117222335_InitIdentityTbls', N'5.0.17')
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers] 
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers] 
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'944762f5-0495-4a53-bbcd-a1055a52faf8', N'mohamad.reza.amoori99@gmail.com', N'MOHAMAD.REZA.AMOORI99@GMAIL.COM', N'mohamad.reza.amoori99@gmail.com', N'MOHAMAD.REZA.AMOORI99@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEEIMBbQoeJF7wqh6/wxZoBsuz9sqmABJyGmugMHbRLgc3qe8qpCY1xpJw5t2lx7Fnw==', N'7JBX25T7PKB3JDXORWX3ZCFZIHGIYJJ7', N'9be965a0-6a3b-46e7-92b9-9da586aaf53d', N'09035170373', 1, 0, NULL, 1, 0)
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles] 
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skills]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Percentage] [int] NOT NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Skills] ON
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (1, N'#C', 90)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (2, N'Asp.Net MVC', 95)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (3, N'Asp.Net Core', 90)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (4, N'DotNet Core', 95)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (5, N'Windows Forms', 95)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (6, N'Web Design', 90)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (7, N'Html 5', 90)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (11, N'CSS 3', 85)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (12, N'Bootstrap', 85)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (13, N'JavaScript', 80)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (14, N'WordPress', 85)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (15, N'SEO', 80)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (16, N'Sql Server', 85)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (17, N'EF Core', 90)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (19, N'SignalR', 85)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (20, N'Adobe Photoshop', 80)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (21, N'Adobe Illustrator', 75)
INSERT [dbo].[Skills] ([Id], [Name], [Percentage]) VALUES (22, N'Telegram Bot', 95)
SET IDENTITY_INSERT [dbo].[Skills] OFF
/****** Object:  Table [dbo].[Services]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Decription] [nvarchar](150) NOT NULL,
	[ClassIcon] [nvarchar](50) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Services] ON
INSERT [dbo].[Services] ([Id], [Name], [Decription], [ClassIcon]) VALUES (2, N'توسعه نرم افزار', N'توسعه و برنامه نویسی نرم افزار های تحت وب، دسکتاپ و موبایل با سعی بر پیاده سازی بهینه ترین الگوی های طراحی.', N'fas fa-code')
INSERT [dbo].[Services] ([Id], [Name], [Decription], [ClassIcon]) VALUES (3, N'طراحی گرافیک', N'یکی دیگه از مهارت های من در زمینه طراحی های گرافیکی است که با نرم افزار های فتوشاپ، ایلاستریتور و... به انجام آن می پردازم.', N'fas fa-paint-brush')
INSERT [dbo].[Services] ([Id], [Name], [Decription], [ClassIcon]) VALUES (4, N'سئو', N'بهینه سازی سایت برای موتورهای جستجو یکی از مهمترین نیاز برای وبسایت های فعال است.', N'fas fa-bullhorn')
INSERT [dbo].[Services] ([Id], [Name], [Decription], [ClassIcon]) VALUES (5, N'پشتیبانی', N'مدیریت و پشتیبانی اپلیکیشن ها یکی دیگر از فاکتور های مهم یک کسب کار موفق است.', N'fas fa-envelope')
INSERT [dbo].[Services] ([Id], [Name], [Decription], [ClassIcon]) VALUES (6, N'طراحی واکنش گرا', N'امروزه اپلیکیشن ها با انواع دیوایس ها و رزولیشن های مختلف بازدید می شوند و باید نسبت به اندازه هر دیوایس تنظیم شوند و ریسپانسیو باشند.', N'fas fa-mobile')
INSERT [dbo].[Services] ([Id], [Name], [Decription], [ClassIcon]) VALUES (7, N'وردپرس', N'یکی از سیستم های مدیریت محتوای (CMS) مشهور در حال حاضر وردپرس است که طراحی با آن بسیار لذت بخش، سریع تر و دور از پیچیدگی است.', N'fab fa-wordpress')
INSERT [dbo].[Services] ([Id], [Name], [Decription], [ClassIcon]) VALUES (12, N'تست نرم افزار', N'با بالارفتن سطح توقع کاربران از نرم افزارها، موضوع تست نرم افزار برای صحت عملکرد بسیار پراهمیت تر از گذشته شده است.', N'fas fa-solid fa-bug')
SET IDENTITY_INSERT [dbo].[Services] OFF
/****** Object:  Table [dbo].[Portfolios]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Portfolios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](100) NOT NULL,
	[Link] [nvarchar](500) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Portfolios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Portfolios] ON
INSERT [dbo].[Portfolios] ([Id], [ImagePath], [Link], [Title]) VALUES (6, N'https://iili.io/H9SRdep.jpg', N'https://github.com/MR-Amoori/Store_Accounting_Mobile/releases/tag/Final', N'نرم افزار حسابداری')
INSERT [dbo].[Portfolios] ([Id], [ImagePath], [Link], [Title]) VALUES (7, N'https://iili.io/H9S5wtS.png', N'https://github.com/MR-Amoori/Bot-Telegram/releases/tag/V2.0.0', N'مدیریت ربات تلگرام')
INSERT [dbo].[Portfolios] ([Id], [ImagePath], [Link], [Title]) VALUES (8, N'https://iili.io/H9S5Oo7.png', N'https://github.com/MR-Amoori/Store-Accounting', N'مدیریت مشتریان و محصولات')
INSERT [dbo].[Portfolios] ([Id], [ImagePath], [Link], [Title]) VALUES (9, N'https://iili.io/H9SlZ8u.jpg', N'https://coverlandks.ir/', N'سایت کاورلند')
INSERT [dbo].[Portfolios] ([Id], [ImagePath], [Link], [Title]) VALUES (10, N'https://iili.io/H9S1Oes.md.png', N'https://www.ordibeheshtbook.com/', N'سایت کتاب اردیبهشت')
INSERT [dbo].[Portfolios] ([Id], [ImagePath], [Link], [Title]) VALUES (11, N'https://iili.io/H9SEKhv.png', N'https://kalanbazar.com/', N'سایت کلان بازار')
INSERT [dbo].[Portfolios] ([Id], [ImagePath], [Link], [Title]) VALUES (12, N'https://iili.io/H9SGUU7.md.png', N'https://cryptonesh.com/', N'سایت کریپتونش')
INSERT [dbo].[Portfolios] ([Id], [ImagePath], [Link], [Title]) VALUES (13, N'https://iili.io/H9SM3sR.md.png', N'https://daftarjan.com/', N'سایت دفتر جان')
INSERT [dbo].[Portfolios] ([Id], [ImagePath], [Link], [Title]) VALUES (14, N'https://iili.io/H9SMad7.md.png', N'https://baheranbag.com/', N'سایت باهران بگ')
SET IDENTITY_INSERT [dbo].[Portfolios] OFF
/****** Object:  Table [dbo].[Personal]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[Age] [int] NOT NULL,
	[Bio] [nvarchar](2000) NOT NULL,
	[Mobile] [nvarchar](15) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[Email] [nvarchar](70) NOT NULL,
	[Instagram] [nvarchar](100) NOT NULL,
	[Twitter] [nvarchar](100) NOT NULL,
	[Github] [nvarchar](100) NOT NULL,
	[Linkedin] [nvarchar](100) NOT NULL,
	[Telegram] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Personal] ON
INSERT [dbo].[Personal] ([Id], [FirstName], [LastName], [Age], [Bio], [Mobile], [Address], [Email], [Instagram], [Twitter], [Github], [Linkedin], [Telegram]) VALUES (1, N'محمدرضا', N'عموری', 18, N'&lt;p&gt; توسعه دهنده Full Stack وب هستم.
                &lt; br/&gt;
                علاقه مند به ساختن برنامه‌ های کاربردی تحت وب، ویندوز و ربات بوده و اکثر مطالعاتم در این حوزه می باشد.
                &lt;br/&gt;
                متولد 1383 ساکن استان خوزستان هستم؛ فعالیتم در حوزه برنامه نویسی و آی تی رو از سال 1397 با برخی از تکنولوژی ها شروع کردم و از سال 1399 بصورت جدی وارد این دنیای بی انتها شدم.
                &lt;br/&gt;
                سال هاست تمرکز خودم رو روی تکنولوژی های NET. گذاشتم و تقریبا روی تمام تکنولوژی های مایکروسافت تسلط کافی دارم.
                من به زبان برنامه نویسی سی شارپ مسلطم و معمولا برای وب، تکنولوژی این زبان یعنی Asp.Net Core رو کار می کنم. همچنین برای اپلیکیشن های تحت دسکتاپ و ویندوز هم از تکنولوژی های WinForms و WPF استفاده می کنم.
                &lt;br/&gt;
                تخصص من در زمینه برنامه نویسی هست اما در زمینه های امنیت، شبکه، پشتیبانی، گرافیک و فتوشاپ هم مهارت دارم.
                برنامه نویسی برای ربات های اینستاگرام و تلگرام هم جز علایق من بوده که در این زمینه هم مهارتی دارم.
                &lt;br/&gt;
                در حال حاظر محصل رشته شبکه و نرم افزار هستم.', N'09035170373', N'ایران، خوزستان', N'mramoori.dev@gmail.com', N'MR__Amoori', N'MR__Amoori', N'MR-Amoori', N'mohamadreza-amoori-967ab8224', N'doitik')
SET IDENTITY_INSERT [dbo].[Personal] OFF
/****** Object:  Table [dbo].[Contacts]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Title] [nvarchar](80) NOT NULL,
	[Message] [nvarchar](1500) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](400) NOT NULL,
	[Link] [nvarchar](250) NOT NULL,
	[ImagePath] [nvarchar](250) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON
INSERT [dbo].[Blogs] ([Id], [Title], [Description], [Link], [ImagePath], [CreateDate], [IsDeleted]) VALUES (2, N'دروووغ', N'ایران', N'تست لینک', N'تست', CAST(0x070000000000000000 AS DateTime2), 1)
INSERT [dbo].[Blogs] ([Id], [Title], [Description], [Link], [ImagePath], [CreateDate], [IsDeleted]) VALUES (3, N'ایران ', N'بهترین تصویر', N'https://barnamenevisan.org/r/9003', N'https://barnamenevisan.org/ArticleFiles/ArticleImage/Image/9003_Untitled-4jpg.jpg', CAST(0x079493FB2875A9440B AS DateTime2), 1)
INSERT [dbo].[Blogs] ([Id], [Title], [Description], [Link], [ImagePath], [CreateDate], [IsDeleted]) VALUES (4, N'asdasda', N'sdasd', N'asdsad', N'aa', CAST(0x07F185F6B88FA9440B AS DateTime2), 1)
INSERT [dbo].[Blogs] ([Id], [Title], [Description], [Link], [ImagePath], [CreateDate], [IsDeleted]) VALUES (5, N'asdasda', N'sdasd', N'asdasdasd', N'a', CAST(0x07FC4406BC8FA9440B AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Blogs] OFF
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims] 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles] 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins] 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/19/2022 16:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims] 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Default [DF__Skills__Percenta__2C3393D0]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Skills] ADD  DEFAULT ((0)) FOR [Percentage]
GO
/****** Object:  Default [DF__Portfolio__Image__24927208]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Portfolios] ADD  CONSTRAINT [DF__Portfolio__Image__24927208]  DEFAULT (N'') FOR [ImagePath]
GO
/****** Object:  Default [DF__Portfolio__Title__300424B4]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Portfolios] ADD  CONSTRAINT [DF__Portfolio__Title__300424B4]  DEFAULT (N'') FOR [Title]
GO
/****** Object:  Default [DF__Personal__FirstN__014935CB]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'محمدرضا') FOR [FirstName]
GO
/****** Object:  Default [DF__Personal__LastNa__023D5A04]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'عموری') FOR [LastName]
GO
/****** Object:  Default [DF__Personal__Age__03317E3D]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT ((18)) FOR [Age]
GO
/****** Object:  Default [DF__Personal__Mobile__0425A276]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'+989035170373') FOR [Mobile]
GO
/****** Object:  Default [DF__Personal__Addres__0519C6AF]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'خرمشهر') FOR [Address]
GO
/****** Object:  Default [DF__Personal__Email__060DEAE8]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'mohamad.reza.amoori99@gmail.com') FOR [Email]
GO
/****** Object:  Default [DF__Personal__Instag__07020F21]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'MR__Amoori') FOR [Instagram]
GO
/****** Object:  Default [DF__Personal__Twitte__07F6335A]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'mr__amoori') FOR [Twitter]
GO
/****** Object:  Default [DF__Personal__Github__08EA5793]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'MR-Amoori') FOR [Github]
GO
/****** Object:  Default [DF__Personal__Linked__09DE7BCC]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'mohamadreza-amoori-967ab8224') FOR [Linkedin]
GO
/****** Object:  Default [DF__Personal__Telegr__0AD2A005]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Personal] ADD  DEFAULT (N'Doitik') FOR [Telegram]
GO
/****** Object:  Default [DF__Contacts__Create__35BCFE0A]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Contacts] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreateDate]
GO
/****** Object:  Default [DF__Blogs__IsDeleted__276EDEB3]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[Blogs] ADD  DEFAULT (CONVERT([bit],(0),0)) FOR [IsDeleted]
GO
/****** Object:  ForeignKey [FK_AspNetUserTokens_AspNetUsers_UserId]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_AspNetRoleClaims_AspNetRoles_RoleId]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
/****** Object:  ForeignKey [FK_AspNetUserRoles_AspNetRoles_RoleId]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
/****** Object:  ForeignKey [FK_AspNetUserRoles_AspNetUsers_UserId]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_AspNetUserLogins_AspNetUsers_UserId]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_AspNetUserClaims_AspNetUsers_UserId]    Script Date: 11/19/2022 16:42:07 ******/
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
