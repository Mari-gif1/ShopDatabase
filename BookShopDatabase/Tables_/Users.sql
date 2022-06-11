CREATE TABLE Users(	
	[Id]			INT                 IDENTITY(1,1),
	[Name]			NVARCHAR(20) 		NOT NULL,
	[Surname] 		NVARCHAR(30) 		NOT NULL,
	[Email]			VARCHAR(50)			NOT NULL,
	[AccountNumber]	VARCHAR(20)		NOT NULL,
	[Balance]		SMALLMONEY,
	[Address]	    NVARCHAR(20),
	[DateOfBirth]	    DATETIME		NULL,
	[Login]		    VARCHAR(20)			UNIQUE NOT NULL,
	[Password]		VARCHAR(20)			NOT NULL,
	CONSTRAINT PK_UerId		PRIMARY KEY (Id)
);
