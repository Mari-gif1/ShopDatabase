CREATE TABLE [dbo].[Sails]
(
	[Id]		   INT NOT NULL IDENTITY(1,1),
	[UserId]	   INT NOT NULL,
	[SellerBookId] INT NOT NULL,
	CONSTRAINT PK_SailId		PRIMARY KEY (Id),
	CONSTRAINT FK_User_Id		FOREIGN KEY ([UserId])			 REFERENCES Users(Id)		ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_SellerBook_Id FOREIGN KEY ([SellerBookId])	 REFERENCES SellerBook(Id)	ON UPDATE CASCADE ON DELETE CASCADE,
)
