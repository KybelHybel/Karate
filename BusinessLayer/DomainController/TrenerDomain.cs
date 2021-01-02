using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Items;
using BusinessLayer.Modely;
namespace BusinessLayer.DomainController
{
    public class TrenerDomain
    {
        private ITrener _itrener;

        public TrenerDomain(ITrener itrener)
        {
            _itrener = itrener;
        }
        public bool GetLogin(string prijmeni, string heslo)
        {
            Trener z = _itrener.SelectHeslo(prijmeni, heslo);
            if (z == null)
            {
                return false;
            }

            return true;
        }
        public void InsertTrener(Trener trener)
        {
            if (trener.ID_Trenera == 0)
            {
                _itrener.Insert(trener);
            }
            else
            {
                _itrener.Update(trener);
            }
        }

        public void DeleteTrener(Trener trener)
        {
            if (trener.ID_Trenera != 0)
            {
                _itrener.Delete(trener);
            }
        }
        public List<ModelTrener>SelectArray()
        {
            List<Trener> treneri = new List<Trener>();
            List<ModelTrener> temp = new List<ModelTrener>();
            treneri = _itrener.SelectArray().ToList();
            temp = treneri.Select(o => new ModelTrener() { ID_Trenera = o.ID_Trenera, Jmeno = o.Jmeno, Prijmeni = o.Prijmeni , Pohlavi = o.Pohlavi, Datum_narozeni = o.Datum_narozeni}).ToList();
            return temp;
            //return _itrener.SelectArray().ToList();
        }
        public Trener SelectId(int id)
        {
            return _itrener.SelectId(id);
        }
    }
}
