using System;
using System.Collections.Generic;
using DataLayer.Interfaces;

namespace DataLayer.Items
{
    public class Organizator : ITableItem
    {
        public int ID_organizatora { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Heslo { get; set; }
        public DateTime Datum_narozeni { get; set; }
        public virtual Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>
            {
                {"@id_organizatora", ID_organizatora.ToString()},
                {"@jmeno", Jmeno},
                {"@prijmeni", Prijmeni},
                {"@datum_narozeni", Datum_narozeni.ToString("yyyy-MM-dd")},
                {"@heslo", Heslo},
            };
        }
        public override string ToString()
        {
            return $"{Prijmeni}";
        }
    }
}
