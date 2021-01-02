using System.Collections.Generic;
using DataLayer.Items;

namespace DataLayer.Interfaces
{
    public interface ITrener
    {
        Trener SelectHeslo(string prijmeni, string heslo);
        IEnumerable<Trener> SelectArray();
        Trener SelectId(int id);
        int Insert(ITableItem item);
        int Update(ITableItem item);
        int Delete(ITableItem item);
    }
}
