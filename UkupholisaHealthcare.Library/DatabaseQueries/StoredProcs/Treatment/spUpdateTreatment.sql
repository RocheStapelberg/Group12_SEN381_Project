GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spInsertTreatment
@Id INT,
    @Id  INT,
	@Provider_Id INT,
	@TreatmentName NVARCHAR(50) 
	@Description NVARCHAR(max)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Treatment
	UPDATE [Package]
    SET (Provider_Id=@Provider_Id, TreatmentName = @TreatmentName, Description = @Description)
    WHERE Id = @Id
END
GO