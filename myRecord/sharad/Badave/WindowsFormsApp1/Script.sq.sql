USE [master]
GO
/****** Object:  Database [E-Server-File-Transfer]    Script Date: 4/6/2024 1:47:51 PM ******/
CREATE DATABASE [E-Server-File-Transfer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'E-Server-File-Transfer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\E-Server-File-Transfer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'E-Server-File-Transfer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\E-Server-File-Transfer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [E-Server-File-Transfer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [E-Server-File-Transfer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET ARITHABORT OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [E-Server-File-Transfer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [E-Server-File-Transfer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [E-Server-File-Transfer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [E-Server-File-Transfer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [E-Server-File-Transfer] SET  MULTI_USER 
GO
ALTER DATABASE [E-Server-File-Transfer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [E-Server-File-Transfer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [E-Server-File-Transfer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [E-Server-File-Transfer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [E-Server-File-Transfer]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/6/2024 1:47:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[city] [varchar](50) NULL,
	[admin] [bit] NULL,
	[dateOfBirth] [datetime] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_FileData]    Script Date: 4/6/2024 1:47:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_FileData](
	[FileNumber] [bigint] IDENTITY(1,1) NOT NULL,
	[SourceFilePath] [varchar](150) NULL,
	[DestinationFilePath] [varchar](150) NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Table_FileData] PRIMARY KEY CLUSTERED 
(
	[FileNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id], [name], [address], [gender], [city], [admin], [dateOfBirth]) VALUES (1, N'sharad', N'washim', N'Male', N'Pune', 1, CAST(N'2024-04-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Category] ([id], [name], [address], [gender], [city], [admin], [dateOfBirth]) VALUES (2, N'Pawan', N'Malegoan', N'Male', N'Mumbaii', 0, CAST(N'2091-07-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Category] ([id], [name], [address], [gender], [city], [admin], [dateOfBirth]) VALUES (3, N'Megha Kute', N'Malegoan', N'Female', N'Mumbaii', 1, CAST(N'1995-07-06T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_FileData] ON 

INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (1, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file.txt', CAST(N'2024-04-05T17:00:32.817' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (2, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file2.txt', CAST(N'2024-04-05T17:00:40.453' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (3, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file3.txt', CAST(N'2024-04-05T17:00:46.253' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (4, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file.txt', CAST(N'2024-04-05T17:01:19.573' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (5, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file2.txt', CAST(N'2024-04-05T17:01:29.530' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (6, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file3.txt', CAST(N'2024-04-05T17:01:35.453' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (7, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file.txt', CAST(N'2024-04-05T17:09:30.670' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (8, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file2.txt', CAST(N'2024-04-05T17:10:22.127' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (9, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file3.txt', CAST(N'2024-04-05T17:10:28.053' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (10, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file.txt', CAST(N'2024-04-05T17:19:20.430' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (11, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file2.txt', CAST(N'2024-04-05T17:19:23.977' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (12, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file3.txt', CAST(N'2024-04-05T17:19:27.157' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (13, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file.txt', CAST(N'2024-04-05T17:20:17.573' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (14, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file2.txt', CAST(N'2024-04-05T17:20:20.877' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (15, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file3.txt', CAST(N'2024-04-05T17:20:26.157' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (16, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file.txt', CAST(N'2024-04-05T17:30:52.890' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (17, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file2.txt', CAST(N'2024-04-05T17:30:56.240' AS DateTime))
INSERT [dbo].[Table_FileData] ([FileNumber], [SourceFilePath], [DestinationFilePath], [CreateDate]) VALUES (18, N'C:\New folder', N'\\DESKTOP-BHDBMC2\SharadKute\\file3.txt', CAST(N'2024-04-05T17:30:59.753' AS DateTime))
SET IDENTITY_INSERT [dbo].[Table_FileData] OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_FileSystem]    Script Date: 4/6/2024 1:47:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE  [dbo].[SP_FileSystem]
(
	@FileNumber as bigint = 0,
	@SourceFilePath as varchar(300)='',
	@DestinationFilePath as varchar(300)='',
  
	@Action as varchar(100)
)
AS
BEGIN
    -- Insert statements for procedure here
	if @Action='Insert'    
	Begin    
	Insert into Table_FileData(SourceFilePath,DestinationFilePath,CreateDate)
	values(@SourceFilePath,@DestinationFilePath,CURRENT_TIMESTAMP);   
	End    	
	

END

GO
USE [master]
GO
ALTER DATABASE [E-Server-File-Transfer] SET  READ_WRITE 
GO
