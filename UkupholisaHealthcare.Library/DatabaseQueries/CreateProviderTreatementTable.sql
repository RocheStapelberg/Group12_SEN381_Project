USE UkupholisaDb
GO
CREATE TABLE ProviderTreatment
(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	FK_Provider_Id INT NOT NULL,
	FK_Treatment_Id INT NOT NULL
)