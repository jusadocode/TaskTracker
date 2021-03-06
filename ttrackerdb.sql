USE [master]
GO
/****** Object:  Database [TaskTracker]    Script Date: 2021-08-24 18:07:44 ******/
CREATE DATABASE [TaskTracker]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TaskTracker', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TaskTracker.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TaskTracker_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TaskTracker_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TaskTracker] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TaskTracker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TaskTracker] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TaskTracker] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TaskTracker] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TaskTracker] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TaskTracker] SET ARITHABORT OFF 
GO
ALTER DATABASE [TaskTracker] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TaskTracker] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TaskTracker] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TaskTracker] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TaskTracker] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TaskTracker] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TaskTracker] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TaskTracker] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TaskTracker] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TaskTracker] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TaskTracker] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TaskTracker] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TaskTracker] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TaskTracker] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TaskTracker] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TaskTracker] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TaskTracker] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TaskTracker] SET RECOVERY FULL 
GO
ALTER DATABASE [TaskTracker] SET  MULTI_USER 
GO
ALTER DATABASE [TaskTracker] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TaskTracker] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TaskTracker] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TaskTracker] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TaskTracker] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TaskTracker] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TaskTracker', N'ON'
GO
ALTER DATABASE [TaskTracker] SET QUERY_STORE = OFF
GO
USE [TaskTracker]
GO
/****** Object:  Table [dbo].[ProjectModel]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectModel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskModel]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskModel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[StartingDate] [datetime] NOT NULL,
	[Deadline] [datetime] NOT NULL,
	[FinishTime] [datetime] NULL,
	[Difficulty] [varchar](50) NOT NULL,
	[Priority] [varchar](50) NOT NULL,
	[Active] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Get_Projects_All]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Get_Projects_All]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	from dbo.ProjectModel
END
GO
/****** Object:  StoredProcedure [dbo].[Project_Insert]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Project_Insert]
	@Id int = 0 output,
	@name nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into dbo.ProjectModel(Title)
	values(@name);
	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[Task_Complete]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Task_Complete]
	@id int,
	@finishTime datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update dbo.TaskModel
	set FinishTime = @finishTime,
	Active = 0
	where ID = @id

END
GO
/****** Object:  StoredProcedure [dbo].[Task_Delete]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Task_Delete]
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update dbo.TaskModel
	set Active = NULL
	where ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Task_End]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Task_End]
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update dbo.TaskModel
	set Active = 0
	where ID = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Task_Insert]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Task_Insert] 
	@Id int = 0 output,
	@ProjectId int,
	@title nvarchar(50),
	@startDate datetime,
	@deadline datetime,
	@difficulty varchar(50),
	@priority varchar(50)


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into dbo.TaskModel(ProjectID, Title, StartingDate, Deadline, FinishTime, Difficulty, Priority, Active)
	values(@ProjectId, @title, @startDate, @deadline, null, @difficulty, @priority, 1);
	select @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[Task_Update]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Task_Update]
	@id int,
	@projectID int,
	@title nvarchar(50),
	@deadline datetime,
	@difficulty nvarchar(50),
	@priority nvarchar(50)


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update dbo.TaskModel
	set Title = @title, Deadline = @deadline, Difficulty = @difficulty, Priority = @priority
	where ID = @id and ProjectID = @projectID

END
GO
/****** Object:  StoredProcedure [dbo].[Tasks_Get_ByActivity]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Tasks_Get_ByActivity]
	@projectID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * 
	from dbo.TaskModel
	where ProjectID = @projectID and Active = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Tasks_GetByProjectID]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Tasks_GetByProjectID] 
	@projectID int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	SELECT *
	from dbo.TaskModel
	where ProjectID = @projectID and Active = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Tasks_Update_Priorities]    Script Date: 2021-08-24 18:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Tasks_Update_Priorities]
	@projectID int,
	@id int,
	@priority nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update dbo.TaskModel
	set Priority = @priority
	where ProjectID = @projectID and @id = ID
	
	
END
GO
USE [master]
GO
ALTER DATABASE [TaskTracker] SET  READ_WRITE 
GO
