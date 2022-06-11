CREATE PROCEDURE [dbo].[GetUser]
	@Id int
AS
	SELECT [Id], [Name], [Surname], [Email], [AccountNumber], [Balance], [Address], [DateOfBirth]
	FROM [Users]
	Where [Users].Id = @Id
RETURN 0
