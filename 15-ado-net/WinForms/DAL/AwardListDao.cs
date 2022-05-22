using System;
using System.Collections.Generic;
using Entities;
using Interfaces;

namespace DAL
{
    public class AwardListDao : IAwardDao
    {
        private readonly List<Award> _awards = new List<Award>
        {
            new Award { Id = 1, Title = "diploma for academic success" , Description = "for academic success"},
            new Award { Id = 2, Title = "diploma for sports competitions" , Description = "for sports competitions"},
            new Award { Id = 3, Title = "diploma for activity" , Description = "for activity"},
        };

        public IList<Award> GetAll()
        {
            return _awards;
        }

        public void AddAward(string title, string description)
        {
            var award = new Award
            {
                Id = _awards.Count + 1,
                Title = title,
                Description = description
            };
            _awards.Add(award);
        }

        public void EditAward(int id, string title, string description)
        {
            int localId = id;
            _awards[localId - 1].Title = title;
            _awards[localId - 1].Description = description;
        }

        public void DeleteAward(Award currentAward)
        {
            _awards.Remove(currentAward);
            for (int i = currentAward.Id - 1; i < _awards.Count; i++)
            {
                _awards[i].Id--;
            }
        }

        public int CountAward()
        {
            return _awards.Count;
        }
    }
}
