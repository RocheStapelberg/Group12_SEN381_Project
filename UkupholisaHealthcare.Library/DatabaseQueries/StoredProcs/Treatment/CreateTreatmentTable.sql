use UkupholisaDb
GO 
CREATE TABLE [Treatment]
(
	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TreatmentName NVARCHAR(50) NOT NULL ,
	[Description] NVARCHAR(MAX) NOT NULL
)