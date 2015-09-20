USE [rpi_mini_weather]
GO

/****** Object:  Table [dbo].[Reading]    Script Date: 9/20/2015 1:33:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reading](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TempSensor1] [real] NOT NULL,
	[TempSensor2] [real] NOT NULL,
	[TempSensor3] [real] NOT NULL,
	[TempSensorAvg] [real] NOT NULL,
	[Humidity] [real] NOT NULL,
	[Pressure] [real] NOT NULL,
	[Altitude] [real] NOT NULL,
	[SeaLevelPressure] [real] NOT NULL,
	[Lux] [real] NOT NULL,
	[TimeStamp] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Reading] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
