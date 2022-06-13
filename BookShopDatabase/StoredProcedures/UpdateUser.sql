CREATE PROCEDURE [dbo].[UpdateUser]
	@Id		int,
	@UserName nvarchar(20),
	@Password varchar(15),
	@EmailAddress varchar(50),
	@Role		varchar(20),
	@Surname NVARCHAR(30),
	@GivenName NVARCHAR(20)
AS
	UPDATE Users
	SET UserName = @UserName, Password = @Password, EmailAddress = @EmailAddress, Role = @Role, 
	Surname = @Surname, GivenName = @GivenName
	where [Id] = @Id
RETURN 0
