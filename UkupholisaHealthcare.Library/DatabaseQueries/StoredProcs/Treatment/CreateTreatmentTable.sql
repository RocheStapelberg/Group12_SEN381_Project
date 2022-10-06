use UkupholisaDb
GO 
CREATE TABLE [Treatement](
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Provider_id INT NOT NULL , 
TreatmentName NVARCHAR(50) NOT NULL ,
[Description] NVARCHAR(MAX) NOT NULL 

)



