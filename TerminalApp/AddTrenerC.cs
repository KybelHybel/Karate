using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BusinessLayer.Table;
//using DataLayer.Persist;
//using BusinessLayer.Table;
//using BusinessLayer.Items;
//using DataLayer.Persist;
namespace TerminalApp
{
    class AddTrenerC
    {
        public void Add() 
        {
            Console.Write("Jmeno: ");
            string name = Console.ReadLine();     
            Console.Write("Prijmeni: ");
            string lastname = Console.ReadLine();
            Console.Write("Pohlavi: ");
            string p = Console.ReadLine();
            Console.Write("Datum narozeni: ");
            string bdate = Console.ReadLine();
            //string dateInput = "Jan 1, 2009";
            var pDate = DateTime.Parse(bdate);
            //Console.WriteLine(parsedDate);
            Console.Write("Heslo: ");
            string password = Console.ReadLine();
            Trener trener = new Trener
            {
                Jmeno = name,
                Prijmeni = lastname,
                Pohlavi = p,
                Datum_narozeni = pDate,
                Heslo = password,
            };
            TrenerSingleton.Instance.Insert(DbPersist.Instance.Db, trener);
            Console.WriteLine("Trener ulozen.");
            Console.ReadKey();
        }
    }
}
