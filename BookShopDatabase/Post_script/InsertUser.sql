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

--DECLARE @date date = '12-21-16';
--DECLARE @datetime datetime2 = '12-21-16';

--insert into Users ([Name], [Surname], [Email], [AccountNumber], [Balance], [Address], [DateOfBirth], [Login], [Password])
--values (N'Մարի', N'Խաչիկյան', 'mari.khachikyan@gmail.com', N'123456788', 500,  N'Էրեբունի', @datetime2, 'marik', 'marik2022'),
--        ('Julieta', N'Soghomonyan', 'julieta.soghomonyan@gmail.com', N'123456788', 500, N'Էրեբունի', @datetime2, 'july', 'july2022'),
--        ('Lilit', N'Khachikyan','lilit.khachikyan@gmail.com', N'123456788', 500, N'Էրեբունի', @datetime2, 'lilik', 'lilik2022'),
--        ('Lilit', 'Khachatryab','lilit.khachatryan@gmail.com', N'123456788', 500, N'Էրեբունի', @datetime2, 'lilit', 'lilit2022')

--GO
