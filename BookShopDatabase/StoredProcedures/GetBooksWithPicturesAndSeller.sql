CREATE PROCEDURE [dbo].[GetBooksWithPicturesAndSeller]
AS
	SELECT [Books].Id as Id, [Books].Title as Title, [Books].Author as Author, [Books].Cost as Cost, [Pictures].Source, [Books].Genre as Genre,[Sellers].[Name] as SellerName, [Books].PublishYear as PublishDate
	FROM [Books]
	join [Pictures] on Pictures.BookId = Books.Id
	join [SellerBook] on [Books].Id = [SellerBook].[BookId]
	join [Sellers] on [SellerBook].SellerId = [Sellers].[Id]
RETURN 0
