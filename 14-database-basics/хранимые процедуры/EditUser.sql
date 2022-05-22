----------------Изменение данных пользователя---------------------------

CREATE PROCEDURE EditUser
(
  @UserId INT,
  @FirstName NVARCHAR(50),
  @LastName NVARCHAR(50),
  @Bithdate DATE
)
AS
BEGIN
	UPDATE Users
		SET FirstName = @FirstName,
			LastName = @LastName,
			Birthdate = @Bithdate
		WHERE Id = @UserId
END

--EXECUTE EditUser @UserId = 3, @FirstName = 'Валерия', @LastName = 'Анисимова', @Bithdate = '2005-05-09'

--EXECUTE EditUser @UserId = 3, @FirstName = 'Екатерина', @LastName = 'Николаева', @Bithdate = '2005-05-09'

--Select * From Users
