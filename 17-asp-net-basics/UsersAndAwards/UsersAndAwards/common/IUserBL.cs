using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IUserBL
    {

        IEnumerable<User> GetAll();

        void AddUser(string firstName, string lastName, DateTime birthdate, int age, List<string> awards);

        int CountUser();

        void EditUser(int id, string firstName, string lastName, DateTime birthdate, int age, List<string> awards);

        void DeleteUser(User currentUser);

        void GetNewAward(int id, int award);

        void EditAwardFromUser(string changedName, string title); //метод для изменения награды у пользователя, если такая награда была изменена в списке наград

        void DeleteAwardFromUser(string currentAward); //метод для удаления награды у пользователя, если такая награда была удалена из списка наград
    }
}
