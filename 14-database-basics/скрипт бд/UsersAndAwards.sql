USE [master]
GO
/****** Object:  Database [UsersAndAwards]    Script Date: 19.05.2022 2:44:41 ******/
CREATE DATABASE [UsersAndAwards]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UsersAndAwards', FILENAME = N'E:\program\sql server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UsersAndAwards.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UsersAndAwards_log', FILENAME = N'E:\program\sql server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UsersAndAwards_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UsersAndAwards] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UsersAndAwards].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UsersAndAwards] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ARITHABORT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UsersAndAwards] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UsersAndAwards] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UsersAndAwards] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UsersAndAwards] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UsersAndAwards] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UsersAndAwards] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UsersAndAwards] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UsersAndAwards] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UsersAndAwards] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UsersAndAwards] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UsersAndAwards] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UsersAndAwards] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UsersAndAwards] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UsersAndAwards] SET  MULTI_USER 
GO
ALTER DATABASE [UsersAndAwards] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UsersAndAwards] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UsersAndAwards] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UsersAndAwards] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UsersAndAwards] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UsersAndAwards] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [UsersAndAwards] SET QUERY_STORE = OFF
GO
USE [UsersAndAwards]
GO
/****** Object:  Table [dbo].[Award]    Script Date: 19.05.2022 2:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Award](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](350) NOT NULL,
 CONSTRAINT [PK_Award] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConnectionUserAndAward]    Script Date: 19.05.2022 2:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConnectionUserAndAward](
	[UserId] [int] NOT NULL,
	[AwardId] [int] NOT NULL,
 CONSTRAINT [PK_ConnectionUserAndAward_1] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[AwardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 19.05.2022 2:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Birthdate] [date] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Award] ([Id], [Title], [Description]) VALUES (1, N'Диплом', N'за кативность')
INSERT [dbo].[Award] ([Id], [Title], [Description]) VALUES (2, N'Грамота', N'за успехи в работе')
INSERT [dbo].[Award] ([Id], [Title], [Description]) VALUES (3, N'Награда', N'за настроение')
GO
INSERT [dbo].[ConnectionUserAndAward] ([UserId], [AwardId]) VALUES (1, 2)
INSERT [dbo].[ConnectionUserAndAward] ([UserId], [AwardId]) VALUES (2, 1)
INSERT [dbo].[ConnectionUserAndAward] ([UserId], [AwardId]) VALUES (2, 2)
INSERT [dbo].[ConnectionUserAndAward] ([UserId], [AwardId]) VALUES (3, 2)
INSERT [dbo].[ConnectionUserAndAward] ([UserId], [AwardId]) VALUES (3, 3)
GO
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Birthdate]) VALUES (1, N'Oleg', N'Nikitov', CAST(N'2002-04-20' AS Date))
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Birthdate]) VALUES (2, N'Aleksey', N'Mahnev', CAST(N'1998-06-12' AS Date))
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Birthdate]) VALUES (3, N'Екатерина', N'Николаева', CAST(N'2005-05-09' AS Date))
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Birthdate]) VALUES (4, N'Фёдор1', N'Шуваев1', CAST(N'2005-05-09' AS Date))
GO
ALTER TABLE [dbo].[ConnectionUserAndAward]  WITH CHECK ADD  CONSTRAINT [FK_ConnectionUserAndAward_Award] FOREIGN KEY([AwardId])
REFERENCES [dbo].[Award] ([Id])
GO
ALTER TABLE [dbo].[ConnectionUserAndAward] CHECK CONSTRAINT [FK_ConnectionUserAndAward_Award]
GO
ALTER TABLE [dbo].[ConnectionUserAndAward]  WITH CHECK ADD  CONSTRAINT [FK_ConnectionUserAndAward_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ConnectionUserAndAward] CHECK CONSTRAINT [FK_ConnectionUserAndAward_Users]
GO
/****** Object:  StoredProcedure [dbo].[AddAward]    Script Date: 19.05.2022 2:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddAward]
(
  @AwardId INT,
  @Title NVARCHAR(150),
  @Description NVARCHAR(350)
)
AS
BEGIN
	INSERT INTO Award(Id, Title, Description)
		VALUES ((Select MAX(id) + 1 From Award), @Title, @Description)
END
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 19.05.2022 2:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddUser]
(
  @FirstName NVARCHAR(50),
  @LastName NVARCHAR(50),
  @Bithdate DATE
)
AS
BEGIN
	INSERT INTO Users(Id, FirstName, LastName, Birthdate)
		VALUES ((Select MAX(id) + 1 From Users), @FirstName, @LastName, @Bithdate)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteAward]    Script Date: 19.05.2022 2:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteAward]
(
  @AwardId INT
)
AS
BEGIN

	--удаление записи из смежной таблицы
	DELETE FROM ConnectionUserAndAward
	Where AwardId = @AwardId
	--ON DELETE CASCADE

	--удаление записи из наград
	DELETE FROM Award
	Where Id = @AwardId

	--обновление id в наградах
	UPDATE Award
	SET Id = Id - 1
	WHERE Id > @AwardId

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 19.05.2022 2:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteUser]
(
  @UserId INT
)
AS
BEGIN
	DELETE FROM Users 
	Where Id = @UserId

	UPDATE Users
	SET Id = Id - 1
	WHERE Id > @UserId
END
GO
/****** Object:  StoredProcedure [dbo].[EditAward]    Script Date: 19.05.2022 2:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditAward]
(
  @AwardId INT,
  @Title NVARCHAR(150),
  @Description NVARCHAR(350)
)
AS
BEGIN
	UPDATE Award
		SET Title = @Title,
			Description = @Description
		WHERE Id = @AwardId
END
GO
/****** Object:  StoredProcedure [dbo].[EditUser]    Script Date: 19.05.2022 2:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditUser]
(
  @UserId INT,
  @FirstName NVARCHAR(50),
  @LastName NVARCHAR(50),
  @Bithdate DATE
)
AS
BEGIN
	UPDATE Users
		SET FirstName = @FirstName,
			LastName = @LastName,
			Birthdate = @Bithdate
		WHERE Id = @UserId
END
GO
/****** Object:  StoredProcedure [dbo].[GettingAllRewards]    Script Date: 19.05.2022 2:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GettingAllRewards]
  @UserId Int
AS
BEGIN
Select Title
From Award
Where Award.Id in
 (Select AwardId
  From Users Join ConnectionUserAndAward
  On Users.Id = ConnectionUserAndAward.UserId
  Where Users.Id = @UserId)
END
GO
USE [master]
GO
ALTER DATABASE [UsersAndAwards] SET  READ_WRITE 
GO
