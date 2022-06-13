﻿CREATE TABLE [dbo].[Books]
(	
	[Id]			INT				NOT NULL IDENTITY(1,1),
	[Title]			NVARCHAR(100)	NOT NULL,
    [Cost]			MONEY			NOT NULL,
	[Genre]			NVARCHAR(30)	NOT NULL,
	[Author]		NVARCHAR(100)	NOT NULL,
	[PublishYear]	INT				NOT NULL,
	CONSTRAINT Pr_ItemId PRIMARY KEY([Id])
)
