CREATE TABLE [dbo].[Pictures]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Source] NVARCHAR(150) NOT NULL, 
    [BookId] INT NOT NULL,
	CONSTRAINT PicturesTableID PRIMARY KEY([Id]),
	CONSTRAINT Book_Info_Pictures FOREIGN KEY ([BookId]) REFERENCES Books(ID) ON DELETE CASCADE
)
