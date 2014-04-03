USE [master]
GO

/****** Object:  Database [VacationDB]    Script Date: 12/16/2013 14:46:10 ******/
CREATE DATABASE [VacationDB] ON  PRIMARY 
( NAME = N'VacationDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\VacationDB.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VacationDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\VacationDB_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [VacationDB] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VacationDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [VacationDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [VacationDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [VacationDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [VacationDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [VacationDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [VacationDB] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [VacationDB] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [VacationDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [VacationDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [VacationDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [VacationDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [VacationDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [VacationDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [VacationDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [VacationDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [VacationDB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [VacationDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [VacationDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [VacationDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [VacationDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [VacationDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [VacationDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [VacationDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [VacationDB] SET  READ_WRITE 
GO

ALTER DATABASE [VacationDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [VacationDB] SET  MULTI_USER 
GO

ALTER DATABASE [VacationDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [VacationDB] SET DB_CHAINING OFF 
GO

