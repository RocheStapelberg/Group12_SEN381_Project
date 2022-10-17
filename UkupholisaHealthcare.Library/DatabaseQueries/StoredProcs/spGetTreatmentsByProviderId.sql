SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spGetTreatmentsByProviderId
	@ProviderId INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *
	FROM Treatment
	WHERE Id IN (SELECT Fk_Treatment_Id FROM ProviderTreatment WHERE FK_Provider_Id = @ProviderId)
END
GO
