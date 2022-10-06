use UkupholisaDb
GO 
CREATE TABLE [Policy](
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Family_id INT NOT NULL , 
PolicyeName NVARCHAR(50) NOT NULL,
[Description] NVARCHAR(MAX)NOT NULL , 
PolicyPrice money NOT NULL ,
isApproved  bit NOT NULL 

)
