CREATE TABLE [dbo].[Attendance]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpId] INT NOT NULL, 
    [MarkFlag] BIT NOT NULL, 
    [MarkTime] DATETIME NOT NULL, 
    CONSTRAINT [FK_Attendance_ToEmployee] FOREIGN KEY ([EmpId]) REFERENCES [Employee]([EmpId])
)
