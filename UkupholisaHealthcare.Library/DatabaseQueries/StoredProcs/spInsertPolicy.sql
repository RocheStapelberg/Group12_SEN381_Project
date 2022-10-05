USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
	INSERT INTO [Policy](Family_id,PolicyeName, [Description] ,PolicyPrice,isApproved)
	VALUES (@Family_Id,@PolicyName, @Description, @PolicyPrice,@isApproved);
END
GO
