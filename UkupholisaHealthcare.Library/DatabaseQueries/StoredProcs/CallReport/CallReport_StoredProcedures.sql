USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- GET ALL CALLREPORT
CREATE PROCEDURE spGetAllCallReport
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for CallReport
	SELECT *
    FROM [CallReport]
END
GO
-- INSERT CALLREPORT
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
-- UPDATE CALLREPORT
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
-- DELETE CALLREPORT
CREATE PROCEDURE spDeleteCallReport
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Delete SP for CallReport
	DELETE FROM [CallReport]
	WHERE Id = @Id;
END
GO