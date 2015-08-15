CREATE FUNCTION dbo.getIST ()
RETURNS datetime
AS

BEGIN

DECLARE @IST AS datetime;

  SET @IST = DATEADD(mi, 330, getDate())
  RETURN @IST

END
