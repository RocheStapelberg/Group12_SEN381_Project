use UkupholisaDb
GO 
CREATE TABLE [MedicalCondition](
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Treatement_id INT NOT NULL , 
ConditionName NVARCHAR(50) NOT NULL,
[Description] NVARCHAR(MAX) NOT NULL 

)
