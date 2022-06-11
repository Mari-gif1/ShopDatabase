CREATE PROCEDURE [dbo].[GetUsers]
AS
	SELECT [Id], [Name], [Surname], [Email], [AccountNumber], [Balance], [Address], [DateOfBirth]
	FROM [Users]
RETURN 0

