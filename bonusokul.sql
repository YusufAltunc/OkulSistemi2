USE [master]
GO
/****** Object:  Database [BonusOkul]    Script Date: 26.02.2023 23:33:18 ******/
CREATE DATABASE [BonusOkul]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BonusOkul', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BonusOkul.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BonusOkul_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BonusOkul_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BonusOkul] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BonusOkul].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BonusOkul] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BonusOkul] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BonusOkul] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BonusOkul] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BonusOkul] SET ARITHABORT OFF 
GO
ALTER DATABASE [BonusOkul] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BonusOkul] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BonusOkul] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BonusOkul] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BonusOkul] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BonusOkul] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BonusOkul] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BonusOkul] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BonusOkul] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BonusOkul] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BonusOkul] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BonusOkul] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BonusOkul] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BonusOkul] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BonusOkul] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BonusOkul] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BonusOkul] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BonusOkul] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BonusOkul] SET  MULTI_USER 
GO
ALTER DATABASE [BonusOkul] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BonusOkul] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BonusOkul] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BonusOkul] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BonusOkul] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BonusOkul]
GO
/****** Object:  Table [dbo].[TBLDERSLER]    Script Date: 26.02.2023 23:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLDERSLER](
	[dersid] [tinyint] IDENTITY(1,1) NOT NULL,
	[dersad] [varchar](30) NULL,
 CONSTRAINT [PK_TBLDERSLER] PRIMARY KEY CLUSTERED 
(
	[dersid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBLKULUPLER]    Script Date: 26.02.2023 23:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLKULUPLER](
	[kulupid] [tinyint] IDENTITY(1,1) NOT NULL,
	[kulupad] [varchar](30) NULL,
 CONSTRAINT [PK_TBLKULUPLER] PRIMARY KEY CLUSTERED 
(
	[kulupid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBLNOTLAR]    Script Date: 26.02.2023 23:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLNOTLAR](
	[notid] [int] IDENTITY(1,1) NOT NULL,
	[dersid] [tinyint] NULL,
	[ogrid] [int] NULL,
	[sınav1] [tinyint] NULL,
	[sınav2] [tinyint] NULL,
	[sınav3] [tinyint] NULL,
	[proje] [tinyint] NULL,
	[ortalama] [decimal](5, 2) NULL,
	[durum] [bit] NULL,
 CONSTRAINT [PK_TBLNOTLAR] PRIMARY KEY CLUSTERED 
(
	[notid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBLOGRENCİLER]    Script Date: 26.02.2023 23:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLOGRENCİLER](
	[ogrid] [int] IDENTITY(1,1) NOT NULL,
	[ograd] [varchar](30) NULL,
	[ogrsoyad] [varchar](30) NULL,
	[ogrkulup] [tinyint] NULL,
	[ogrcinsiyet] [varchar](5) NULL,
 CONSTRAINT [PK_TBLOGRENCİLER] PRIMARY KEY CLUSTERED 
(
	[ogrid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBLOGRETMENLER]    Script Date: 26.02.2023 23:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLOGRETMENLER](
	[ogrtid] [tinyint] IDENTITY(1,1) NOT NULL,
	[ogrtbrans] [tinyint] NULL,
	[ogrtadsoyad] [varchar](50) NULL,
 CONSTRAINT [PK_TBLOGRETMENLER_1] PRIMARY KEY CLUSTERED 
(
	[ogrtid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBLDERSLER] ON 

INSERT [dbo].[TBLDERSLER] ([dersid], [dersad]) VALUES (1, N'MATEMATİK')
INSERT [dbo].[TBLDERSLER] ([dersid], [dersad]) VALUES (2, N'YAZILIM TASARIMI')
INSERT [dbo].[TBLDERSLER] ([dersid], [dersad]) VALUES (3, N'VERİ TABANI')
INSERT [dbo].[TBLDERSLER] ([dersid], [dersad]) VALUES (4, N'ALGORİTMA')
INSERT [dbo].[TBLDERSLER] ([dersid], [dersad]) VALUES (5, N'WEB PROGRAMLAMA')
INSERT [dbo].[TBLDERSLER] ([dersid], [dersad]) VALUES (6, N'MAKİNA ÖĞRENMESİ')
INSERT [dbo].[TBLDERSLER] ([dersid], [dersad]) VALUES (7, N'AYRIK YAPILAR 2')
SET IDENTITY_INSERT [dbo].[TBLDERSLER] OFF
SET IDENTITY_INSERT [dbo].[TBLKULUPLER] ON 

INSERT [dbo].[TBLKULUPLER] ([kulupid], [kulupad]) VALUES (1, N'BİLİŞİM')
INSERT [dbo].[TBLKULUPLER] ([kulupid], [kulupad]) VALUES (2, N'SATRANÇ')
INSERT [dbo].[TBLKULUPLER] ([kulupid], [kulupad]) VALUES (3, N'KÜTÜPHANE')
INSERT [dbo].[TBLKULUPLER] ([kulupid], [kulupad]) VALUES (4, N'SAĞLIK  VE SPOR')
INSERT [dbo].[TBLKULUPLER] ([kulupid], [kulupad]) VALUES (8, N'YAPAY ZEKA')
SET IDENTITY_INSERT [dbo].[TBLKULUPLER] OFF
SET IDENTITY_INSERT [dbo].[TBLNOTLAR] ON 

INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (1, 1, 1, 75, 75, 84, 90, CAST(81.00 AS Decimal(5, 2)), 1)
INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (2, 1, 2, 75, 65, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (3, 1, 3, 85, 35, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (4, 1, 4, 87, 46, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (5, 1, 5, 88, 28, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (6, 2, 1, 88, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (7, 2, 2, 95, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (8, 2, 3, 100, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (9, 2, 4, 26, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBLNOTLAR] ([notid], [dersid], [ogrid], [sınav1], [sınav2], [sınav3], [proje], [ortalama], [durum]) VALUES (10, 2, 5, 63, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TBLNOTLAR] OFF
SET IDENTITY_INSERT [dbo].[TBLOGRENCİLER] ON 

INSERT [dbo].[TBLOGRENCİLER] ([ogrid], [ograd], [ogrsoyad], [ogrkulup], [ogrcinsiyet]) VALUES (1, N'Mehmet', N'Çınar', 1, N'Erkek')
INSERT [dbo].[TBLOGRENCİLER] ([ogrid], [ograd], [ogrsoyad], [ogrkulup], [ogrcinsiyet]) VALUES (2, N'Yılmaz', N'Aslan', 2, N'Erkek')
INSERT [dbo].[TBLOGRENCİLER] ([ogrid], [ograd], [ogrsoyad], [ogrkulup], [ogrcinsiyet]) VALUES (3, N'Emel', N'Yıldırım', 1, N'Kız')
INSERT [dbo].[TBLOGRENCİLER] ([ogrid], [ograd], [ogrsoyad], [ogrkulup], [ogrcinsiyet]) VALUES (4, N'Beyza', N'Kaya', 1, N'Kız')
INSERT [dbo].[TBLOGRENCİLER] ([ogrid], [ograd], [ogrsoyad], [ogrkulup], [ogrcinsiyet]) VALUES (5, N'Zeynep', N'Sarı', 1, N'Kız')
INSERT [dbo].[TBLOGRENCİLER] ([ogrid], [ograd], [ogrsoyad], [ogrkulup], [ogrcinsiyet]) VALUES (7, N'Test', N'Deneme', 1, N'Erkek')
INSERT [dbo].[TBLOGRENCİLER] ([ogrid], [ograd], [ogrsoyad], [ogrkulup], [ogrcinsiyet]) VALUES (8, N'AYSEL', N'KAYA', 3, N'Kız')
INSERT [dbo].[TBLOGRENCİLER] ([ogrid], [ograd], [ogrsoyad], [ogrkulup], [ogrcinsiyet]) VALUES (9, N'Ahmet', N'Makas', 4, N'Erkek')
SET IDENTITY_INSERT [dbo].[TBLOGRENCİLER] OFF
SET IDENTITY_INSERT [dbo].[TBLOGRETMENLER] ON 

INSERT [dbo].[TBLOGRETMENLER] ([ogrtid], [ogrtbrans], [ogrtadsoyad]) VALUES (1, 1, N'ZEYNEP ÖZHAN')
INSERT [dbo].[TBLOGRETMENLER] ([ogrtid], [ogrtbrans], [ogrtadsoyad]) VALUES (2, 5, N'VELİ YILMAZ')
SET IDENTITY_INSERT [dbo].[TBLOGRETMENLER] OFF
ALTER TABLE [dbo].[TBLNOTLAR]  WITH CHECK ADD  CONSTRAINT [FK_TBLNOTLAR_TBLDERSLER] FOREIGN KEY([dersid])
REFERENCES [dbo].[TBLDERSLER] ([dersid])
GO
ALTER TABLE [dbo].[TBLNOTLAR] CHECK CONSTRAINT [FK_TBLNOTLAR_TBLDERSLER]
GO
ALTER TABLE [dbo].[TBLNOTLAR]  WITH CHECK ADD  CONSTRAINT [FK_TBLNOTLAR_TBLOGRENCİLER] FOREIGN KEY([ogrid])
REFERENCES [dbo].[TBLOGRENCİLER] ([ogrid])
GO
ALTER TABLE [dbo].[TBLNOTLAR] CHECK CONSTRAINT [FK_TBLNOTLAR_TBLOGRENCİLER]
GO
ALTER TABLE [dbo].[TBLOGRENCİLER]  WITH CHECK ADD  CONSTRAINT [FK_TBLOGRENCİLER_TBLKULUPLER] FOREIGN KEY([ogrkulup])
REFERENCES [dbo].[TBLKULUPLER] ([kulupid])
GO
ALTER TABLE [dbo].[TBLOGRENCİLER] CHECK CONSTRAINT [FK_TBLOGRENCİLER_TBLKULUPLER]
GO
ALTER TABLE [dbo].[TBLOGRETMENLER]  WITH CHECK ADD  CONSTRAINT [FK_TBLOGRETMENLER_TBLDERSLER] FOREIGN KEY([ogrtbrans])
REFERENCES [dbo].[TBLDERSLER] ([dersid])
GO
ALTER TABLE [dbo].[TBLOGRETMENLER] CHECK CONSTRAINT [FK_TBLOGRETMENLER_TBLDERSLER]
GO
USE [master]
GO
ALTER DATABASE [BonusOkul] SET  READ_WRITE 
GO
