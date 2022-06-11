CREATE PROCEDURE [dbo].[InsertPicture]
	@BookTitle varchar(50),
	@BookAuthor varchar(50),
	@PicUrl nvarchar(150)
AS

	DECLARE @BookId int

	SET @BookId = (SELECT ID
					FROM Books
					Where [Title] = @BookTitle	AND [Author] = @BookAuthor)

	INSERT INTO Pictures([BookId],[Source])
		VALUES (@BookId, @PicUrl);
GO
