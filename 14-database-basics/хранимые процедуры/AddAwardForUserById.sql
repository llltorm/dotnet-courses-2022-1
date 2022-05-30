----------------ƒобавление награды конкретному пользователю--------------------------
CREATE PROCEDURE AddAwardForUserById
(
  @UserId INT,
  @AwardId INT
)
AS
BEGIN

	INSERT INTO ConnectionUserAndAward(UserId, AwardId)
		VALUES (@UserId, @AwardId)
END

EXECUTE AddAwardForUserById @UserId = 1, @AwardId = 3

DROP PROCEDURE AddAwardForUser

Select * From ConnectionUserAndAward
