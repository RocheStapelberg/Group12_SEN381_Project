USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spGetMedicalCondition
@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for MedicalCondition
	SELECT *
    FROM [MedicalCondition]
	WHERE Id = @Id;
END
GO