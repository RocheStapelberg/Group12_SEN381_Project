USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spInsertTreatment
    @Id  INT,
	@Provider_Id INT,
	@TreatmentName NVARCHAR(50) 
	@Description NVARCHAR(max)

AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Treatment
	INSERT INTO [Treatment](Id, Provider_Id, TreatmentName, [Description] )
	VALUES (@Id,@Provider_Id, @TreatmentName @Description);
END
GO