﻿/*
Deployment script for newDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "newDatabase"
:setvar DefaultFilePrefix "newDatabase"
:setvar DefaultDataPath "C:\Users\USER\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\USER\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [dbo].[RegisteredUsers]...';


GO
CREATE TABLE [dbo].[RegisteredUsers] (
    [lid]          INT           IDENTITY (1, 1) NOT NULL,
    [emailAddress] VARCHAR (250) NOT NULL,
    [password]     VARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([lid] ASC)
);


GO
PRINT N'Update complete.';


GO