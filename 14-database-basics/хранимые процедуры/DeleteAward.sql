----------------�������� �������---------------------------

CREATE PROCEDURE DeleteAward
(
  @AwardId INT
)
AS
BEGIN

	--�������� ������ �� ������� �������
	DELETE FROM ConnectionUserAndAward
	Where AwardId = @AwardId
	--ON DELETE CASCADE

	--�������� ������ �� ������
	DELETE FROM Award
	Where Id = @AwardId

	--���������� id � ��������
	UPDATE Award
	SET Id = Id - 1
	WHERE Id > @AwardId

END

--EXECUTE DeleteAward @AwardId = 4

--DROP PROCEDURE DeleteAward

--Select * From Award

--Select * From ConnectionUserAndAward