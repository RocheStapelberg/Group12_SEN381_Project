use UkupholisaDb
GO 
CREATE TABLE [CallReport]
(
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Client_Id INT NOT NULL, 
CallBegin INT NOT NULL ,
CallEnd INT NOT NULL ,
isSatisfied bit NOT NULL 
)
