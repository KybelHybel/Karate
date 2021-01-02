using System.Collections.Generic;
using DataLayer.Items;

namespace DataLayer.Interfaces
{
    public interface ISoutez
    {
        IEnumerable<Soutez> SelectArray();
        Soutez SelectId(int id);
        int Insert(ITableItem item);
        int Update(ITableItem item);
        int Delete(ITableItem item);
    }
}
