----------------Удаление пользователя---------------------------

CREATE PROCEDURE DeleteUser
(
  @UserId INT
)
AS
BEGIN
	DELETE FROM Users 
	Where Id = @UserId

	UPDATE Users
	SET Id = Id - 1
	WHERE Id > @UserId
END

--EXECUTE DeleteUser @UserId = 4

--DROP PROCEDURE DeleteUser

--Select * From Users
