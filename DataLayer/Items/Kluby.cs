using System.Collections.Generic;
using DataLayer.Interfaces;

namespace DataLayer.Items
{
    public class Kluby : ITableItem
    {
        public int ID_Klubu { get; set; }
        public string Nazev { get; set; }
        public string Email { get; set; }
        public int Pocet_Zavodniku { get; set; }
        public int Pocet_Medaili { get; set; }
        public int Adresa_ID_Adresy { get; set; }
        public int Trener_ID_Trenera { get; set; }
        public virtual Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>
            {
                {"@id_klubu",  ID_Klubu.ToString()},
                {"@nazev", Nazev},
                {"@email", Email},
                {"@pocet_zavodniku",  Pocet_Zavodniku.ToString()},
                {"@pocet_medaili",  Pocet_Medaili.ToString()},
                {"@adresa_id_adresy",  Adresa_ID_Adresy.ToString()},
                {"@trener_id_trenera",  Trener_ID_Trenera.ToString()},
            };
        }
    }
}
