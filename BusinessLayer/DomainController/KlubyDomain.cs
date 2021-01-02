using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Items;

namespace BusinessLayer.DomainController
{
    public class KlubyDomain
    {
        private IKluby _ikluby;

        public KlubyDomain(IKluby ikluby)
        {
            _ikluby = ikluby;
        }
        public void InsertKluby(Kluby kluby)
        {
            if (kluby.ID_Klubu == 0)
            {
                _ikluby.Insert(kluby);
            }
            else
            {
                _ikluby.Update(kluby);
            }
        }
        public void DeleteKluby(Kluby kluby)
        {
            if (kluby.ID_Klubu != 0)
            {
                _ikluby.Delete(kluby);
            }
        }
        public List<Kluby> VyberVsechnyKluby()
        {
            return _ikluby.VyberVsechnyKluby().ToList();
        }
        public Kluby SelectId(int id)
        {
            return _ikluby.SelectId(id);
        }
    }
}
