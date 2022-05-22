CREATE PROCEDURE GettingAllRewards
  @UserId Int
AS
BEGIN
Select Title
From Award
Where Award.Id in
 (Select AwardId
  From Users Join ConnectionUserAndAward
  On Users.Id = ConnectionUserAndAward.UserId
  Where Users.Id = @UserId)
END

--EXECUTE GettingAllRewards @UserId = 4

--Select * From Users

--Select * From ConnectionUserAndAward

--Select * From Award

--DROP PROCEDURE GettingAllRewards