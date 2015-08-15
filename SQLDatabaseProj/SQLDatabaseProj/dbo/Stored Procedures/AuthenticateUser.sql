CREATE PROCEDURE [dbo].[AuthenticateUser]
	@userId nvarchar(30),
	@password nvarchar(50)
AS
	SELECT @userId, @password
RETURN 0
