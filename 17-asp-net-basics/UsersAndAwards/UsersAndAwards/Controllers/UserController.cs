
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Entities;
using Interfaces;


namespace MVC.Controllers
{
    public class UserController : Controller
    {
        private IUserBL _userBll;
        private IAwardBL _awardBL;
        private IEnumerable<User> _listUser;
        private IEnumerable<Award> _listAward;
        private AllAwards allRewards = new AllAwards();

        public UserController(IUserBL userBll, IAwardBL awardBll)
        {
            _userBll = userBll;
            _awardBL = awardBll;
            _listUser = _userBll.GetAll();
            _listAward = _awardBL.GetAll();
            allRewards.awards = _awardBL.GetAll();
        }

        public IActionResult Index()
        {
            _listUser = _userBll.GetAll();
            return View(_listUser);
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            _listAward = _awardBL.GetAll();
            return View(_listAward);
        }

        [HttpPost]
        public IActionResult AddUser(string firstName, string lastName, DateTime birthdate, int age, List<string> awards)
        {
            _userBll.AddUser(firstName, lastName, birthdate, age, awards);
            _listUser = _userBll.GetAll();
            allRewards.awards = _awardBL.GetAll();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(int id)
        {
            var currentUser = new User();
            foreach (var elem in _listUser)
            {
                if (elem.Id == id)
                {
                    currentUser = elem;
                }
            }
            _userBll.DeleteUser(currentUser);
            _listUser = _userBll.GetAll();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            _listUser = _userBll.GetAll();
            return View( _listUser.FirstOrDefault(u => u.Id == id));

        }

        [HttpPost]
        public IActionResult EditUser(int ID, string name, string lastName, DateTime birthdate, int age, List<string> awards)
        {
            _userBll.EditUser(ID, name, lastName, birthdate, age, awards);
            _listUser = _userBll.GetAll();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult GetAward(int id)
        {
            AllAwards u = new AllAwards();
            u.awards = _awardBL.GetAll();
            u.id = id;
            return View(u);
        }

        [HttpPost]
        public IActionResult GetAward(int id, int award)
        {
            _userBll.GetNewAward(id, award);
            _listUser = _userBll.GetAll();
            return RedirectToAction("Index");
        }

    }
}
