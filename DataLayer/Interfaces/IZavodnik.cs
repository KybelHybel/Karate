using System.Collections.Generic;
using DataLayer.Items;

namespace DataLayer.Interfaces
{
    public interface IZavodnik
    {
        IEnumerable<Zavodnik> SelectArray(int id);
        Zavodnik SelectId(int id);
        int Insert(ITableItem item);
        int Update(ITableItem item);
        int Delete(ITableItem item);
    }
}
