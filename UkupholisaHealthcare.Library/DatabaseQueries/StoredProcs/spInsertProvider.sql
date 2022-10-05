USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spInsertProvider 
	@ProviderName NVARCHAR(50), 
	@ProviderAddress NVARCHAR(100), 
	@ProviderContact NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Provider
	INSERT INTO [Provider](ProviderName, ProviderAddress, ProviderContact)
	VALUES (@ProviderName, @ProviderAddress, @ProviderContact);
END
GO
