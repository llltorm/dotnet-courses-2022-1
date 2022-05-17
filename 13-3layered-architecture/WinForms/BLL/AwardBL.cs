using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entities;
using Interfaces;

namespace BLL
{
    public class AwardBL : IAwardBL
    {

        private IAwardDao _awardDao;

        public AwardBL(IAwardDao awardDao)
        {
            _awardDao = awardDao;
        }



        public IList<Award> GetAll()
        {
            return _awardDao.GetAll();
        }

        public void AddAward(string title, string description)
        {
            _awardDao.AddAward(title, description);
        }

        public void EditAward(int id, string title, string description)
        {
            _awardDao.EditAward(id, title, description);
        }

        public void DeleteAward(Award currentAward)
        {
            _awardDao.DeleteAward(currentAward);
        }

        public int CountAward()
        {
            return _awardDao.CountAward();
        }
    }
}
