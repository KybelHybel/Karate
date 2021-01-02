using System.Collections.Generic;
using DataLayer.Interfaces;
using System;

namespace DataLayer.Items
{
    public class Zavodnik : ITableItem
    {
        public int ID_Zavodnika { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Pohlavi { get; set; }
        public DateTime Datum_narozeni { get; set; }
        public string Zeme { get; set; }
        public int Pocet_Medaili { get; set; }
        public int Klub_ID_Klubu { get; set; }
        public virtual Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>
            {
                {"@id_zavodnika",  ID_Zavodnika.ToString()},
                {"@jmeno", Jmeno},
                {"@prijmeni", Prijmeni},
                {"@pohlavi", Pohlavi},
                {"@datum_narozeni", Datum_narozeni.ToString("yyyy-MM-dd")},
                {"@zeme", Zeme},
                {"@pocet_medaili",  Pocet_Medaili.ToString()},
                {"@klub_id_klubu",  Klub_ID_Klubu.ToString()},
            };
        }
    }
}
