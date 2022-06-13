CREATE PROCEDURE [dbo].[GetBook]
	@id int
AS
	SELECT *
	FROM [Books]
	WHERE [Books].Id = @id
RETURN 0
