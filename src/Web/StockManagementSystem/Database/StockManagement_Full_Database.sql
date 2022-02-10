USE [master]
GO
/****** Object:  Database [StockDB]    Script Date: 23-Sep-21 4:34:27 PM ******/
CREATE DATABASE [StockDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StockDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StockDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StockDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StockDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StockDB] SET  MULTI_USER 
GO
ALTER DATABASE [StockDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StockDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StockDB] SET QUERY_STORE = OFF
GO
USE [StockDB]
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 23-Sep-21 4:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ItemCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 23-Sep-21 4:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ItemDetails] [nvarchar](100) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[CategoryItemView]    Script Date: 23-Sep-21 4:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[CategoryItemView] as
SELECT c.CategoryId,c.CategoryName,i.ItemId,i.Name,i.ItemDetails, i.Quantity
  FROM Item i
  inner join ItemCategory c
     on i.CategoryId=c.CategoryId
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 23-Sep-21 4:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[VendorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](13) NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[VendorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 23-Sep-21 4:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[PurchaseId] [int] IDENTITY(1,1) NOT NULL,
	[VendorId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](18, 0) NOT NULL,
	[PurchaseDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PurchaseHistoryView]    Script Date: 23-Sep-21 4:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[PurchaseHistoryView] as
select p.PurchaseId
     , p.PurchaseDate
	 , p.Quantity
	 , p.UnitPrice
	 , v.VendorId
	 , v.Name as VendorName
	 , c.CategoryId
	 , c.CategoryName
	 , i.ItemId
	 , i.Name as ItemName
 from Purchase p
 inner join Vendor v
   on p.VendorId=v.VendorId
inner join Item i
   on p.ItemId=i.ItemId
inner join ItemCategory c
   on i.CategoryId=c.CategoryId
GO
/****** Object:  Table [dbo].[Client]    Script Date: 23-Sep-21 4:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](13) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 23-Sep-21 4:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[SaleDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[SaleHistoryView]    Script Date: 23-Sep-21 4:34:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view  [dbo].[SaleHistoryView] as
SELECT        p.SaleId, p.SaleDate, p.Quantity, p.UnitPrice, v.ClientId, v.Name AS ClientName, c.CategoryId, c.CategoryName, i.ItemId, i.Name AS ItemName
FROM            dbo.Sale AS p INNER JOIN
                         dbo.Client AS v ON p.ClientId = v.ClientId INNER JOIN
                         dbo.Item AS i ON p.ItemId = i.ItemId INNER JOIN
                         dbo.ItemCategory AS c ON i.CategoryId = c.CategoryId
GO
/****** Object:  Index [IX_Purchase]    Script Date: 23-Sep-21 4:34:28 PM ******/
CREATE NONCLUSTERED INDEX [IX_Purchase] ON [dbo].[Purchase]
(
	[PurchaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_ItemCategory] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ItemCategory] ([CategoryId])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_ItemCategory]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([ItemId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Item]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Vendor] FOREIGN KEY([VendorId])
REFERENCES [dbo].[Vendor] ([VendorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Vendor]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Client] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([ClientId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Client]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([ItemId])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Item]
GO
USE [master]
GO
ALTER DATABASE [StockDB] SET  READ_WRITE 
GO
