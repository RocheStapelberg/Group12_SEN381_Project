-- GET ALL
USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spGetAllMedicalCondition
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for MedicalCondition
	SELECT *
    FROM [MedicalCondition];
END
GO
-- GET BY ID
CREATE PROCEDURE spGetMedicalCondition
@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for MedicalCondition
	SELECT *
    FROM [MedicalCondition]
	WHERE Id = @Id;
END
GO
-- INSERT 
CREATE PROCEDURE spInsertMedicalCondition
    @Treatment_Id  INT,
	@ConditionName NVARCHAR(50), 
	@Description NVARCHAR(max)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Policy
	INSERT INTO [MedicalCondition](Treatement_id, ConditionName, [Description])
	VALUES (@Treatment_Id, @ConditionName, @Description);
END
GO
-- UPDATE
CREATE PROCEDURE spUpdateMedicalCondition
    @Treatment_Id  INT,
	@ConditionName NVARCHAR(50), 
	@Description NVARCHAR(max)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Policy
	UPDATE [MedicalCondition]
    SET (Treatment_Id=@Treatment_Id,ConditionName = @ConditionName, [Description] = @Description)
    WHERE Id = @Id
END
GO
-- DELETE
CREATE PROCEDURE spDeleteMedicalCondition
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Delete SP for MedicalCondition
	DELETE FROM [MedicalCondition]
	WHERE Id = @Id;
END
GO
