use UkupholisaDb
GO 
CREATE TABLE [Policy]
(
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
PolicyName NVARCHAR(50) NOT NULL,
[Description] NVARCHAR(MAX)NOT NULL , 
PolicyMonthlyPrice money NOT NULL,
isApproved  bit NOT NULL Default 1,
isActive bit NOT NULL Default 1
)
