CREATE PROCEDURE [dbo].[AddUser]
	@UserName nvarchar(20),
	@Password varchar(15),
	@EmailAddress varchar(50),
	@Role		varchar(20),
	@Surname NVARCHAR(30),
	@GivenName NVARCHAR(20)

AS
	INSERT INTO Users(UserName, Password, EmailAddress, Role, Surname, GivenName)
	VALUES(@UserName, @Password, @EmailAddress, @Role, @Surname, @GivenName)

RETURN SCOPE_IDENTITY()