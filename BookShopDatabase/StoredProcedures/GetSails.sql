CREATE PROCEDURE [dbo].[GetReserves]
@UserId int,
@sellerBookId int
AS
	SELECT [Users].[UserName], [Users].Surname, [Sellers].[Name], [Sellers].[Surname], [Books].Title, [Books].Author
	FROM [Sails] 
	join [Users] on [Sails].[UserId] = [Users].Id
	join [SellerBook] on [SellerBook].Id = [Sails].SellerBookId
	join [Sellers] on [SellerBook].SellerId = [Sellers].Id
	join [Books] on [SellerBook].BookId = [Books].Id
	where [Sails].[UserId] = @UserId and [SellerBook].Id = @sellerBookId
RETURN 0
