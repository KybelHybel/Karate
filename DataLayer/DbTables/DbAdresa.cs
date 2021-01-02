using System.Collections.Generic;
using System.Data;
using DataLayer.Database;
using DataLayer.Interfaces;
using DataLayer.Items;

namespace DataLayer.DbTables
{
    public class DbAdresa : IAdresa
    {
        protected string SqlSelect
            => "Select id_adresy,zeme,mesto,ulice,cislo_popisne,psc from adresa";
        protected string SqlInsert
            => "Insert into adresa (zeme,mesto,ulice,cislo_popisne,psc)" +
               " values (@zeme, @mesto, @ulice,@cislo_popisne,@psc)";
        protected string SqlUpdate
            => "Update adresa set zeme = @zeme, mesto = @mesto, ulice = @ulice" +
            "cislo_popisne = @cislo_popisne, psc = @psc where id_adresy = @id_adresy";
        protected string SqlDelete
            => "delete from adresa where id_adresy = @id_adresy";
        private static string SqlSelectId
            => "Select id_adresy,zeme,mesto,ulice,cislo_popisne,psc from adresa where id_adresy = @id_adresy";

        public Adresa SelectId(int id)
        {
            Adresa a = null;
            var args = new Dictionary<string, string>
            {
                {"@id_adresy", id.ToString() }
            };
            using (var table = TableData.Querry(SqlSelectId, args))
            {
                if (table.Rows.Count != 0)
                {
                    a = new Adresa
                    {
                        ID_Adresy = (int)table.Rows[0]["id_adresy"],
                        Zeme = (string)table.Rows[0]["zeme"],
                        Mesto = (string)table.Rows[0]["mesto"],
                        Ulice = (string)table.Rows[0]["ulice"],
                        Cislo_Popisne = (int)table.Rows[0]["cislo_popisne"],
                        PSC = (int)table.Rows[0]["psc"],
                    };
                }
            }
            return a;
        }
        public int Insert(ITableItem item)
        {
            return TableData.NonQuerry(SqlInsert, item.GetArgs());
        }

        public int Update(ITableItem item)
        {
            return TableData.NonQuerry(SqlUpdate, item.GetArgs());
        }

        public int Delete(ITableItem item)
        {
            return TableData.NonQuerry(SqlDelete, item.GetArgs());
        }
    }
}
