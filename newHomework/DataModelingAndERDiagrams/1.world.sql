USE [master]
GO
/****** Object:  Database [world]    Script Date: 9.7.2013 г. 18:00:14 ******/
CREATE DATABASE [world]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'world', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESSGARDAX\MSSQL\DATA\world.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'world_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESSGARDAX\MSSQL\DATA\world_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [world] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [world].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [world] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [world] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [world] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [world] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [world] SET ARITHABORT OFF 
GO
ALTER DATABASE [world] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [world] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [world] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [world] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [world] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [world] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [world] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [world] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [world] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [world] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [world] SET  DISABLE_BROKER 
GO
ALTER DATABASE [world] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [world] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [world] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [world] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [world] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [world] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [world] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [world] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [world] SET  MULTI_USER 
GO
ALTER DATABASE [world] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [world] SET DB_CHAINING OFF 
GO
ALTER DATABASE [world] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [world] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [world]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 9.7.2013 г. 18:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[id] [int] NOT NULL,
	[address_text] [varchar](300) NOT NULL,
	[town_id] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Continent]    Script Date: 9.7.2013 г. 18:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Continent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Country]    Script Date: 9.7.2013 г. 18:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Country](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[continent_id] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 9.7.2013 г. 18:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varbinary](50) NOT NULL,
	[address_id] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Town]    Script Date: 9.7.2013 г. 18:00:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Town](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[country_id] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([id], [name]) VALUES (1, N'Evropa')
INSERT [dbo].[Continent] ([id], [name]) VALUES (2, N'Aziq')
SET IDENTITY_INSERT [dbo].[Continent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (1, N'bulgaria', 1)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (2, N'Germaniq', 1)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (3, N'Kitai', 2)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (4, N'Qponiq', 2)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([id], [name], [country_id]) VALUES (1, N'Sofiq', 1)
INSERT [dbo].[Town] ([id], [name], [country_id]) VALUES (2, N'Berlin', 2)
INSERT [dbo].[Town] ([id], [name], [country_id]) VALUES (5, N'Pekin', 3)
INSERT [dbo].[Town] ([id], [name], [country_id]) VALUES (6, N'Tokio', 4)
SET IDENTITY_INSERT [dbo].[Town] OFF
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([town_id])
REFERENCES [dbo].[Town] ([id])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent] FOREIGN KEY([continent_id])
REFERENCES [dbo].[Continent] ([id])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([address_id])
REFERENCES [dbo].[Address] ([id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [world] SET  READ_WRITE 
GO
