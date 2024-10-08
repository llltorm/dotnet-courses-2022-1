using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLWinForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var daoUser = new UserListDao();
            var logicUser = new UserBL(daoUser);
            var daoAward = new AwardListDao();
            var logicAward = new AwardBL(daoAward);
            Application.Run(new MainForm(logicUser, logicAward));
        }
    }
}
