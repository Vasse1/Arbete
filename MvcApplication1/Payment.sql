USE [VacationDB]
GO

/****** Object:  Table [dbo].[Payment]    Script Date: 12/16/2013 15:10:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Payment](
	[paymentID] [int] NOT NULL,
	[paymentType] [nvarchar](50) NOT NULL,
	[priceTotal] [float] NOT NULL,
	[rentalID] [int] NOT NULL,
	[deposit] [float] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[paymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

