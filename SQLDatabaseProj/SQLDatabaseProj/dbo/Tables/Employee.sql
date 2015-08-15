
CREATE TABLE Employee
(
    EmpId        int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [FullName]    nvarchar(50),
    [Address1]        nvarchar(50),
    City        nvarchar(30), 
    [Client] INT NULL, 
    [imageURL] NCHAR(10) NULL, 
    [Address2] NVARCHAR(50) NULL
)
GO