using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Items;
namespace DataLayer.Interfaces
{
    public interface IAdresa
    {
        Adresa SelectId(int id);
        int Insert(ITableItem item);
        int Update(ITableItem item);
        int Delete(ITableItem item);
    }
}
