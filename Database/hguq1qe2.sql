IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Personal] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(20) NOT NULL DEFAULT N'محمدرضا',
    [LastName] nvarchar(20) NOT NULL DEFAULT N'عموری',
    [Age] int NOT NULL DEFAULT 18,
    [Bio] nvarchar(2000) NOT NULL,
    [Mobile] nvarchar(15) NOT NULL DEFAULT N'+989035170373',
    [Address] nvarchar(250) NOT NULL DEFAULT N'خرمشهر',
    [Email] nvarchar(70) NOT NULL DEFAULT N'mohamad.reza.amoori99@gmail.com',
    [Instagram] nvarchar(100) NOT NULL DEFAULT N'MR__Amoori',
    [Twitter] nvarchar(100) NOT NULL DEFAULT N'mr__amoori',
    [Github] nvarchar(100) NOT NULL DEFAULT N'MR-Amoori',
    [Linkedin] nvarchar(100) NOT NULL DEFAULT N'mohamadreza-amoori-967ab8224',
    [Telegram] nvarchar(20) NOT NULL DEFAULT N'Doitik',
    CONSTRAINT [PK_Personal] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Portfolios] (
    [Id] int NOT NULL IDENTITY,
    [ImagePath] nvarchar(max) NULL,
    [Link] nvarchar(max) NULL,
    CONSTRAINT [PK_Portfolios] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Services] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Decription] nvarchar(150) NOT NULL,
    [ClassIcon] nvarchar(50) NULL,
    CONSTRAINT [PK_Services] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Skills] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [PersonalId] int NULL,
    CONSTRAINT [PK_Skills] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Skills_Personal_PersonalId] FOREIGN KEY ([PersonalId]) REFERENCES [Personal] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Skills_PersonalId] ON [Skills] ([PersonalId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221110140957_Init-Db', N'5.0.17');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Skills] DROP CONSTRAINT [FK_Skills_Personal_PersonalId];
GO

DROP INDEX [IX_Skills_PersonalId] ON [Skills];
DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Skills]') AND [c].[name] = N'PersonalId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Skills] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Skills] ALTER COLUMN [PersonalId] int NOT NULL;
ALTER TABLE [Skills] ADD DEFAULT 0 FOR [PersonalId];
CREATE INDEX [IX_Skills_PersonalId] ON [Skills] ([PersonalId]);
GO

ALTER TABLE [Skills] ADD CONSTRAINT [FK_Skills_Personal_PersonalId] FOREIGN KEY ([PersonalId]) REFERENCES [Personal] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221111093304_UpdateMappings', N'5.0.17');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Portfolios]') AND [c].[name] = N'Link');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Portfolios] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Portfolios] ALTER COLUMN [Link] nvarchar(100) NULL;
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Portfolios]') AND [c].[name] = N'ImagePath');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Portfolios] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Portfolios] ALTER COLUMN [ImagePath] nvarchar(100) NOT NULL;
ALTER TABLE [Portfolios] ADD DEFAULT N'' FOR [ImagePath];
GO

CREATE TABLE [Blogs] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(200) NOT NULL,
    [Description] nvarchar(400) NOT NULL,
    [Link] nvarchar(250) NOT NULL,
    [ImagePath] nvarchar(250) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit),
    CONSTRAINT [PK_Blogs] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221111100454_AddBlogTbl', N'5.0.17');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Contacts] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [Email] nvarchar(100) NOT NULL,
    [Title] nvarchar(80) NOT NULL,
    [Message] nvarchar(1500) NOT NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221111101320_AddContactsTbl', N'5.0.17');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Admins] (
    [Id] int NOT NULL IDENTITY,
    [UserName] nvarchar(20) NOT NULL,
    [Password] nvarchar(20) NOT NULL,
    [Email] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_Admins] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221111102005_AddAdminTbl', N'5.0.17');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Skills] DROP CONSTRAINT [FK_Skills_Personal_PersonalId];
GO

DROP INDEX [IX_Skills_PersonalId] ON [Skills];
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Skills]') AND [c].[name] = N'PersonalId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Skills] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Skills] DROP COLUMN [PersonalId];
GO

ALTER TABLE [Skills] ADD [Percentage] int NOT NULL DEFAULT 0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221111124843_Update-Tbls', N'5.0.17');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [SkillsDisplay] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_SkillsDisplay] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221111125352_AddSkillDisplayTbl', N'5.0.17');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Portfolios]') AND [c].[name] = N'Link');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Portfolios] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Portfolios] ALTER COLUMN [Link] nvarchar(100) NOT NULL;
ALTER TABLE [Portfolios] ADD DEFAULT N'' FOR [Link];
GO

ALTER TABLE [Portfolios] ADD [Title] nvarchar(50) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221111170913_RepaierPortfolioTbl', N'5.0.17');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP TABLE [SkillsDisplay];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221111175226_RemoveSkillsDisplayTbl', N'5.0.17');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Portfolios]') AND [c].[name] = N'Link');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Portfolios] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Portfolios] ALTER COLUMN [Link] nvarchar(500) NOT NULL;
GO

ALTER TABLE [Contacts] ADD [CreateDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221115112117_UpdateContactTbl', N'5.0.17');
GO

COMMIT;
GO

