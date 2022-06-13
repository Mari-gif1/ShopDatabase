CREATE PROCEDURE [dbo].[AddBook]
	@Title nvarchar(100),
	@Cost money,
	@Genre nvarchar(30),
	@Author nvarchar(100),
	@PublishYear int
AS
	INSERT INTO [Books]([Title], [Cost], [Genre], [Author], [PublishYear])
	VALUES(@Title, @Cost, @Genre, @Author, @PublishYear)
RETURN SCOPE_IDENTITY()