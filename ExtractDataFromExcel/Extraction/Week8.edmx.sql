
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/24/2014 19:47:36
-- Generated from EDMX file: C:\Users\Zhigang Zhang\documents\visual studio 2010\Projects\ExtractDataFromExcel\Extraction\Week8.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Cisco];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EmbeddedSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmbeddedSet];
GO
IF OBJECT_ID(N'[dbo].[DurationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DurationSet];
GO
IF OBJECT_ID(N'[dbo].[Activity_CountSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Activity_CountSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmbeddedSet'
CREATE TABLE [dbo].[EmbeddedSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TimeStamp] datetime  NOT NULL,
    [Item1] nvarchar(max)  NOT NULL,
    [Item2] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DurationSet'
CREATE TABLE [dbo].[DurationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TimeStamp] datetime  NOT NULL,
    [Activity_id] nvarchar(max)  NOT NULL,
    [Activity_duration] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Activity_CountSet'
CREATE TABLE [dbo].[Activity_CountSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Activity_id] nvarchar(max)  NOT NULL,
    [Number] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EmbeddedSet'
ALTER TABLE [dbo].[EmbeddedSet]
ADD CONSTRAINT [PK_EmbeddedSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DurationSet'
ALTER TABLE [dbo].[DurationSet]
ADD CONSTRAINT [PK_DurationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Activity_CountSet'
ALTER TABLE [dbo].[Activity_CountSet]
ADD CONSTRAINT [PK_Activity_CountSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------