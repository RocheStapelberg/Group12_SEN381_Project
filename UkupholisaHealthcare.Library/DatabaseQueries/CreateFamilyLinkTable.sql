USE UkupholisaDb
GO
CREATE TABLE FamilyLink 
(
 Id INT IDENTITY(1,1) NOT NULL,
 FamilyName NVARCHAR(50) NOT NULL,
 MemberCount INT NULL,
 DateCreated DATETIME2 NOT NULL DEFAULT getutcdate()
)
