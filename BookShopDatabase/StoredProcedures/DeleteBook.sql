CREATE PROCEDURE [dbo].[DeleteBook]
	@id int
AS
	DELETE FROM [Books]
	WHERE [Books].Id = @id
RETURN 0
