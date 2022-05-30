using Entities;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IAwardDAO
    {
        IList<Award> GetAll();

        void AddAward(string title, string description);

        void EditAward(int id, string title, string description);


        void DeleteAward(Award currentAward);


        int CountAward();

    }
}
