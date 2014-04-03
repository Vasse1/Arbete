USE [VacationDB]
GO

/****** Object:  Table [dbo].[Landlord]    Script Date: 12/16/2013 15:10:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Landlord](
	[landlordID] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[personNr] [int] NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[orgNr] [int] NULL,
	[accountNr] [nvarchar](50) NOT NULL,
	[zipCode] [int] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[telephoneNr] [int] NOT NULL,
	[website] [nvarchar](50) NULL,
 CONSTRAINT [PK_Landlord] PRIMARY KEY CLUSTERED 
(
	[landlordID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

