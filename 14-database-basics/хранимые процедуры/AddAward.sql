----------------Создание награды--------------------------
CREATE PROCEDURE AddAward
(
  @Title NVARCHAR(150),
  @Description NVARCHAR(350)
)
AS
BEGIN
	INSERT INTO Award(Id, Title, Description)
		VALUES ((Select MAX(id) + 1 From Award), @Title, @Description)
END

--EXECUTE AddAward @Title = 'Приз', @Description = 'за красивые глаза'

--DROP PROCEDURE AddAward

--Select * From Award
