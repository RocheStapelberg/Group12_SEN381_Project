use UkupholisaDb
GO 
CREATE TABLE [Package](
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Policy_id INT NOT NULL , 
PackageName NVARCHAR(50) NOT NULL ,
[PackageDescription] NVARCHAR(MAX) NOT NULL , 
PackageCost money NOT NULL ,
isActive  bit NOT NULL 

)
