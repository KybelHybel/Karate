using System.Collections.Generic;
using System.Data;
using DataLayer.Database;
using DataLayer.Interfaces;
using DataLayer.Items;
using System;

namespace DataLayer.DbTables
{
    public class DbTrener : ITrener
    {
        protected string SqlSelect
            => "Select id_trenera, jmeno, prijmeni,pohlavi, datum_narozeni from trener";

        protected string SqlInsert
            => "Insert into trener (jmeno, prijmeni,pohlavi,datum_narozeni,heslo)" +
               " values (@jmeno, @prijmeni,@pohlavi, @datum_narozeni,@heslo)";
        protected string SqlUpdate
            => "Update trener set jmeno = @jmeno, prijmeni = @prijmeni,pohlavi =@pohlavi, datum_narozeni = @datum_narozeni" +
            " where id_trenera = @id_trenera";

        protected string SqlDelete
            => "delete from trener where id_trenera = @id_trenera";

        private static string SqlSelectLogin
            => "Select id_trenera, jmeno, prijmeni, datum_narozeni from trener" +
            " where prijmeni = @prijmeni and heslo = @heslo";

        private static string SqlSelectId
            => "SELECT id_trenera, jmeno, prijmeni,pohlavi, datum_narozeni FROM trener WHERE id_trenera = @id_trenera";
        public Trener SelectHeslo(string prijmeni, string heslo)
        {
            Trener r = null;
            var args = new Dictionary<string, string>
            {
                { "@prijmeni", prijmeni },
                { "@heslo", heslo }
            };

            using (var table = TableData.Querry(SqlSelectLogin, args))
            {
                if (table.Rows.Count != 0)
                {
                    r = new Trener
                    {
                        ID_Trenera = (int)table.Rows[0]["id_trenera"],
                        Jmeno = (string)table.Rows[0]["jmeno"],
                        Prijmeni = (string)table.Rows[0]["prijmeni"],
                        Datum_narozeni = DateTime.Parse(table.Rows[0]["datum_narozeni"].ToString())
                    };
                }
            }
            return r;
        }
        
        public Trener SelectId(int id)
        {
            Trener a = null;
            var args = new Dictionary<string, string>
            {
                {"@id_trenera", id.ToString() }
            };
            using (var table = TableData.Querry(SqlSelectId, args))
            {
                if (table.Rows.Count != 0)
                {
                    a = new Trener
                    {
                        ID_Trenera = (int)table.Rows[0]["id_trenera"],
                        Jmeno = (string)table.Rows[0]["jmeno"],
                        Prijmeni = (string)table.Rows[0]["prijmeni"],
                        Pohlavi = (string)table.Rows[0]["pohlavi"],
                        Datum_narozeni = DateTime.Parse(table.Rows[0]["datum_narozeni"].ToString()),

                    };
                }
            }
            return a;
        }

        public IEnumerable<Trener> SelectArray()
        {
            List<Trener> Treneri = new List<Trener>();

            using (var table = TableData.Querry(SqlSelect))
            {
                foreach (DataRow tablerow in table.Rows)
                {
                    Trener tre = new Trener();

                    tre.ID_Trenera = int.Parse(tablerow[0].ToString());
                    tre.Jmeno = tablerow[1].ToString();
                    tre.Prijmeni = tablerow[2].ToString();
                    tre.Pohlavi = tablerow[3].ToString();
                    tre.Datum_narozeni = DateTime.Parse(tablerow[4].ToString());

                    Treneri.Add(tre);
                }
            }
            return Treneri;
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
