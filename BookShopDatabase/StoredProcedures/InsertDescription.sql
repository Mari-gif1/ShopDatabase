CREATE PROCEDURE [dbo].[InsertDescription]
	@BookTitle varchar(50),
	@BookAuthor varchar(50),
	@ShortDescription nvarchar(600),
	@LongDescription nvarchar(1500)
AS

	DECLARE @BookId int
	DECLARE @CountInDesc int
	Set @BookId = (SELECT ID FROM [Books] Where [Title] = @BookTitle AND [Author] = @BookAuthor)
	SET @CountInDesc = isnull((SELECT COUNT(*) FROM [Description] WHERE [BookId] = @BookId),0)

	IF @CountInDesc = 1
	BEGIN
		RAISERROR ( 'Whoops, Such Book Description already Exsists',18,1)		
	END
	ELSE
	BEGIN
		INSERT INTO Description([Short],[Long],[BookId])
			VALUES (@ShortDescription, @LongDescription, @BookId);
	END
 
GO