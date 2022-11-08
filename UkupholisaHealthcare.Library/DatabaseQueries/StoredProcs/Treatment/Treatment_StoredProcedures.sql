-- GET ALL
USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spGetAllTreatment
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for Treatment
	SELECT *
    FROM [Treatment];
END
GO
-- GET BY ID
CREATE PROCEDURE spGetTreatmentById
@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for Treatment
	SELECT *
    FROM [Treatment]
	WHERE Id = @Id;
END
GO
-- INSERT
CREATE PROCEDURE spInsertTreatment
@Id int ,
    @Days int,
	@TreatmentName NVARCHAR(50),
	@Description NVARCHAR(max)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Treatment
	INSERT INTO [Treatment](TreatmentName,[Days], [Description])
	VALUES (@TreatmentName,@Days, @Description);
END
GO
-- UPDATE 
CREATE PROCEDURE spUpdateTreatment
    @Id INT,
	@Days int,
	@TreatmentName NVARCHAR(50),
	@Description NVARCHAR(max)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Treatment
	UPDATE [Treatment]
    SET TreatmentName = @TreatmentName, [Days]=@Days, [Description] = @Description
    WHERE Id = @Id
END
GO
-- DELETE
CREATE PROCEDURE spDeleteTreatment
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Delete SP for Treatment
	DELETE FROM [Treatment]
	WHERE Id = @Id;
END
GO