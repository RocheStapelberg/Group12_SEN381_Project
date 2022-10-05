USE UkupholisaDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spInsertClient 
    @Family_Id INT,
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
	INSERT INTO [Client](Family_Id,Firstname, Surname,Age,Gender,Adress,EmailAdress,Cellphone,MemberType,isActive,DateCreated)
	VALUES (@Family_Id,@Firstname, @Surname, @Age,@Gender,@Address,@EmailAdress,@Cellphone,@MemberType,@isActive,@DateCreated);
END
GO
