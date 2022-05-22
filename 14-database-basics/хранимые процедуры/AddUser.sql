----------------Создание пользователя--------------------------
CREATE PROCEDURE AddUser
(
  @FirstName NVARCHAR(50),
  @LastName NVARCHAR(50),
  @Bithdate DATE
)
AS
BEGIN
	INSERT INTO Users(Id, FirstName, LastName, Birthdate)
		VALUES ((Select MAX(id) + 1 From Users), @FirstName, @LastName, @Bithdate)
END

--EXECUTE AddUser @FirstName = 'Фёдор', @LastName = 'Шуваев', @Bithdate = '2005-05-09'

--DROP PROCEDURE AddUser

--Select * From Users
