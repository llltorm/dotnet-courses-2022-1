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

	--�������
	--INSERT INTO Award(Id, Title, Description)
	--VALUES (@AwardId, '���', '��������')

	--INSERT INTO Users(Id, FirstName, LastName, Birthdate)
	--VALUES ((Select MAX(id) + 1 From Users), '�� ���', '��������', '01-01-2000')
	--/�������

	--���������� id � ������� �������
	--UPDATE ConnectionUserAndAward 
	--SET AwardId = AwardId - 1
	--WHERE AwardId > @AwardId

	--DELETE FROM Award
	--Where Id = @AwardId

	--���������� id � ��������
	--UPDATE Award
	--SET Id = Id - 1
	--WHERE Id > @AwardId


END

--EXECUTE DeleteAward @AwardId = 4

--DROP PROCEDURE DeleteAward

--Select * From Award

--Select * From ConnectionUserAndAward