﻿CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Phone] VARCHAR(50) NOT NULL, 
    [Zip] VARCHAR(50) NOT NULL, 
    [HireDate] VARCHAR(50) NOT NULL
)
