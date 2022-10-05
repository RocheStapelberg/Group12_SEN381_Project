USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spUpdateMedicalCondition
    @Treatment_Id  INT,
	@ConditionName NVARCHAR(50), 
	@Description NVARCHAR(max)

AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Policy
	UPDATE [MedicalCondition]
    SET (Treatment_Id=@Treatment_Id,ConditionName = @ConditionName, [Description] = @Description)
    WHERE Id = @Id
END
GO