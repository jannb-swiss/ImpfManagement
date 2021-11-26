USE [ImpfManagement]
GO
SET IDENTITY_INSERT [dbo].[Vaccination] ON 

INSERT [dbo].[Vaccination] ([VaccinationId], [Vaccine]) VALUES (1, N'Pfizer')
INSERT [dbo].[Vaccination] ([VaccinationId], [Vaccine]) VALUES (2, N'Moderna')
INSERT [dbo].[Vaccination] ([VaccinationId], [Vaccine]) VALUES (3, N'AstraZeneca')
SET IDENTITY_INSERT [dbo].[Vaccination] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [SecondName], [AGE], [Street], [Plz], [Place], [NumVaccinations], [VaccinationId]) VALUES (1, N'Jan', N'Nussberger', N'25', N'Englischviertelstrasse', N'8032', N'Zürich', 2, 1)
INSERT [dbo].[Person] ([Id], [FirstName], [SecondName], [AGE], [Street], [Plz], [Place], [NumVaccinations], [VaccinationId]) VALUES (2, N'Kilian', N'Weber', N'66', N'Bahnhofstrasse 10', N'8001', N'Zürich', 1, 2)
INSERT [dbo].[Person] ([Id], [FirstName], [SecondName], [AGE], [Street], [Plz], [Place], [NumVaccinations], [VaccinationId]) VALUES (3, N'Tim', N'Beck', N'70', N'Europastrasse 20', N'8004', N'Zürich', 3, 3)
INSERT [dbo].[Person] ([Id], [FirstName], [SecondName], [AGE], [Street], [Plz], [Place], [NumVaccinations], [VaccinationId]) VALUES (4, N'Denis', N'Meier', N'43', N'Risiweg 5', N'8002', N'Zürich',2, 3)
INSERT [dbo].[Person] ([Id], [FirstName], [SecondName], [AGE], [Street], [Plz], [Place], [NumVaccinations], [VaccinationId]) VALUES (5, N'Pascal', N'Meier', N'38', N'Rampenweg 6', N'8032', N'Zürich',2, 3)
SET IDENTITY_INSERT [dbo].[Person] OFF