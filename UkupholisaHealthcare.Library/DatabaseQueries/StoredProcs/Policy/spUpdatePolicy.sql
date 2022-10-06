USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
