IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'ShowTrack')
BEGIN
    CREATE DATABASE ShowTrack;
END
GO

USE ShowTrack;
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[User] (
        [Id]                INT IDENTITY(1,1) NOT NULL,
        [Username]          NVARCHAR(50)  NULL,
        [Email]             NVARCHAR(100) NULL,
        [Password]          NVARCHAR(50)  NULL,
        [AccountCreateDate] DATE          NULL,
        CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MailLog]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[MailLog] (
        [Id]               INT IDENTITY(1,1) NOT NULL,
        [UserId]           INT           NULL,
        [EmailAddress]     NVARCHAR(100) NOT NULL,
        [VerificationCode] NVARCHAR(10)  NULL,
        [Message]          NVARCHAR(MAX) NULL,
        CONSTRAINT [PK_MailLog] PRIMARY KEY CLUSTERED ([Id] ASC),
        CONSTRAINT [FK_MailLog_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Watchlist]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Watchlist] (
        [Id]     INT IDENTITY(1,1) NOT NULL,
        [UserId] INT           NOT NULL,
        [ImdbId] NVARCHAR(20)  NOT NULL,
        CONSTRAINT [PK_Watchlist] PRIMARY KEY CLUSTERED ([Id] ASC),
        CONSTRAINT [FK_Watchlist_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
    );
END
GO