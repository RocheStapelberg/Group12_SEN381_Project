USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spUpdateCallReport
    @Id INT,
	@Client_Id INT,
	@CallBegin INT, 
	@CallEnd INT, 
	@IsSatisfied bit,
	
AS
BEGIN
	SET NOCOUNT ON;
    -- Update SP for CallReport
    UPDATE [CallReport]
    SET (Client_Id = @Client_Id, CallBegin = @CallBegin, CallEnd = @CallEnd, IsSatisfied = @IsSatisfied )
    WHERE Id = @Id
END
GO
