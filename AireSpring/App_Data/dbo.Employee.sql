CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Phone] VARCHAR(50) NOT NULL, 
    [Zip] VARCHAR(50) NOT NULL, 
    [HireDate] DateTime NOT NULL
)


SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT INTO [dbo].[Employee] ([Id], [FirstName], [LastName], [Phone], [Zip], [HireDate]) VALUES (1, N'Bill', N'Gates III', N'(455) 845-2123', N'91092', N'2019-12-03 00:00:00')
INSERT INTO [dbo].[Employee] ([Id], [FirstName], [LastName], [Phone], [Zip], [HireDate]) VALUES (2, N'Steve', N'Jobs', N'(635) 487-5423', N'91093', N'2018-10-01 00:00:00')
INSERT INTO [dbo].[Employee] ([Id], [FirstName], [LastName], [Phone], [Zip], [HireDate]) VALUES (3, N'Brian', N'Culbertson', N'(545) 684-5621', N'910652', N'2017-12-04 00:00:00')
SET IDENTITY_INSERT [dbo].[Employee] OFF