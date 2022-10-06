USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spDeletemedicalCondition
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Delete SP for MedicalCondition
	DELETE FROM [MedicalCondition]
	WHERE Id = @Id;
END
GO
