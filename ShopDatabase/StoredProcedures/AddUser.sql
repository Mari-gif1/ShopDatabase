CREATE PROCEDURE [dbo].[AddUser]
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
	INSERT INTO Users([Id], [Name], [Surname], [AccountNumber], [Balance], [Picture], [Address], [DateOfBirth], [Login], [Password])
	VALUES(@Id, @Name, @Surname, @AccountNumber, @Balance, @Picture, @Address, @DateOfBirth, @Login, @Password)

RETURN 