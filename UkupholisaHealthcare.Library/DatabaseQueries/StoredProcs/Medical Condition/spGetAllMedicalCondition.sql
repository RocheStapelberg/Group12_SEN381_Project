USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spGetAllMedicalCondition
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for MedicalCondition
	SELECT *
    FROM [MedicalCondition];
END
GO