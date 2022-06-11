﻿CREATE PROCEDURE [dbo].[UpdateUser]
	@Id int,
	@Name nvarchar(20),
	@Surname nvarchar(20),
	@Email varchar(30),
	@AccountNumber nvarchar(20),
	@Balance SMALLMONEY,
	@Address nvarchar(20),
	@DateOfBirth datetime
AS
	UPDATE Users
	SET [Name] = @Name, [Surname] = @Surname, [Email] = @Email, [AccountNumber] = @AccountNumber, [Balance] = @Balance, [Address] = @Address, [DateOfBirth] = @DateOfBirth
	where [Id] = @Id
RETURN 0