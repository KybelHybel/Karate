using System;
using System.Collections.Generic;
using DataLayer.Interfaces;

namespace DataLayer.Items
{
    public class Trener : ITableItem
    {
        public int ID_Trenera { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Pohlavi { get; set; }
        public DateTime Datum_narozeni { get; set; }
        public string Heslo { get; set; }
        public virtual Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>
            {
                {"@id_trenera",  ID_Trenera.ToString()},
                {"@jmeno", Jmeno},
                {"@prijmeni", Prijmeni},
                {"@pohlavi", Pohlavi},
                {"@datum_narozeni", Datum_narozeni.ToString("yyyy-MM-dd")},
                {"@heslo", Heslo},
            };
        }
        public override string ToString()
        {
            return $"{ID_Trenera} - {Jmeno} - {Prijmeni } - {Pohlavi}  - {Datum_narozeni}";
        }
    }
}
