-- GET ALL
USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spGetAllPolicy 
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for Policy
	SELECT *
    FROM [Policy];
END
GO
-- GET BY ID
CREATE PROCEDURE spGetPolicyById
@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for Provider
	SELECT *
    FROM [Policy]
	WHERE Id = @Id;
END
GO
-- INSERT
CREATE PROCEDURE spInsertPolicy
   
	@PolicyName NVARCHAR(50), 
	@Description NVARCHAR(max), 
	@PolicyMonthlyPrice money ,
	@isApproved bit,
	@isActive bit

AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Policy
	INSERT INTO [Policy](PolicyName, [Description] ,PolicyMonthlyPrice,isApproved,isActive)
	VALUES (@PolicyName, @Description, @PolicyMonthlyPrice,@isApproved,@isActive);
END
GO
-- UPDATE
CREATE PROCEDURE spUpdatePolicy
@Id INT,
    @PolicyName NVARCHAR(50), 
	@Description NVARCHAR(max), 
	@PolicyMonthlyPrice money ,
	@isApproved bit,
	@isActive bit
AS
BEGIN
	SET NOCOUNT ON;
    -- Update SP for Policy
	UPDATE [Policy] 
	SET
	 
	PolicyName=@PolicyName,
	[Description]=@Description,
	PolicyMonthlyPrice=@PolicyMonthlyPrice,
	isApproved=@isApproved,
	isActive=@isActive

	
	WHERE
	Id=@Id
END
GO
-- DELETE
CREATE PROCEDURE spDeletePolicy
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Delete SP for Policy
	DELETE FROM [Policy]
	WHERE Id = @Id;
END
GO