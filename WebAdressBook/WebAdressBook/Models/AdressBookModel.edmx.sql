
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/05/2016 01:23:45
-- Generated from EDMX file: D:\GitHub\WebAdressBook\WebAdressBook\WebAdressBook\Models\AdressBookModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WebAdressBook];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AdressBook]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdressBook];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AdressBook'
CREATE TABLE [dbo].[AdressBook] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(250)  NOT NULL,
    [Phone] nvarchar(20)  NOT NULL,
    [EMail] nvarchar(255)  NOT NULL,
    [Subdivision] nvarchar(255)  NOT NULL,
    [StatePosition] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Login] nchar(250)  NOT NULL,
    [Password] nchar(250)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AdressBook'
ALTER TABLE [dbo].[AdressBook]
ADD CONSTRAINT [PK_AdressBook]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Login] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Login] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------