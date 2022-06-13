CREATE PROCEDURE [dbo].[GetUserWithEmailAndPassword]
	@EmailAddress varchar(50),
	@Password varchar(15)
AS
	SELECT *
	From [Users]
	Where [Users].EmailAddress = @EmailAddress and [Users].Password = @Password
RETURN 0
