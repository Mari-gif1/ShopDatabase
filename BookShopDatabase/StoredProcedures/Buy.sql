CREATE PROCEDURE [dbo].[Buy]
	@userId int,
	@bookId int,
	@sellerId int
AS
	DECLARE @SellerBookId int

	SET @SellerBookId  = isnull((SELECT ID FROM [SellerBook] Where @bookId = [BookId] AND @sellerId = SellerId), 0)
	
	IF @SellerBookId = 0
	BEGIN
		RAISERROR ( 'Whoops, Thare is no seller who sells such a book', 18, 1)		
	END
	ELSE
	BEGIN
		INSERT INTO Sails([UserId],[SellerBookId])
			VALUES (@userId, @SellerBookId);
	END

RETURN 0