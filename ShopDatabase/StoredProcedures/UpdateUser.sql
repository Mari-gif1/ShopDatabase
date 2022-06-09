CREATE PROCEDURE [dbo].[UpdateUser]
	@Id int,
	@Name nvarchar(20),
	@Surname nvarchar(20),
	@AccountNumber nvarchar(20),
	@Balance SMALLMONEY,
	@Picture VARBINARY(MAX),
	@Address nvarchar(20),
	@DateOfBirth datetime2,
	@Login varchar(20),
	@Password varchar(20)
AS
	UPDATE Users
	SET Id = @Id, Name = @Name, 
	where UserId = @UserId
RETURN 0
