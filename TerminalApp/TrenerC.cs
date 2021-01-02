using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DataLayer.Persist;
//using BusinessLayer.Items;
//using BusinessLayer.Table;
namespace TerminalApp
{
    class TrenerC
    {
        public void Print()
        {
            Console.Clear();
            IEnumerable<Trener> treneri = TrenerSingleton.Instance.SelectArray(DbPersist.Instance.Db);
            foreach (var t in treneri)
            {
                Console.WriteLine(t);
            }
            Console.ReadKey();
        }
    }
}
