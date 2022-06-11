CREATE PROCEDURE [dbo].[AddUser]
	@Name nvarchar(20),
	@Surname nvarchar(20),
	@Email nvarchar(30),
	@AccountNumber varchar(20),
	@Balance SMALLMONEY,
	@Address nvarchar(20),
	@DateOfBirth datetime,
	@Login varchar(20),
	@Password varchar(20)

AS
	INSERT INTO Users([Name], [Surname], [AccountNumber], [Balance], [Address], [DateOfBirth], [Login], [Password])
	VALUES(@Name, @Surname, @AccountNumber, @Balance, @Address, @DateOfBirth, @Login, @Password)

RETURN 