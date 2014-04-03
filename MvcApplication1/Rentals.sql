USE [VacationDB]
GO

/****** Object:  Table [dbo].[Rentals]    Script Date: 12/16/2013 15:10:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rentals](
	[rentalID] [int] NOT NULL,
	[objectID] [int] NOT NULL,
	[customerID] [int] NOT NULL,
	[rentedDays] [int] NOT NULL,
	[isPaid] [bit] NOT NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[rentalID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

