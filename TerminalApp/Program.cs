using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DataLayer.AbstractClasses;
//using DataLayer.Persist;
using DataLayer.Database;


namespace TerminalApp
{
    class Program
    {
        public static void ConnectDB()
        {
            const string sqlCon = @"data source = localhost\SQLEXPRESS; initial catalog = master; integrated security = SSPI";
            var db = new Databaze(sqlCon);
            DbPersist.Instance.Db = db;
        }
        static void Main(string[] args)
        {
            ConnectDB();
            var mainScreen = new Login();
            mainScreen.LoginToDb();
        }
    }
}
