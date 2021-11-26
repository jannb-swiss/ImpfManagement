USE [ImpfManagement]
GO

/****** Object:  Table [dbo].[Abteilung]    Script Date: 09.10.2020 10:01:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Vaccination](
	[VaccinationId] [int] IDENTITY(1,1) NOT NULL,
	[Vaccine] [varchar](50) NULL,
 CONSTRAINT [PK_Vaccination] PRIMARY KEY CLUSTERED 
(
	[VaccinationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[SecondName] [varchar](50) NULL,
	[Age] [int] NULL,
	[Street] [varchar](50) NULL,
	[Plz] [varchar](20) NULL,
	[Place] [varchar](50) NULL,
	[NumVaccinations] [int] NULL,
	[VaccinationId] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Vaccination] FOREIGN KEY([VaccinationId])
REFERENCES [dbo].[Vaccination] ([VaccinationId])
GO

ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Vaccination]
GO
