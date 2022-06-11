CREATE PROCEDURE [dbo].[GetBooksWithPicturesAndSeller]
AS
	SELECT [Books].Id, [Books].Title, [Books].Author, [Books].Cost, [Books].Genre,[Sellers].[Name], [Books].PublishDate
	FROM [Books]
	join [Pictures] on Pictures.BookId = Books.Id
	join [SellerBook] on [Books].Id = [SellerBook].[BookId]
	join [Sellers] on [SellerBook].SellerId = [Sellers].[Id]
RETURN 0
