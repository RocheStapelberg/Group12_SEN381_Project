USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spInsertCallReport
    @Id INT,
	@Client_Id INT,
	@CallBegin INT, 
	@CallEnd INT, 
	@IsSatisfied bit,
	
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for CallReport
	INSERT INTO [CallReport](Client_Id, CallBegin CallEnd, IsSatisfied)
	VALUES (@Client_Id,@CallBegin, @CallEnd, @IsSatisfied);
END
GO