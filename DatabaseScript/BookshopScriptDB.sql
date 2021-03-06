USE [master]
GO
/****** Object:  Database [BOOKSHOP]    Script Date: 13.07.2022 20:27:27 ******/
CREATE DATABASE [BOOKSHOP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ksiegarnia', FILENAME = N'D:\Bazy sql\MSSQL15.SQLEXPRESS\MSSQL\DATA\ksiegarnia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ksiegarnia_log', FILENAME = N'D:\Bazy sql\MSSQL15.SQLEXPRESS\MSSQL\DATA\ksiegarnia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BOOKSHOP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BOOKSHOP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BOOKSHOP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ARITHABORT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BOOKSHOP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BOOKSHOP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BOOKSHOP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BOOKSHOP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BOOKSHOP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BOOKSHOP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BOOKSHOP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BOOKSHOP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BOOKSHOP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BOOKSHOP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BOOKSHOP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BOOKSHOP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BOOKSHOP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BOOKSHOP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BOOKSHOP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BOOKSHOP] SET  MULTI_USER 
GO
ALTER DATABASE [BOOKSHOP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BOOKSHOP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BOOKSHOP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BOOKSHOP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BOOKSHOP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BOOKSHOP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BOOKSHOP] SET QUERY_STORE = OFF
GO
USE [BOOKSHOP]
GO
/****** Object:  Table [dbo].[books]    Script Date: 13.07.2022 20:27:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[bookID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NOT NULL,
	[author] [varchar](200) NOT NULL,
	[status] [nchar](11) NULL,
 CONSTRAINT [PK_books] PRIMARY KEY CLUSTERED 
(
	[bookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[posts]    Script Date: 13.07.2022 20:27:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posts](
	[postID] [int] IDENTITY(1,1) NOT NULL,
	[dataPublished] [smalldatetime] NOT NULL,
	[title] [varchar](300) NOT NULL,
	[body] [varchar](6000) NOT NULL,
 CONSTRAINT [PK_posts] PRIMARY KEY CLUSTERED 
(
	[postID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 13.07.2022 20:27:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[role] [varchar](20) NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wishlist]    Script Date: 13.07.2022 20:27:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wishlist](
	[wishID] [int] IDENTITY(1,1) NOT NULL,
	[IDuser] [int] NOT NULL,
	[IDbook] [int] NOT NULL,
 CONSTRAINT [PK_wishlist] PRIMARY KEY CLUSTERED 
(
	[wishID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[books] ON 

INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (1, N'Nineteen Eighty-Four', N'George Orwell', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (2, N'Don Quixote', N'Miguel de Cervantes
', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (3, N'The Adventures of Sherlock Holmes', N'Arthur Conan Doyle
', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (4, N'Adventures of Huckleberry Finn', N'Mark Twain', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (5, N'Animal Farm', N'George Orwell
', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (6, N'Alice''s Adventures in Wonderland', N'Lewis Carroll
', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (7, N'The Brothers Karamazov', N'Fyodor Dostoevsky', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (8, N'The Aeneid ', N'Virgil', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (9, N'Catch-22', N'Joseph Heller ', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (10, N'1984', N'George Orwell', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (11, N'Moby-Dick', N'Herman Melville', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (12, N'Moby-Dick', N'Herman Melville', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (13, N'Moby-Dick', N'Herman Melville', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (14, N'Animal Farm', N'George Orwell', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (15, N'Invisible Man', N'Ralph Ellison', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (16, N'The Count of Monte Cristo', N'Alexandre Dumas', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (17, N'David Copperfield', N'Charles Dickens', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (18, N'The Call of the Wild', N'Jack London', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (19, N'The Call of the Wild', N'Jack London', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (20, N'Housekeeping', N'Marilynne Robinson', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (21, N'His Dark Materials', N'Philip Pullman', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (22, N'Brideshead Revisited', N'Evelyn Waugh', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (23, N'White Noise', N'Don DeLillo', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (24, N'White Noise', N'Don DeLillo', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (25, N'White Noise', N'Don DeLillo', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (26, N'White Noise', N'Don DeLillo', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (27, N'Wide Sargasso Sea', N'Jean Rhys', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (28, N'The Portrait of a Lady', N'Henry James', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (29, N'The Portrait of a Lady', N'Henry James', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (30, N'The Trial', N'Franz Kafka', N'available  ')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (31, N'The Trial', N'Franz Kafka', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (32, N'The Trial', N'Franz Kafka', N'unavailable')
INSERT [dbo].[books] ([bookID], [name], [author], [status]) VALUES (1017, N'1984', N'George Orwell', N'available  ')
SET IDENTITY_INSERT [dbo].[books] OFF
GO
SET IDENTITY_INSERT [dbo].[posts] ON 

INSERT [dbo].[posts] ([postID], [dataPublished], [title], [body]) VALUES (1, CAST(N'2022-07-07T00:00:00' AS SmallDateTime), N'Closed bookshop.', N'On 14.07 the bookstore will be closed')
INSERT [dbo].[posts] ([postID], [dataPublished], [title], [body]) VALUES (2, CAST(N'2022-07-15T00:00:00' AS SmallDateTime), N'
Meeting with the author.', N'On 02.08 Mark Twain is visiting our bookshop. You can come and get autographs between 4 P.M. and 8 P.M.')
INSERT [dbo].[posts] ([postID], [dataPublished], [title], [body]) VALUES (6, CAST(N'2022-07-12T18:09:00' AS SmallDateTime), N'Does it work?', N'I hope it works.')
SET IDENTITY_INSERT [dbo].[posts] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([userID], [username], [password], [role]) VALUES (0, N'maniek', N'123', N'Client')
INSERT [dbo].[users] ([userID], [username], [password], [role]) VALUES (1, N'admin', N'admin', N'admin')
INSERT [dbo].[users] ([userID], [username], [password], [role]) VALUES (2, N'marek', N'zegarek', N'Client')
INSERT [dbo].[users] ([userID], [username], [password], [role]) VALUES (3, N'andrzej', N'dragan', N'Client')
INSERT [dbo].[users] ([userID], [username], [password], [role]) VALUES (4, N'eryk', N'eryk123', N'Client')
INSERT [dbo].[users] ([userID], [username], [password], [role]) VALUES (5, N'jack', N'harlow', N'Client')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
SET IDENTITY_INSERT [dbo].[wishlist] ON 

INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1, 2, 24)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (2, 2, 31)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1002, 2, 25)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1003, 2, 12)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1004, 3, 24)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1005, 4, 31)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1006, 5, 18)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1007, 5, 19)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1008, 5, 2)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1009, 5, 3)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1010, 5, 1)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1011, 5, 8)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1012, 2, 5)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1013, 2, 6)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1014, 2, 11)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1015, 5, 10)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1016, 5, 9)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1017, 2, 4)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1018, 2, 32)
INSERT [dbo].[wishlist] ([wishID], [IDuser], [IDbook]) VALUES (1019, 2, 28)
SET IDENTITY_INSERT [dbo].[wishlist] OFF
GO
ALTER TABLE [dbo].[wishlist]  WITH CHECK ADD  CONSTRAINT [FK_wishlist_books] FOREIGN KEY([IDbook])
REFERENCES [dbo].[books] ([bookID])
GO
ALTER TABLE [dbo].[wishlist] CHECK CONSTRAINT [FK_wishlist_books]
GO
ALTER TABLE [dbo].[wishlist]  WITH CHECK ADD  CONSTRAINT [FK_wishlist_users] FOREIGN KEY([IDuser])
REFERENCES [dbo].[users] ([userID])
GO
ALTER TABLE [dbo].[wishlist] CHECK CONSTRAINT [FK_wishlist_users]
GO
USE [master]
GO
ALTER DATABASE [BOOKSHOP] SET  READ_WRITE 
GO
