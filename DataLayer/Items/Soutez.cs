using System;
using System.Collections.Generic;
using DataLayer.Interfaces;

namespace DataLayer.Items
{
    public class Soutez : ITableItem
    {
        public int ID_Souteze { get; set; }
        public string Nazev { get; set; }
        public DateTime Kdy { get; set; }
        public int Startovne { get; set; }
        public int Adresa_ID_Adresy { get; set; }
        public int Organizator_ID_Organizatora { get; set; }
        public virtual Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>
            {
                {"@id_souteze",  ID_Souteze.ToString()},
                {"@nazev", Nazev},
                {"@kdy", Kdy.ToString("yyyy-MM-dd")},
                {"@startovne",  Startovne.ToString()},
                {"@adresa_id_adresy",  Adresa_ID_Adresy.ToString()},
                {"@organizator_id_organizatora",  Organizator_ID_Organizatora.ToString()},
            };
        }
    }
}
