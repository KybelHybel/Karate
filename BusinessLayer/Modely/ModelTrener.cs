using System;
namespace BusinessLayer.Modely
{
    public class ModelTrener
    {
        public int ID_Trenera { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Pohlavi { get; set; }
        public DateTime Datum_narozeni { get; set; }
    }
}
