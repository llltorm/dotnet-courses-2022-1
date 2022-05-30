using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

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
            /*            var connectionStringBuilder = new SqlConnectionStringBuilder
                        {
                            DataSource = @"DESKTOP-9O36UAB\SQLEXPRESS",
                            InitialCatalog = "UsersAndAwards",
                            IntegratedSecurity = true
                        };*/
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appConfig.json");
            var config = configurationBuilder.Build();
            var connectionString = config["ConnectionStrings"];
            //var daoUser = new UserListDao();
            //var daoUser = new UserBDDao(connectionStringBuilder.ToString());
            var daoUser = new UserBDDao(connectionString);
            var logicUser = new UserBL(daoUser);
            //var daoAward = new AwardBDDao(connectionStringBuilder.ToString());
            var daoAward = new AwardBDDao(connectionString);
            var logicAward = new AwardBL(daoAward);
            //var connectionString = @"Server=DESKTOP-9O36UAB\SQLEXPRESS;Database=UsersAndAwards;Trusted_Connection=True";
            Application.Run(new MainForm(logicUser, logicAward));
        }
    }
}
