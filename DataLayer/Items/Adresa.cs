using System.Collections.Generic;
using DataLayer.Interfaces;

namespace DataLayer.Items
{
    public class Adresa : ITableItem
    {
        public int ID_Adresy { get; set; }
        public string Zeme { get; set; }
        public string Mesto { get; set; }
        public string Ulice { get; set; }
        public int Cislo_Popisne { get; set; }
        public int PSC { get; set; }
        public virtual Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>
            {
                {"@id_trenera",  ID_Adresy.ToString()},
                {"@zeme",  Zeme},
                {"@mesto", Mesto},
                {"@ulice", Ulice},
                {"@cislo_popisne",  Cislo_Popisne.ToString()},
                {"@psc",  PSC.ToString()},
            };
        }
    }
}
