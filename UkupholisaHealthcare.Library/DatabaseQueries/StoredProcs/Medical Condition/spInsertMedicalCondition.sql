USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spInsertMedicalCondition
    @Treatment_Id  INT,
	@ConditionName NVARCHAR(50), 
	@Description NVARCHAR(max)

AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Policy
	INSERT INTO [MedicalCondition](Treatement_id,ConditionName, [Description] )
	VALUES (@Treatment_Id,@ConditionName, @Description);
END
GO