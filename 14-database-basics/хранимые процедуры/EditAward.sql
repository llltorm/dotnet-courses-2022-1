----------------��������� ������ �������---------------------------

CREATE PROCEDURE EditAward
(
  @AwardId INT,
  @Title NVARCHAR(150),
  @Description NVARCHAR(350)
)
AS
BEGIN
	UPDATE Award
		SET Title = @Title,
			Description = @Description
		WHERE Id = @AwardId
END



--EXECUTE EditAward @AwardId = 3, @Title = '�������1', @Description = '�� ����������1'

--EXECUTE EditAward @AwardId = 3, @Title = '�������', @Description = '�� ����������'

--DROP PROCEDURE EditAward

--Select * From Award