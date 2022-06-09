CREATE TABLE [dbo].[Books]
(	
	[Id]			INT				NOT NULL IDENTITY(1,1),
    [Cost]			money			NOT NULL,
	[Genre]			nvarchar(30)	NOT NULL,
	[Author]		nvarchar(100)	NOT NULL,
	[Title]			nvarchar(200)	NOT NULL,
	[PublishDate]	datetime2		NOT NULL,
	CONSTRAINT Pr_ItemId PRIMARY KEY([Id])
)
