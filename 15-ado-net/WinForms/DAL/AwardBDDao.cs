using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Interfaces;
using System.Data;

namespace DAL
{
    public class AwardBDDao : IAwardDao
    {
        private readonly List<Award> _awards = new List<Award>();

        private readonly string _connectionString;

        public AwardBDDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<Award> GetAll()
        {
            //var awards = new List<Award>();
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Select* From [Award]", connection))
            {
                _awards.Clear();
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var award = new Award
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Description = reader.GetString(2)
                    };
                    _awards.Add(award);
                }
            }
            return _awards;
        }

        public void AddAward(string title, string description)
        {
            //изменения на локалном массиве
            var award = new Award
            {
                Id = _awards.Count + 1,
                Title = title,
                Description = description
            };
            _awards.Add(award);

            //добавление награды в бд
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("EXEC AddAward @Title, @Description", connection))
            {
                connection.Open();

                command.Parameters.Add("Title", SqlDbType.NVarChar).Value = title;
                command.Parameters.Add("Description", SqlDbType.NVarChar).Value = description;
                command.ExecuteNonQuery();
            }

        }

        public void EditAward(int id, string title, string description)
        {
            //изменения в локалном массиве
            int localId = id;
            _awards[localId - 1].Title = title;
            _awards[localId - 1].Description = description;

            //изменение награды в бд
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("EXEC EditAward @AwardId, @Title, @Description ", connection))
            {
                connection.Open();

                command.Parameters.Add("AwardId", SqlDbType.Int).Value = id;
                command.Parameters.Add("Title", SqlDbType.NVarChar).Value = title;
                command.Parameters.Add("Description", SqlDbType.NVarChar).Value = description;
                command.ExecuteNonQuery();
            }
        }


        public void DeleteAward(Award currentAward)
        {
            //изменения в локалном массиве
            _awards.Remove(currentAward);
            for (int i = currentAward.Id - 1; i < _awards.Count; i++)
            {
                _awards[i].Id--;
            }

            //удаление награды из бд
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("EXEC DeleteAward @AwardId", connection))
            {
                connection.Open();

                command.Parameters.Add("AwardId", SqlDbType.Int).Value = currentAward.Id;
                command.ExecuteNonQuery();
            }
        }


        public int CountAward()
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Select COUNT(*) From Award", connection))
            {
                connection.Open();

                int rezult = (int)command.ExecuteScalar();
                return rezult;
            }
        }


    }
}
