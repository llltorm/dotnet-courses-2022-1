using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Entities;
using Interfaces;

namespace UsersAndAwards.Controllers
{
    public class AwardController : Controller
    {
        private IUserBL _userBll;
        //private IList<Award> _listAward;
        private IAwardBL _awardBL;
        private IEnumerable<Award> _listAward;

        public AwardController(IAwardBL awardBL)
        {
            //_userBll = userBll;
            _awardBL = awardBL;
            _listAward = _awardBL.GetAll();
        }
        public IActionResult Index()
        {
            _listAward = _awardBL.GetAll();
            return View(_listAward);
        }

        [HttpGet]
        public IActionResult AddAward()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAward(string title, string desc)
        {
            _awardBL.AddAward(title, desc);
            _listAward = _awardBL.GetAll();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAward(int id)
        {
            var currentAward = new Award();
            foreach (var elem in _listAward)
            {
                if (elem.Id == id)
                {
                    currentAward = elem;
                }
            }
            _awardBL.DeleteAward(currentAward);
            //_listAward.FirstOrDefault(u => u.Id == id);
            _listAward = _awardBL.GetAll();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAward(int id)
        {
            return View(_listAward.FirstOrDefault(u => u.Id == id));
        }

        [HttpPost]
        public IActionResult EditAward(Award award)
        {
            if(!ModelState.IsValid)
            {
                return View(award);
            }
            //Award award = new Award(ID, title, desc);
            _awardBL.EditAward(award.Id, award.Title, award.Description);
            _listAward = _awardBL.GetAll();
            return RedirectToAction("Index");
        }
    }
}
