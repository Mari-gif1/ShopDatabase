CREATE TABLE Users(	
	[Id]				INT                 IDENTITY(1,1),
	[UserName]			NVARCHAR(20) 		NOT NULL,
	[Password] 			VARCHAR(15) 		NOT NULL,
	[EmailAddress]		VARCHAR(50)			NOT NULL,
	[Role]				VARCHAR(20)			NULL,
	[Surname]				NVARCHAR(30)        NOT NULL,
	[GivenName]			NVARCHAR(20)		NOT NULL,
	CONSTRAINT PK_UerId		PRIMARY KEY (Id)
);
