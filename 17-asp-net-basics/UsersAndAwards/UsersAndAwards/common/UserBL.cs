using System;
using System.Collections.Generic;
using Entities;
using DAL;
using Interfaces;

namespace BLL
{
    public class UserBL : IUserBL
    {

        private IUserDAO _userDao;

        public UserBL(IUserDAO userDao)
        {
            _userDao = userDao;
        }


        public IEnumerable<User> GetAll()
        {
            return _userDao.GetAll();
        }

        public void AddUser(string firstName, string lastName, DateTime birthdate, int age, List<string> awards)
        {
            _userDao.AddUser(firstName, lastName, birthdate, age, awards);
        }

        public int CountUser()
        {
            return _userDao.CountUser();
        }

        public void EditUser(int id, string firstName, string lastName, DateTime birthdate, int age, List<string> awards)
        {
            _userDao.EditUser(id, firstName, lastName, birthdate, age, awards);
        }

        public void DeleteUser(User currentUser)
        {
            _userDao.DeleteUser(currentUser);
        }

        public void EditAwardFromUser(string changedName, string title) //метод для изменения награды у пользователя, если такая награда была изменена в списке наград
        {
            _userDao.EditAwardFromUser(changedName, title);
        }

        public void DeleteAwardFromUser(string currentAward) //метод для удаления награды у пользователя, если такая награда была удалена из списка наград
        {
            _userDao.DeleteAwardFromUser(currentAward);
        }

        public void GetNewAward(int id, int award)
        {
            _userDao.GetNewAward(id, award);
        }
    }
}
