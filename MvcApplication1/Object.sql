USE [VacationDB]
GO

/****** Object:  Table [dbo].[Object]    Script Date: 12/16/2013 15:10:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Object](
	[objectID] [int] NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[sizeSqm] [int] NOT NULL,
	[price] [int] NOT NULL,
	[available] [bit] NOT NULL,
	[timeSpan] [datetime] NOT NULL,
	[beds] [int] NOT NULL,
	[numberOfRooms] [int] NOT NULL,
 CONSTRAINT [PK_Object] PRIMARY KEY CLUSTERED 
(
	[objectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

