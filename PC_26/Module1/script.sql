USE [master]
GO
/****** Object:  Database [DB_PC_26_Module1]    Script Date: 28/10/2019 11:07:21 ******/
CREATE DATABASE [DB_PC_26_Module1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_PC_26_Modul1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DB_PC_26_Modul1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_PC_26_Modul1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DB_PC_26_Modul1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DB_PC_26_Module1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_PC_26_Module1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_PC_26_Module1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_PC_26_Module1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_PC_26_Module1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_PC_26_Module1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_PC_26_Module1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_PC_26_Module1] SET  MULTI_USER 
GO
ALTER DATABASE [DB_PC_26_Module1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_PC_26_Module1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_PC_26_Module1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_PC_26_Module1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_PC_26_Module1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_PC_26_Module1] SET QUERY_STORE = OFF
GO
USE [DB_PC_26_Module1]
GO
/****** Object:  Table [dbo].[detail_order]    Script Date: 28/10/2019 11:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detail_order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[header_order_id] [int] NOT NULL,
	[menu_id] [int] NOT NULL,
	[orde_price] [decimal](8, 2) NOT NULL,
	[quantitiy] [int] NOT NULL,
 CONSTRAINT [PK_detail_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[header_order]    Script Date: 28/10/2019 11:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[header_order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_made_time] [datetime] NOT NULL,
	[table_number] [int] NOT NULL,
	[customer_name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_header_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 28/10/2019 11:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[menu_category_id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
	[price] [decimal](8, 2) NOT NULL,
	[description] [varchar](200) NULL,
	[is_favorite] [bit] NULL,
 CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu_category]    Script Date: 28/10/2019 11:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu_category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_menu_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payment]    Script Date: 28/10/2019 11:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment](
	[id] [varchar](50) NULL,
	[header_order_id] [varchar](50) NULL,
	[promotion_id] [varchar](50) NULL,
	[payment_type] [varchar](50) NULL,
	[amount_to_pay] [varchar](50) NULL,
	[amount_paid] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[promotion]    Script Date: 28/10/2019 11:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[promotion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](20) NOT NULL,
	[discount] [decimal](5, 2) NOT NULL,
	[minimum_spent] [decimal](10, 2) NOT NULL,
	[star_time] [datetime] NOT NULL,
	[end_time] [datetime] NOT NULL,
 CONSTRAINT [PK_promotion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[menu] ON 

INSERT [dbo].[menu] ([id], [menu_category_id], [name], [price], [description], [is_favorite]) VALUES (1, 1, N'Ayam', CAST(20000.00 AS Decimal(8, 2)), N'', 0)
INSERT [dbo].[menu] ([id], [menu_category_id], [name], [price], [description], [is_favorite]) VALUES (2, 1, N'Nasi', CAST(5000.00 AS Decimal(8, 2)), N'ini nasi putih', 0)
INSERT [dbo].[menu] ([id], [menu_category_id], [name], [price], [description], [is_favorite]) VALUES (3, 1, N'Fried Rice', CAST(5000.00 AS Decimal(8, 2)), N'Fried rice level 1-10', 1)
INSERT [dbo].[menu] ([id], [menu_category_id], [name], [price], [description], [is_favorite]) VALUES (4, 1, N'Fried Chicken', CAST(5000.00 AS Decimal(8, 2)), N'Fried Chicken KFC', 1)
SET IDENTITY_INSERT [dbo].[menu] OFF
SET IDENTITY_INSERT [dbo].[menu_category] ON 

INSERT [dbo].[menu_category] ([id], [name]) VALUES (1, N'Food')
INSERT [dbo].[menu_category] ([id], [name]) VALUES (2, N'Others')
INSERT [dbo].[menu_category] ([id], [name]) VALUES (3, N'Drinks')
INSERT [dbo].[menu_category] ([id], [name]) VALUES (4, N'Hot')
INSERT [dbo].[menu_category] ([id], [name]) VALUES (6, N'Snack')
INSERT [dbo].[menu_category] ([id], [name]) VALUES (7, N'Disert')
SET IDENTITY_INSERT [dbo].[menu_category] OFF
INSERT [dbo].[payment] ([id], [header_order_id], [promotion_id], [payment_type], [amount_to_pay], [amount_paid]) VALUES (N'1', N'1', N'NULL', N'Cash', N'80500', N'100000')
INSERT [dbo].[payment] ([id], [header_order_id], [promotion_id], [payment_type], [amount_to_pay], [amount_paid]) VALUES (N'2', N'2', N'2', N'Credit', N'182447,5', N'182447,5')
INSERT [dbo].[payment] ([id], [header_order_id], [promotion_id], [payment_type], [amount_to_pay], [amount_paid]) VALUES (N'3', N'4', N'1', N'Cash', N'142600', N'150000')
SET IDENTITY_INSERT [dbo].[promotion] ON 

INSERT [dbo].[promotion] ([id], [code], [discount], [minimum_spent], [star_time], [end_time]) VALUES (1, N'HEMATAJA', CAST(10.00 AS Decimal(5, 2)), CAST(2000.00 AS Decimal(10, 2)), CAST(N'2019-10-28T00:00:00.000' AS DateTime), CAST(N'2019-10-28T00:00:00.000' AS DateTime))
INSERT [dbo].[promotion] ([id], [code], [discount], [minimum_spent], [star_time], [end_time]) VALUES (2, N'HematBgt', CAST(10.00 AS Decimal(5, 2)), CAST(50000.00 AS Decimal(10, 2)), CAST(N'2019-10-28T00:00:00.000' AS DateTime), CAST(N'2019-10-25T00:00:00.000' AS DateTime))
INSERT [dbo].[promotion] ([id], [code], [discount], [minimum_spent], [star_time], [end_time]) VALUES (3, N'HematSkli', CAST(8.00 AS Decimal(5, 2)), CAST(100000.00 AS Decimal(10, 2)), CAST(N'2019-10-28T00:00:00.000' AS DateTime), CAST(N'2019-10-29T00:00:00.000' AS DateTime))
INSERT [dbo].[promotion] ([id], [code], [discount], [minimum_spent], [star_time], [end_time]) VALUES (4, N'HematLGi', CAST(2.00 AS Decimal(5, 2)), CAST(900000.00 AS Decimal(10, 2)), CAST(N'2019-10-28T00:00:00.000' AS DateTime), CAST(N'2019-10-24T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[promotion] OFF
ALTER TABLE [dbo].[detail_order]  WITH CHECK ADD  CONSTRAINT [FK_detail_order_header_order] FOREIGN KEY([header_order_id])
REFERENCES [dbo].[header_order] ([id])
GO
ALTER TABLE [dbo].[detail_order] CHECK CONSTRAINT [FK_detail_order_header_order]
GO
ALTER TABLE [dbo].[detail_order]  WITH CHECK ADD  CONSTRAINT [FK_detail_order_menu] FOREIGN KEY([menu_id])
REFERENCES [dbo].[menu] ([id])
GO
ALTER TABLE [dbo].[detail_order] CHECK CONSTRAINT [FK_detail_order_menu]
GO
ALTER TABLE [dbo].[menu]  WITH CHECK ADD  CONSTRAINT [FK_menu_menu_category] FOREIGN KEY([menu_category_id])
REFERENCES [dbo].[menu_category] ([id])
GO
ALTER TABLE [dbo].[menu] CHECK CONSTRAINT [FK_menu_menu_category]
GO
USE [master]
GO
ALTER DATABASE [DB_PC_26_Module1] SET  READ_WRITE 
GO
