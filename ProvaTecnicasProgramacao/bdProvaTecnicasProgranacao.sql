USE [master]
GO

/****** Object:  Database [bdProvaTecnicasProgranacao]    Script Date: 09/23/2013 13:14:44 ******/
CREATE DATABASE [bdProvaTecnicasProgranacao] ON  PRIMARY 
( NAME = N'bdProva', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\bdProva.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'bdProva_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\bdProva_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

USE [bdProvaTecnicasProgranacao]
GO

/****** Object:  Table [dbo].[tblCatalogo]    Script Date: 09/23/2013 13:14:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCatalogo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](50) NULL,
	[Modelo] [nvarchar](50) NULL,
	[Velocidade] [int] NULL,
	[Cavalos] [int] NULL,
	[RPM] [int] NULL,
	[Cilindradas] [int] NULL,
	[Peso] [int] NULL,
 CONSTRAINT [PK_tblCatalogo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [bdProvaTecnicasProgranacao].[dbo].[tblCatalogo]([Marca],[Modelo],[Velocidade],[Cavalos],[RPM],[Cilindradas],[Peso])
     VALUES('Yamaha','XS 1100',224,95,8500,1101,222)
GO
INSERT INTO [bdProvaTecnicasProgranacao].[dbo].[tblCatalogo]([Marca],[Modelo],[Velocidade],[Cavalos],[RPM],[Cilindradas],[Peso])
     VALUES('Suzuki','GS 1000',222,90,8200,997,255)
GO
INSERT INTO [bdProvaTecnicasProgranacao].[dbo].[tblCatalogo]([Marca],[Modelo],[Velocidade],[Cavalos],[RPM],[Cilindradas],[Peso])
     VALUES('Honda','CBX 1000',220,105,9000,1046,272)
GO
INSERT INTO [bdProvaTecnicasProgranacao].[dbo].[tblCatalogo]([Marca],[Modelo],[Velocidade],[Cavalos],[RPM],[Cilindradas],[Peso])
     VALUES('Suzuki','GS 750',198,63,8800,748,253)
GO
INSERT INTO [bdProvaTecnicasProgranacao].[dbo].[tblCatalogo]([Marca],[Modelo],[Velocidade],[Cavalos],[RPM],[Cilindradas],[Peso])
     VALUES('Honda','CB 750F',197,73,9000,736,253)
GO
INSERT INTO [bdProvaTecnicasProgranacao].[dbo].[tblCatalogo]([Marca],[Modelo],[Velocidade],[Cavalos],[RPM],[Cilindradas],[Peso])
     VALUES('Kawasaki','Z 650',190,66,8500,652,220)
GO