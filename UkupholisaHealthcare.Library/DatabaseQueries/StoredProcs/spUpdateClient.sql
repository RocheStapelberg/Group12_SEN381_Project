USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spUpdateClient 
@Id INT,
	@Firstname NVARCHAR(50), 
	@Surname NVARCHAR(50),
	@Age INT,
	@Gender NVARCHAR(50),
	@Address NVARCHAR(100), 
	@EmailAdress NVARCHAR(50) ,
	@Cellphone NVARCHAR(10) ,
	@MemberType NVARCHAR(50) ,
	@isActive bit,
	@DateCreated DATETIME2

	
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert SP for Cclient
	UPDATE [Client] 
	SET( 
	Firstname=@Firstname, 
	Surname=@Surname,
	Age=@Age,
	Gender=@Gender,
	Adress=@Address,
	EmailAdress=@EmailAdress,
	Cellphone=@Cellphone,
	MemberType=@MemberType,
	isActive=@isActive,
	DateCreated=@DateCreated
	)
	WHERE
	Id=@Id
END
GO
