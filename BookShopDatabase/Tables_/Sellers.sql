CREATE TABLE Sellers(	
	[Id]			INT              IDENTITY(1, 1) NOT NULL,
	[Name]			NVARCHAR(20) 		NOT NULL,
	[Surname] 		NVARCHAR(30) 		NOT NULL,
	[Email]			VARCHAR(30)			NOT NULL,
	[AccountNumber]	VARCHAR(20)			NOT NULL,
	[Address]	    NVARCHAR(20),
	[DateOfBirth]	    DATETIME,
	[Login]		    VARCHAR(20)			UNIQUE NOT NULL,
	[Password]		VARCHAR(20)			NOT NULL,
	CONSTRAINT PK_SellerId		PRIMARY KEY (Id)
);
