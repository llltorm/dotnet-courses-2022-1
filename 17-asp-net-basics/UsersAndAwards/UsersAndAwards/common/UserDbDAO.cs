using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Interfaces;
using System.Data;


namespace DAL
{

    public class UserDbDao : IUserDAO
    {
        private List<User> _users = new List<User>();

        private readonly string _connectionString;

        public UserDbDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddUser(string firstName, string lastName, DateTime birthdate, int age, List<string> awards)
        {
            //поиск максимального id
            int maxId = 0;
            foreach (var elem in _users)
            {
                if (elem.Id > maxId)
                {
                    maxId = elem.Id;
                }
            }
            //изменения в локалном массиве
            var user = new User
            {
                Id = maxId + 1,
                FirstName = firstName,
                LastName = lastName,
                Birthdate = birthdate,
                Age = age,
                Awards = awards
            };
            _users.Add(user);

            //добавление пользователя в таблицу users
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("EXEC AddUser @FirstName, @LastName, @Bithdate", connection))
            {
                connection.Open();
                command.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = firstName;
                command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = lastName;
                command.Parameters.Add("Bithdate", SqlDbType.Date).Value = birthdate;
                command.ExecuteNonQuery();
            }

            int NewUserId = maxId + 1;
            //добавление наград конкретному пользователю
            foreach (var element in awards)
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("EXEC AddAwardForUser @UserId, @Title", connection))
                {
                    connection.Open();

                    command.Parameters.Add("UserId", SqlDbType.Int).Value = NewUserId;
                    command.Parameters.Add("Title", SqlDbType.NVarChar).Value = element;
                    command.ExecuteNonQuery();
                }
            }

        }

        public int CountUser()
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Select COUNT(*) From Users", connection))
            {
                connection.Open();

                int rezult = (int)command.ExecuteScalar();
                return rezult;
            }
        }

        public void DeleteAwardFromUser(string currentAward)
        {
            foreach (var item in _users)
            {
                item.Awards.Remove(currentAward);
            }
        }


        public void DeleteUser(User currentUser)
        {
            //изменения в локалном массиве
            _users.Remove(currentUser);
/*            for (int i = currentUser.Id - 1; i < _users.Count; i++)
            {
                _users[i].Id--;
            }*/
            //удаление записей из смежной таблицы
            /*            using (var connection = new SqlConnection(_connectionString))
                        using (var command = new SqlCommand("DELETE FROM [ConnectionUserAndAward] Where UserId = @UserId", connection))
                        {
                            connection.Open();

                            command.Parameters.Add("UserId", SqlDbType.Int).Value = currentUser.Id;
                            command.ExecuteNonQuery();
                        }*/
            //удаление записей из таблицы user
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("EXEC DeleteUser @UserId", connection))
            {
                connection.Open();

                command.Parameters.Add("UserId", SqlDbType.Int).Value = currentUser.Id;
                command.ExecuteNonQuery();
            }
        }

        public void EditAwardFromUser(string changedName, string title)
        {
            foreach (var item in _users)
            {
                if (item.Awards.IndexOf(changedName) != -1)
                {
                    item.Awards.Remove(changedName);
                    item.Awards.Add(title);
                }
            }
        }

        public void EditUser(int id, string firstName, string lastName, DateTime birthdate, int age, List<string> awards)
        {
            //изменения в локалном массиве
            int localId = id;
            _users[localId - 1].FirstName = firstName;
            _users[localId - 1].LastName = lastName;
            _users[localId - 1].Birthdate = birthdate;
            _users[localId - 1].Age = age;
            _users[localId - 1].Awards = awards;

            //изменение пользователя в таблице user
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("EXEC EditUser @UserId, @FirstName, @LastName, @Bithdate ", connection))
            {
                connection.Open();

                command.Parameters.Add("UserId", SqlDbType.Int).Value = id;
                command.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = firstName;
                command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = lastName;
                command.Parameters.Add("Bithdate", SqlDbType.Date).Value = birthdate;
                command.ExecuteNonQuery();
            }

            //удаление записей из смежной таблицы
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("DELETE FROM [ConnectionUserAndAward] Where UserId = @UserId", connection))
            {
                connection.Open();

                command.Parameters.Add("UserId", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }

            //добавление наград конкретному пользователю
            foreach (var element in awards)
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("EXEC AddAwardForUser @UserId, @Title", connection))
                {
                    connection.Open();

                    command.Parameters.Add("UserId", SqlDbType.Int).Value = id;
                    command.Parameters.Add("Title", SqlDbType.NVarChar).Value = element;
                    command.ExecuteNonQuery();
                }
            }

        }

        public IEnumerable<User> GetAll()
        {
            //var users = new List<User>();
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Select* From [Users]", connection))
            {
                _users.Clear();
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var user = new User
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Birthdate = reader.GetDateTime(3),
                        Age = DateTime.Now.Year - reader.GetDateTime(3).Year
                    };
                    _users.Add(user);
                }

            }
            //цикл для добавления наград пользователю
            foreach (var element in _users)
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("EXEC GettingAllRewards @UserId", connection))
                {
                    connection.Open();
                    command.Parameters.Add("UserId", SqlDbType.Int).Value = element.Id;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        element.Awards.Add(reader.GetString(0));
                    }
                }
            }
            return _users;
        }


        public void GetNewAward(int id, int award)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("EXECUTE AddAwardForUserById @UserId, @AwardId", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("UserId", id);
                    command.Parameters.AddWithValue("AwardId", award);
                    //connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
