USE [master]
GO
/****** Object:  Database [TickSys]    Script Date: 2/27/2017 12:12:07 PM ******/
CREATE DATABASE [TickSys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TickSys', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TickSys.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TickSys_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TickSys_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TickSys] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TickSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TickSys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TickSys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TickSys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TickSys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TickSys] SET ARITHABORT OFF 
GO
ALTER DATABASE [TickSys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TickSys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TickSys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TickSys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TickSys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TickSys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TickSys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TickSys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TickSys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TickSys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TickSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TickSys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TickSys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TickSys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TickSys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TickSys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TickSys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TickSys] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TickSys] SET  MULTI_USER 
GO
ALTER DATABASE [TickSys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TickSys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TickSys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TickSys] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TickSys]
GO
/****** Object:  User [Superadmin]    Script Date: 2/27/2017 12:12:07 PM ******/
CREATE USER [Superadmin] FOR LOGIN [Superadmin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 2/27/2017 12:12:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[ticket_id] [int] IDENTITY(1,1) NOT NULL,
	[ticket_subject] [varchar](100) NOT NULL,
	[ticket_issue] [varchar](max) NOT NULL,
	[ticket_sollution] [varchar](max) NULL,
	[ticket_datetime] [datetime] NULL,
	[ticket_user] [varchar](50) NULL,
	[ticket_state] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ticket_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2/27/2017 12:12:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nchar](16) NOT NULL,
	[passwd] [nchar](24) NOT NULL,
	[naam] [nvarchar](50) NULL,
	[afdeling] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([ticket_id], [ticket_subject], [ticket_issue], [ticket_sollution], [ticket_datetime], [ticket_user], [ticket_state]) VALUES (1, N'rse', N'rsfdsddf', NULL, NULL, NULL, N'Open / Onbehandeld')
SET IDENTITY_INSERT [dbo].[Tickets] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [username], [passwd], [naam], [afdeling], [email]) VALUES (1, N'admin           ', N'7b4cd                   ', NULL, NULL, NULL)
INSERT [dbo].[Users] ([Id], [username], [passwd], [naam], [afdeling], [email]) VALUES (9, N'Heindriik       ', N'test                    ', N'Hendrik', N'Sales', N'hendrik@sales.nl')
INSERT [dbo].[Users] ([Id], [username], [passwd], [naam], [afdeling], [email]) VALUES (10, N'Hein            ', N'test                    ', N'Hein', N'Technische dienst', N'hein@td.nl')
INSERT [dbo].[Users] ([Id], [username], [passwd], [naam], [afdeling], [email]) VALUES (11, N'Tinustest       ', N'test                    ', N'Tester', N'Testafdeling', N'test@test.nl')
INSERT [dbo].[Users] ([Id], [username], [passwd], [naam], [afdeling], [email]) VALUES (12, N'raoijr          ', N'12345                   ', N'koekje', N'ioajf', N'oiaj')
SET IDENTITY_INSERT [dbo].[Users] OFF
USE [master]
GO
ALTER DATABASE [TickSys] SET  READ_WRITE 
GO
