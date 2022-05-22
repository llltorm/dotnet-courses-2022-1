----------------���������� ������� ����������� ������������--------------------------
CREATE PROCEDURE AddAwardForUser
(
  @UserId INT,
  @Title NVARCHAR(150)
)
AS
BEGIN

	INSERT INTO ConnectionUserAndAward(UserId, AwardId)
		VALUES (@UserId, (Select Id From Award Where Title = @Title))
END

EXECUTE AddAwardForUser @UserId = 3, @Title = '�������'

DROP PROCEDURE AddAwardForUser

Select * From ConnectionUserAndAward

