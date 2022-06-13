CREATE PROCEDURE [dbo].[AddBook]
	@Title nvarchar(100),
	@Cost money,
	@Genre nvarchar(30),
	@Author nvarchar(100),
	@PublishYear int,
	@imageUrl varchar(2048)
AS
	INSERT INTO [Books]([Title], [Cost], [Genre], [Author], [PublishYear], [ImageURL])
	VALUES(@Title, @Cost, @Genre, @Author, @PublishYear, @imageUrl)
RETURN SCOPE_IDENTITY()