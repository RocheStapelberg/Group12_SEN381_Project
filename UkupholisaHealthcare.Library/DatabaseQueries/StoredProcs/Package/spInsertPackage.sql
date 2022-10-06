USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spInsertPackage
    @Policy_Id  INT,
	@PackageName NVARCHAR(50), 
	@PackageDescription NVARCHAR(max), 
	@PackageCost money,
	@isActive bit
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Provider
	INSERT INTO [Package](Policy_id,PackageCost, [PackageDescription] ,PackageCost,isActive)
	VALUES (@Policy_Id,@PackageName, @PackageDescription, @PackageCost,@isActive);
END
GO
