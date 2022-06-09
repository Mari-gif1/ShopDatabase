CREATE TABLE [dbo].[Sellers]
(
	[Id]				INT							NOT NULL IDENTITY(1,1),
	[Name]				NVARCHAR(30)				NOT NULL,
	[Surname]			NVARCHAR(50)				NOT NULL,
	[BankAccountNumber] NVARCHAR(20)				NOT NULL,
	[Address]			NVARCHAR(30)				NULL,
	[Login]				VARCHAR(20)			UNIQUE	NOT NULL,
	[Password]			VARCHAR(20)			UNIQUE	NOT NULL,
	CONSTRAINT PK_SellerId PRIMARY KEY (Id),
)
