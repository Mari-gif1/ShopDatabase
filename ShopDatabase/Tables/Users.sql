CREATE TABLE [dbo].[Users]
(
	[Id]					INT					NOT NULL IDENTITY(1, 1),
	[Name]				NVARCHAR(20) 		NOT NULL,
	[Surname] 			NVARCHAR(20) 		NOT NULL,
	[AccountNumber]		NVARCHAR(20)		NOT NULL,
	[Balance]		    SMALLMONEY,
	[Picture]		    VARBINARY(MAX)		NULL,
	[Address]			NVARCHAR(20),
	[DateOfBirth]	    datetime2,
	[Login]				VARCHAR(20)			UNIQUE NOT NULL,
	[Password]			VARCHAR(20)			UNIQUE NOT NULL,
	CONSTRAINT PK_UserId PRIMARY KEY ([Id]),
)
