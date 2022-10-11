-- GET ALL
USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spGetAllProviders 
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for Provider
	SELECT *
    FROM [Provider];
END
GO
-- GET BY ID
-- INSERT
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
-- UPDATE
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
    SET ProviderName = @ProviderName, ProviderAddress = @ProviderAddress, ProviderContact = @ProviderContact
    WHERE Id = @Id
END
GO
-- DELETE 
CREATE PROCEDURE spDeleteProvider 
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Delete SP for Provider
	DELETE FROM [Provider]
	WHERE Id = @Id;
END
GO