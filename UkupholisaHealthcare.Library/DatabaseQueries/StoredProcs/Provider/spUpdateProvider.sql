USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spUpdateProviderById
    @Id INT,
	@ProviderName NVARCHAR(50), 
	@ProviderAddress NVARCHAR(100), 
	@ProviderContact NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
    -- Update SP for Provider
    UPDATE [Provider]
    SET (ProviderName = @ProviderName, ProviderAddress = @ProviderAddress, ProviderContact = @ProviderContact)
    WHERE Id = @Id
END
GO
