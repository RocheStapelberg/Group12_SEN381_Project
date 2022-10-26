USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- GET ALL CLIENT
CREATE PROCEDURE spGetAllClient 
AS
BEGIN
	SET NOCOUNT ON;
    -- Get All SP for Provider
	SELECT *
    FROM [Client]
END
GO
-- GET CLIENT BY ID
CREATE PROCEDURE spGetClientById 
@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Get by Id Client
	SELECT *
    FROM [Client]
	WHERE Id = @Id;
END
GO
-- INSERT CLIENT
CREATE PROCEDURE spInsertClient 
    @FamilyLink_Id INT,
	@Firstname NVARCHAR(50), 
	@Surname NVARCHAR(50),
	@Age INT,
	@Gender NVARCHAR(50),
	@Address NVARCHAR(100), 
	@EmailAddress NVARCHAR(50) ,
	@Cellphone NVARCHAR(10) ,
	@MemberType NVARCHAR(50) ,
	@isActive bit,
	@DateCreated DATETIME2
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Client
	INSERT INTO [Client](FamilyLink_Id, Firstname, Surname, Age, Gender, [Address], EmailAddress, Cellphone, MemberType, isActive, DateCreated)
	VALUES (@FamilyLink_Id, @Firstname, @Surname, @Age, @Gender, @Address, @EmailAddress, @Cellphone, @MemberType, @isActive, @DateCreated);
END
GO
-- UPDATE CLIENT 
CREATE PROCEDURE spUpdateClient 
    @FamilyLink_Id INT,
    @Id INT,
	@Firstname NVARCHAR(50), 
	@Surname NVARCHAR(50),
	@Age INT,
	@Gender NVARCHAR(50),
	@Address NVARCHAR(100), 
	@EmailAddress NVARCHAR(50) ,
	@Cellphone NVARCHAR(10) ,
	@MemberType NVARCHAR(50) ,
	@isActive bit,
	@DateCreated DATETIME2
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Cclient
	UPDATE [Client] 
	SET FamilyLink_Id=@FamilyLink_Id,
	Firstname=@Firstname, 
	Surname=@Surname,
	Age=@Age,
	Gender=@Gender,
	[Address]=@Address,
	EmailAddress=@EmailAddress,
	Cellphone=@Cellphone,
	MemberType=@MemberType,
	isActive=@isActive,
	DateCreated=@DateCreated
	WHERE Id=@Id;
END
GO
-- DELETE CLIENT
CREATE PROCEDURE spDeleteClient 
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
    -- Delete SP for Provider
	DELETE FROM [Client]
	WHERE Id = @Id;
END
GO
-- SEARCH CLIENT 
CREATE PROCEDURE spSearchClientByName
    @FirstName NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM [Client]
    WHERE [Firstname] LIKE '%' + @FirstName + '%';
END


