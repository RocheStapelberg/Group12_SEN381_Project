USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spDeleteProvider 
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Delete SP for Provider
	DELETE FROM [Provider]
	WHERE Id = @Id;
END
GO
