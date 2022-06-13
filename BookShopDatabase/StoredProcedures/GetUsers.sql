CREATE PROCEDURE [dbo].[GetUsers]
AS
	SELECT [Id], [UserName], [Password], [EmailAddress], [Role], [Surname], [GivenName]
	FROM [Users]
RETURN 0


