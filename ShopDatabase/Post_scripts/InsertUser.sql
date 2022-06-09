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

DECLARE @date date = '12-21-16';
DECLARE @datetime2 datetime2 = @date;

insert into Users ([Name], [Surname], [AccountNumber], [Balance], [Picture], [Address], [DateOfBirth], [Login], [Password])
values (N'Մարի', N'Խաչիկյան', N'123456788', 500, NULL,  N'Էրեբունի', @datetime2, 'marik', 'marik2022'),
        ('Julieta', N'Soghomonyan', N'123456788', 500, NULL, N'Էրեբունի', @datetime2, 'july', 'july2022'),
        ('Lilit', N'Khachikyan', N'123456788', 500, NULL, N'Էրեբունի', @datetime2, 'lilik', 'lilik2022'),
        ('Lilit', 'Khachatryab', N'123456788', 500, NULL, N'Էրեբունի', @datetime2, 'lilit', 'lilit2022')
