using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Items;

namespace BusinessLayer.DomainController
{
    public class ZavodnikDomain
    {
        private IZavodnik _izavodnik;

        public ZavodnikDomain(IZavodnik izavodnik)
        {
            _izavodnik = izavodnik;
        }
        public void InsertZavodnik(Zavodnik zavodnik)
        {
            if (zavodnik.ID_Zavodnika == 0)
            {
                _izavodnik.Insert(zavodnik);
            }
            else
            {
                _izavodnik.Update(zavodnik);
            }
        }
        public void DeleteZavodnik(Zavodnik zavodnik)
        {
            if (zavodnik.ID_Zavodnika != 0)
            {
                _izavodnik.Delete(zavodnik);
            }
        }
        public List<Zavodnik> SelectArray(int id)
        {
            return _izavodnik.SelectArray(id).ToList();
        }
        public Zavodnik SelectId(int id)
        {
            return _izavodnik.SelectId(id);
        }
    }
}
