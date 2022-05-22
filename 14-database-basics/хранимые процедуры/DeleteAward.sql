----------------Удаление награды---------------------------

CREATE PROCEDURE DeleteAward
(
  @AwardId INT
)
AS
BEGIN

	--удаление записи из смежной таблицы
	DELETE FROM ConnectionUserAndAward
	Where AwardId = @AwardId
	--ON DELETE CASCADE

	--удаление записи из наград
	DELETE FROM Award
	Where Id = @AwardId

	--обновление id в наградах
	UPDATE Award
	SET Id = Id - 1
	WHERE Id > @AwardId

END

--EXECUTE DeleteAward @AwardId = 4

--DROP PROCEDURE DeleteAward

--Select * From Award

--Select * From ConnectionUserAndAward