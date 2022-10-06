USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spInsertPackage
@Id INT,
    @Policy_Id  INT,
	@PackageName NVARCHAR(50), 
	@PackageDescription NVARCHAR(max), 
	@PackageCost money,
	@isActive bit
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Provider
	UPDATE [Package]
    SET (Policy_id=@Policy_Id,PackageName = @PackageName, PackageDescription = @PackageDescription, PackageCost = @PackageCost,isActive=@isActive)
    WHERE Id = @Id
END
GO
