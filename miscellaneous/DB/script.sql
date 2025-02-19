USE [master]
GO
/****** Object:  Database [ChowdhuryFillingStation]    Script Date: 24-Jan-25 9:16:45 PM ******/
CREATE DATABASE [ChowdhuryFillingStation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ChowdhuryFillingStation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ChowdhuryFillingStation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ChowdhuryFillingStation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ChowdhuryFillingStation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ChowdhuryFillingStation] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChowdhuryFillingStation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChowdhuryFillingStation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET ARITHABORT OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET  MULTI_USER 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ChowdhuryFillingStation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ChowdhuryFillingStation] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ChowdhuryFillingStation] SET QUERY_STORE = ON
GO
ALTER DATABASE [ChowdhuryFillingStation] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ChowdhuryFillingStation]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 24-Jan-25 9:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseId] [varchar](10) NOT NULL,
	[Amount] [float] NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[CreatedBy] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Expense] PRIMARY KEY CLUSTERED 
(
	[ExpenseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventories]    Script Date: 24-Jan-25 9:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventories](
	[InventoryId] [varchar](10) NOT NULL,
	[FuelName] [varchar](20) NOT NULL,
	[StockQuantity] [float] NOT NULL,
	[PricePerLitre] [float] NOT NULL,
 CONSTRAINT [PK_Inventories] PRIMARY KEY CLUSTERED 
(
	[InventoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 24-Jan-25 9:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetails](
	[SaleDetailId] [varchar](10) NOT NULL,
	[SaleId] [varchar](10) NOT NULL,
	[InventoryId] [varchar](10) NOT NULL,
	[PricePerLitre] [float] NOT NULL,
	[Quantity] [float] NOT NULL,
	[Total] [nchar](10) NOT NULL,
 CONSTRAINT [PK_SaleDetails] PRIMARY KEY CLUSTERED 
(
	[SaleDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 24-Jan-25 9:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleId] [varchar](10) NOT NULL,
	[SaleDateTime] [datetime] NOT NULL,
	[CreatedBy] [varchar](10) NOT NULL,
	[GrandTotal] [float] NOT NULL,
	[GivenAmount] [float] NOT NULL,
	[Change] [float] NOT NULL,
	[PaymentMethod] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24-Jan-25 9:16:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [varchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Phone] [varchar](15) NOT NULL,
	[Password] [varchar](32) NOT NULL,
	[Role] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Expenses] ([ExpenseId], [Amount], [Category], [DateTime], [Description], [CreatedBy]) VALUES (N'EXP-001', 5000, N'Maintenance', CAST(N'2025-01-20T10:00:00.000' AS DateTime), N'Pump maintenance', N'USER-001')
INSERT [dbo].[Expenses] ([ExpenseId], [Amount], [Category], [DateTime], [Description], [CreatedBy]) VALUES (N'EXP-002', 2000, N'Utilities', CAST(N'2025-01-21T15:30:00.000' AS DateTime), N'Electricity bill', N'USER-003')
INSERT [dbo].[Expenses] ([ExpenseId], [Amount], [Category], [DateTime], [Description], [CreatedBy]) VALUES (N'EXP-003', 1500, N'Supplies', CAST(N'2025-01-22T09:00:00.000' AS DateTime), N'Office supplies', N'USER-002')
INSERT [dbo].[Expenses] ([ExpenseId], [Amount], [Category], [DateTime], [Description], [CreatedBy]) VALUES (N'EXP-004', 3000, N'Repair', CAST(N'2025-01-23T14:00:00.000' AS DateTime), N'Pipeline repair', N'USER-004')
INSERT [dbo].[Expenses] ([ExpenseId], [Amount], [Category], [DateTime], [Description], [CreatedBy]) VALUES (N'EXP-005', 4000, N'Fuel Purchase', CAST(N'2025-01-24T11:00:00.000' AS DateTime), N'Stock refill', N'USER-005')
GO
INSERT [dbo].[Inventories] ([InventoryId], [FuelName], [StockQuantity], [PricePerLitre]) VALUES (N'INV-001', N'Petrol', 1600, 120.5)
INSERT [dbo].[Inventories] ([InventoryId], [FuelName], [StockQuantity], [PricePerLitre]) VALUES (N'INV-002', N'Diesel', 800, 110.75)
INSERT [dbo].[Inventories] ([InventoryId], [FuelName], [StockQuantity], [PricePerLitre]) VALUES (N'INV-003', N'CNG', 500, 50.25)
INSERT [dbo].[Inventories] ([InventoryId], [FuelName], [StockQuantity], [PricePerLitre]) VALUES (N'INV-004', N'Octane', 700, 125)
INSERT [dbo].[Inventories] ([InventoryId], [FuelName], [StockQuantity], [PricePerLitre]) VALUES (N'INV-005', N'Kerosene', 600, 90)
GO
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-001', N'SALE-001', N'INV-001', 120.5, 10, N'1205.00   ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-002', N'SALE-001', N'INV-002', 110.75, 3, N'332.25    ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-003', N'SALE-002', N'INV-003', 50.25, 20, N'1005.00   ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-004', N'SALE-002', N'INV-004', 125, 12, N'1500.00   ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-005', N'SALE-002', N'INV-005', 90, 5, N'450.00    ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-006', N'SALE-003', N'INV-001', 120.5, 3, N'361.50    ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-007', N'SALE-003', N'INV-004', 125, 2, N'250.00    ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-008', N'SALE-004', N'INV-002', 110.75, 15, N'1661.25   ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-009', N'SALE-004', N'INV-003', 50.25, 25, N'1256.25   ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-010', N'SALE-004', N'INV-005', 90, 3, N'270.00    ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-011', N'SALE-005', N'INV-001', 120.5, 2, N'241.00    ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-012', N'SALE-005', N'INV-002', 110.75, 2, N'221.50    ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-013', N'SALE-005', N'INV-003', 50.25, 5, N'251.25    ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-014', N'SALE-005', N'INV-005', 90, 3, N'270.00    ')
INSERT [dbo].[SaleDetails] ([SaleDetailId], [SaleId], [InventoryId], [PricePerLitre], [Quantity], [Total]) VALUES (N'SD-015', N'SALE-001', N'INV-004', 125, 5, N'625.00    ')
GO
INSERT [dbo].[Sales] ([SaleId], [SaleDateTime], [CreatedBy], [GrandTotal], [GivenAmount], [Change], [PaymentMethod]) VALUES (N'SALE-001', CAST(N'2025-01-20T12:00:00.000' AS DateTime), N'USER-002', 1500.5, 2000, 499.5, N'Cash')
INSERT [dbo].[Sales] ([SaleId], [SaleDateTime], [CreatedBy], [GrandTotal], [GivenAmount], [Change], [PaymentMethod]) VALUES (N'SALE-002', CAST(N'2025-01-20T16:00:00.000' AS DateTime), N'USER-003', 2500.75, 3000, 499.25, N'Bkash')
INSERT [dbo].[Sales] ([SaleId], [SaleDateTime], [CreatedBy], [GrandTotal], [GivenAmount], [Change], [PaymentMethod]) VALUES (N'SALE-003', CAST(N'2025-01-21T10:30:00.000' AS DateTime), N'USER-005', 750, 1000, 250, N'Cash')
INSERT [dbo].[Sales] ([SaleId], [SaleDateTime], [CreatedBy], [GrandTotal], [GivenAmount], [Change], [PaymentMethod]) VALUES (N'SALE-004', CAST(N'2025-01-22T18:00:00.000' AS DateTime), N'USER-002', 3250.25, 3500, 249.75, N'Bkash')
INSERT [dbo].[Sales] ([SaleId], [SaleDateTime], [CreatedBy], [GrandTotal], [GivenAmount], [Change], [PaymentMethod]) VALUES (N'SALE-005', CAST(N'2025-01-23T08:45:00.000' AS DateTime), N'USER-004', 500.5, 1000, 499.5, N'Cash')
GO
INSERT [dbo].[Users] ([UserId], [Name], [Phone], [Password], [Role]) VALUES (N'USER-001', N'Faysal Ahammed Chowdhury', N'admin', N'admin', N'Admin')
INSERT [dbo].[Users] ([UserId], [Name], [Phone], [Password], [Role]) VALUES (N'USER-002', N'Alam Pranto', N'emp', N'emp', N'Employee')
INSERT [dbo].[Users] ([UserId], [Name], [Phone], [Password], [Role]) VALUES (N'USER-003', N'Asef Abdullah', N'01733333333', N'password789', N'Employee')
INSERT [dbo].[Users] ([UserId], [Name], [Phone], [Password], [Role]) VALUES (N'USER-004', N'Imran Ziad', N'01744444444', N'password012', N'Admin')
INSERT [dbo].[Users] ([UserId], [Name], [Phone], [Password], [Role]) VALUES (N'USER-005', N'Mujahid Swadhin', N'01755555555', N'password345', N'Employee')
INSERT [dbo].[Users] ([UserId], [Name], [Phone], [Password], [Role]) VALUES (N'USER-006', N'Israfil Diganta', N'01766666666', N'password678', N'Employee')
INSERT [dbo].[Users] ([UserId], [Name], [Phone], [Password], [Role]) VALUES (N'USER-007', N'Rawaha Anik', N'01777777777', N'password901', N'Employee')
INSERT [dbo].[Users] ([UserId], [Name], [Phone], [Password], [Role]) VALUES (N'USER-008', N'Faisal Amin ABir', N'01788888888', N'password234', N'Employee')
INSERT [dbo].[Users] ([UserId], [Name], [Phone], [Password], [Role]) VALUES (N'USER-009', N'Sayed Mamun', N'01799999999', N'password567', N'Admin')
GO
USE [master]
GO
ALTER DATABASE [ChowdhuryFillingStation] SET  READ_WRITE 
GO
