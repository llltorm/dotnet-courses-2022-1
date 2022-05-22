----------------Изменение данных награды---------------------------

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



--EXECUTE EditAward @AwardId = 3, @Title = 'Награда1', @Description = 'за настроение1'

--EXECUTE EditAward @AwardId = 3, @Title = 'Награда', @Description = 'за настроение'

--DROP PROCEDURE EditAward

--Select * From Award