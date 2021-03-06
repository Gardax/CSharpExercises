USE [master]
GO
/****** Object:  Database [Dictionary]    Script Date: 9.7.2013 г. 17:17:21 ч. ******/
CREATE DATABASE [Dictionary] ON  PRIMARY 
( NAME = N'Dictionary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Dictionary.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Dictionary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Dictionary_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Dictionary] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dictionary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dictionary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dictionary] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Dictionary] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Dictionary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dictionary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dictionary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dictionary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dictionary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dictionary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dictionary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dictionary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dictionary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dictionary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dictionary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dictionary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dictionary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dictionary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dictionary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Dictionary] SET  MULTI_USER 
GO
ALTER DATABASE [Dictionary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dictionary] SET DB_CHAINING OFF 
GO
USE [Dictionary]
GO
/****** Object:  Table [dbo].[Explanations]    Script Date: 9.7.2013 г. 17:17:21 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Explanations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](100) NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_Explanations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Languages]    Script Date: 9.7.2013 г. 17:17:21 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Parts_of_Speech]    Script Date: 9.7.2013 г. 17:17:21 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parts_of_Speech](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Parts_of_Speech] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words]    Script Date: 9.7.2013 г. 17:17:21 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](50) NOT NULL,
	[LanguageId] [int] NOT NULL,
	[AntonymId] [int] NOT NULL,
	[PartOfSpeechId] [int] NOT NULL,
	[HypernymId] [int] NULL,
	[HyponymId] [int] NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Explanations]    Script Date: 9.7.2013 г. 17:17:21 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Explanations](
	[WordId] [int] NOT NULL,
	[ExplanationId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Synonyms]    Script Date: 9.7.2013 г. 17:17:21 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Synonyms](
	[WordId] [int] NOT NULL,
	[SynonymId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Translations]    Script Date: 9.7.2013 г. 17:17:21 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Translations](
	[WordId] [int] NOT NULL,
	[TranslationId] [int] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Explanations_Languages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO
ALTER TABLE [dbo].[Explanations] CHECK CONSTRAINT [FK_Explanations_Languages]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Hypernyms] FOREIGN KEY([HypernymId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Hypernyms]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Hyponyms] FOREIGN KEY([HyponymId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Hyponyms]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Languages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Languages]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Parts_of_Speech] FOREIGN KEY([PartOfSpeechId])
REFERENCES [dbo].[Parts_of_Speech] ([Id])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Parts_of_Speech]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Words] FOREIGN KEY([AntonymId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Words]
GO
ALTER TABLE [dbo].[Words_Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Explanations_Explanations] FOREIGN KEY([ExplanationId])
REFERENCES [dbo].[Explanations] ([Id])
GO
ALTER TABLE [dbo].[Words_Explanations] CHECK CONSTRAINT [FK_Words_Explanations_Explanations]
GO
ALTER TABLE [dbo].[Words_Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Explanations_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Words_Explanations] CHECK CONSTRAINT [FK_Words_Explanations_Words]
GO
ALTER TABLE [dbo].[Words_Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Words_Synonyms_Synonyms] FOREIGN KEY([SynonymId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Words_Synonyms] CHECK CONSTRAINT [FK_Words_Synonyms_Synonyms]
GO
ALTER TABLE [dbo].[Words_Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Words_Synonyms_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Words_Synonyms] CHECK CONSTRAINT [FK_Words_Synonyms_Words]
GO
ALTER TABLE [dbo].[Words_Translations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Translations_Translations] FOREIGN KEY([TranslationId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Words_Translations] CHECK CONSTRAINT [FK_Words_Translations_Translations]
GO
ALTER TABLE [dbo].[Words_Translations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Translations_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Words_Translations] CHECK CONSTRAINT [FK_Words_Translations_Words]
GO
USE [master]
GO
ALTER DATABASE [Dictionary] SET  READ_WRITE 
GO
