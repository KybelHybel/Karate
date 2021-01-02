using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Modely;
using DataLayer.Interfaces;
using DataLayer.Items;

namespace BusinessLayer.DomainController
{
    public class AdresaDomain
    {
        private IAdresa _iadresa;

        public AdresaDomain(IAdresa ikluby)
        {
            _iadresa = ikluby;
        }
        public void InsertAdresa(Adresa adresa)
        {
            if (adresa.ID_Adresy == 0)
            {
                _iadresa.Insert(adresa);
            }
            else
            {
                _iadresa.Update(adresa);
            }
        }
        public void DeleteAdresa(Adresa adresa)
        {
            if (adresa.ID_Adresy != 0)
            {
                _iadresa.Delete(adresa);
            }
        }
        public Adresa SelectId(int id)
        {
            return _iadresa.SelectId(id);
        }

    }
}
