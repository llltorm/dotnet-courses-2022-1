using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IAwardBL
    {
        IList<Award> GetAll();

        void AddAward(string title, string description);

        void EditAward(int id, string title, string description);

        void DeleteAward(Award currentAward);

        int CountAward();
    }
}
