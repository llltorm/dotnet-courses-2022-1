using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace DAL
{
    public class UserListDao : IUserDao
    {

        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Aleksandr", LastName = "Petrov", Birthdate =  DateTime.Now.AddYears(-18), Age = 18},
            new User { Id = 2, FirstName = "Oleg", LastName = "Nikitov", Birthdate = DateTime.Now.AddYears(-13),  Age = 13},
            new User { Id = 3, FirstName = "Aleksey", LastName = "Machnev", Birthdate = DateTime.Now.AddYears(-15),  Age = 15},
            new User { Id = 4, FirstName = "Ekaterina", LastName = "Nikolaeva", Birthdate = DateTime.Now.AddYears(-17),  Age = 17}    //new DateTime(2002, 29, 08)},
        };

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void AddUser(string firstName, string lastName, DateTime birthdate, int age, List<string> awards)
        {
            var user = new User
            {
                Id = _users.Count + 1,
                FirstName = firstName,
                LastName = lastName,
                Birthdate = birthdate,
                Age = age,
                Awards = awards
            };
            _users.Add(user);
        }

        public int CountUser()
        {
            return _users.Count;
        }

        public void EditUser(int id, string firstName, string lastName, DateTime birthdate, int age, List<string> awards)
        {
            int localId = id;
            _users[localId - 1].FirstName = firstName;
            _users[localId - 1].LastName = lastName;
            _users[localId - 1].Birthdate = birthdate;
            _users[localId - 1].Age = age;
            _users[localId - 1].Awards = awards;
        }

        public void DeleteUser(User currentUser)
        {
            _users.Remove(currentUser);
            for (int i = currentUser.Id - 1; i < _users.Count; i++)
            {
                _users[i].Id--;
            }
        }
        public void EditAwardFromUser(string changedName, string title) //метод для изменения награды у пользователя, если такая награда была изменена в списке наград
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

        public void DeleteAwardFromUser(string currentAward) //метод для удаления награды у пользователя, если такая награда была удалена из списка наград
        {
            foreach (var item in _users)
            {
                item.Awards.Remove(currentAward);
            }
        }

    }
}
