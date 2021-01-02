using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Items;

namespace BusinessLayer.DomainController
{
    public class OrganizatorDomain
    {
        private IOragnizator _ioragnizator;

        public OrganizatorDomain(IOragnizator ioragnizator) {
            _ioragnizator = ioragnizator;
        }
        public bool GetLogin(string prijmeni, string heslo)
        {
            Organizator z = _ioragnizator.SelectHeslo(prijmeni, heslo);
            if (z == null)
            {
                return false;
            }

            return true;
        }
        public void InsertOrganizator(Organizator organizator)
        {
            if (organizator.ID_organizatora == 0)
            {
                _ioragnizator.Insert(organizator);
            }
            else
            {
                _ioragnizator.Update(organizator);
            }
        }

        public void DeleteOrganizator(Organizator organizator)
        {
            if (organizator.ID_organizatora != 0)
            {
                _ioragnizator.Delete(organizator);
            }
        }
        public List<Organizator> SelectArray()
        {
            return _ioragnizator.SelectArray().ToList();
        }
    }
}
