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
    @Family_Id  INT,
	@PolicyName NVARCHAR(50), 
	@Description NVARCHAR(max), 
	@PolicyPrice money,
	@isApproved bit
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Policy
	INSERT INTO [Policy](Family_id,PolicyName, [Description] ,PolicyPrice,isApproved)
	VALUES (@Family_Id,@PolicyName, @Description, @PolicyPrice,@isApproved);
END
GO
-- UPDATE
CREATE PROCEDURE spUpdatePolicy
@Id INT,
    @Family_Id  INT,
	@PolicyName NVARCHAR(50), 
	@Description NVARCHAR(max), 
	@PolicyPrice money,
	@isApproved bit
AS
BEGIN
	SET NOCOUNT ON;
    -- Update SP for Policy
	UPDATE [Policy] 
	SET( 
	Family_id = @Family_Id, 
	PolicyName=@PolicyName,
	[Description]=@Description,
	PolicyPrice=@PolicyPrice,
	isApproved=@isApproved,
	)
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