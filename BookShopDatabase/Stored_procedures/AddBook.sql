CREATE PROCEDURE [dbo].[AddBook]
	@Title nvarchar(100),
	@Cost money,
	@Genre nvarchar(30),
	@Author nvarchar(100),
	@PublishDate datetime
AS
	INSERT INTO [Books]([Title], [Cost], [Genre], [Author], [PublishDate])
	VALUES(@Title, @Cost, @Genre, @Author, @PublishDate)
RETURN 0