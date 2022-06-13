CREATE PROCEDURE [dbo].[GetUser]
	@Id int
AS
	SELECT [Id], [UserName], [Password], [EmailAddress], [Role], [Surname], [GivenName]
	FROM [Users]
	Where [Users].Id = @Id
RETURN 0
