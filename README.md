# EFIssue

The SQL Script the DB is (I haven't enabled the migrations on these projects yet):



```
CREATE DATABASE [EF6Context]
GO

USE [EF6Context]
GO
/****** Object:  Table [dbo].[Asset]    Script Date: 16/11/2021 23:09:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asset](
	[AssetId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Asset] PRIMARY KEY CLUSTERED 
(
	[AssetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonitoringLog]    Script Date: 16/11/2021 23:09:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonitoringLog](
	[MonitoringLogId] [int] IDENTITY(1,1) NOT NULL,
	[LogUTCDateTime] [datetime] NOT NULL,
	[OtherProperty] [nvarchar](50) NULL,
	[AssetId] [int] NOT NULL,
 CONSTRAINT [PK_MonitoringLog] PRIMARY KEY CLUSTERED 
(
	[MonitoringLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MonitoringLog]  WITH CHECK ADD  CONSTRAINT [FK_MonitoringLog_Asset] FOREIGN KEY([AssetId])
REFERENCES [dbo].[Asset] ([AssetId])
GO
ALTER TABLE [dbo].[MonitoringLog] CHECK CONSTRAINT [FK_MonitoringLog_Asset]
GO

```


## Insert some test data:

SET IDENTITY_INSERT Asset ON;
INSERT INTO Asset	(AssetId)
	VALUES (1), (2)

GO
SET IDENTITY_INSERT Asset ON;


