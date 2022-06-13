/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--DECLARE @InsertedSellerIds Table (ID int)
--DECLARE @InsertedBookIds Table (ID int)

--INSERT INTO [dbo].[Sellers] ([Name], [Surname], [BankAccountNumber], [Address])
--OUTPUT inserted.Id
--INTO @InsertedSellerIds(ID)
--VALUES ('Artur', 'Barsamyan', '14469763641', 'Teryan'),
--		('Gagik', 'Hovsepyan', '57634434', 'Mashtoc')

			
--DECLARE @date date = '12-21-16';
--DECLARE @datetime2 datetime2 = @date;

--INSERT INTO [dbo].[Sellers] ([Cost], [Genre], [Author], [Title], datetime2)
--OUTPUT inserted.Id
--INTO @InsertedBookIds(ID)
--VALUES (500, 'Detective', 'Agata Kristy', 'nnlskndla', datetime2)


--INSERT INTO [dbo].[SellerBook]([SellerId], [BookId])
--SELECT @InsertedSellerIds.ID, @InsertedBookIds.ID
--FROM @InsertedSellerIds, @InsertedBookIds