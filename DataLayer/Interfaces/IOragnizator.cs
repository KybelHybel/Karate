using System.Collections.Generic;
using DataLayer.Items;

namespace DataLayer.Interfaces
{
    public interface IOragnizator
    {
        Organizator SelectHeslo(string prijmeni, string heslo);
        IEnumerable<Organizator> SelectArray();
        int Insert(ITableItem item);
        int Update(ITableItem item);
        int Delete(ITableItem item);
    }
}
