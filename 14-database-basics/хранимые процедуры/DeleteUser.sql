----------------Удаление пользователя---------------------------

CREATE PROCEDURE DeleteUser
(
  @UserId INT
)
AS
BEGIN

	DELETE FROM ConnectionUserAndAward
	Where UserId = @UserId


	DELETE FROM Users 
	Where Id = @UserId

	--UPDATE Users
	--SET Id = Id - 1
	--WHERE Id > @UserId

END

EXECUTE DeleteUser @UserId = 5

DROP PROCEDURE DeleteUser

SELECT * FROM Award
SELECT * FROM Users
SELECT * FROM ConnectionUserAndAward
