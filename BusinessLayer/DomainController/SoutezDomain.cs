using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Items;

namespace BusinessLayer.DomainController
{
    public class SoutezDomain
    {
        private ISoutez _isoutez;
        public SoutezDomain(ISoutez isoutez)
        {
            _isoutez = isoutez;
        }
        public void InsertSoutez(Soutez soutez)
        {
            if (soutez.ID_Souteze == 0)
            {
                _isoutez.Insert(soutez);
            }
            else
            {
                _isoutez.Update(soutez);
            }
        }

        public void DeleteSoutez(Soutez soutez)
        {
            if (soutez.ID_Souteze != 0)
            {
                _isoutez.Delete(soutez);
            }
        }
        public List<Soutez> SelectArray()
        {
            return _isoutez.SelectArray().ToList();
        }
        public Soutez SelectId(int id)
        {
            return _isoutez.SelectId(id);
        }
    }
}
