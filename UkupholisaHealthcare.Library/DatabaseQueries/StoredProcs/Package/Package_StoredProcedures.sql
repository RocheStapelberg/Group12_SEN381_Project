-- GET ALL
USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spGetAllPackage 
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for Package
	SELECT *
    FROM [Package];
END
GO
-- GET BY ID
CREATE PROCEDURE spGetPackageById
@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for Package
	SELECT *
    FROM [Package]
	WHERE Id = @Id;
END
GO
-- INSERT
CREATE PROCEDURE spInsertPackage
	@Id INT,
	@PackageName NVARCHAR(50), 
	@PackageDescription NVARCHAR(max), 
	@PackageCost money,
	@isActive bit
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Provider
	INSERT INTO [Package](PackageName, [PackageDescription] ,PackageCost, isActive)
	VALUES (@PackageName, @PackageDescription, @PackageCost, @isActive);
END
GO
-- UPDATE
CREATE PROCEDURE spUpdatePackage
    @Id INT,
	@PackageName NVARCHAR(50), 
	@PackageDescription NVARCHAR(max), 
	@PackageCost money,
	@isActive bit
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Provider
	UPDATE [Package]
    SET PackageName = @PackageName, PackageDescription = @PackageDescription, PackageCost = @PackageCost, isActive=@isActive
    WHERE Id = @Id
END
GO
-- DELETE
CREATE PROCEDURE spDeletePackage
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Delete SP for Package
	DELETE FROM [Package]
	WHERE Id = @Id;
END