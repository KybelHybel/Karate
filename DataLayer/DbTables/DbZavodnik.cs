using System.Collections.Generic;
using System.Data;
using DataLayer.Database;
using DataLayer.Interfaces;
using DataLayer.Items;
using System;

namespace DataLayer.DbTables
{
    public class DbZavodnik : IZavodnik
    {
        protected string SqlInsert
            => "Insert into zavodnik (jmeno, prijmeni,pohlavi, datum_narozeni,zeme,klub_id_klubu)" +
               " values (@jmeno, @prijmeni,@pohlavi @datum_narozeni,@zeme,@klub_id_klubu)";
        protected string SqlUpdate
            => "Update zavodnik set jmeno = @jmeno, prijmeni = @prijmeni,pohlavi =@pohlavi, datum_narozeni = @datum_narozeni" +
            " zeme = @zeme, klub_id_klubu = @klub_id_klubu where id_zavodnika = id_zavodnika";

        protected string SqlDelete
            => "delete from zavodnik where id_zavodnika = id_zavodnika";

        private static string SqlSelectZavodnik
            => "SELECT id_zavodnika, jmeno, prijmeni,pohlavi, datum_narozeni,zeme,klub_id_klubu FROM zavodnik " +
               "WHERE klub_id_klubu = @klub_id_klubu";
        private static string SqlSelectId
            => "SELECT id_zavodnika, jmeno, prijmeni,pohlavi, datum_narozeni,zeme,klub_id_klubu FROM zavodnik " +
               "WHERE id_zavodnika = @id_zavodnika";
        public IEnumerable<Zavodnik> SelectArray(int id)
        {
            var args = new Dictionary<string, string>
            {
                {"@klub_id_klubu", id.ToString() }
            };

            List<Zavodnik> zavodnici = new List<Zavodnik>();

            using (var table = TableData.Querry(SqlSelectZavodnik, args))
            {
                foreach (DataRow column in table.Rows)
                {
                    Zavodnik _Zavodnik = new Zavodnik
                    {
                        ID_Zavodnika = int.Parse(column[0].ToString()),
                        Jmeno = column[1].ToString(),
                        Prijmeni = column[2].ToString(),
                        Pohlavi = column[3].ToString(),
                        Datum_narozeni = DateTime.Parse(column[4].ToString()),
                        Zeme = column[5].ToString(),
                        Klub_ID_Klubu = int.Parse(column[0].ToString()),
                    };

                    zavodnici.Add(_Zavodnik);

                }
            }
            return zavodnici;
        }
        public Zavodnik SelectId(int id)
        {
            Zavodnik a = null;
            var args = new Dictionary<string, string>
            {
                {"@id_zavodnika", id.ToString() }
            };
            using (var table = TableData.Querry(SqlSelectId, args))
            {
                if (table.Rows.Count != 0)
                {
                    a = new Zavodnik
                    {
                        ID_Zavodnika = (int)table.Rows[0]["id_zavodnika"],
                        Jmeno = (string)table.Rows[0]["jemno"],
                        Prijmeni = (string)table.Rows[0]["prijmeni"],
                        Pohlavi = (string)table.Rows[0]["pohlavi"],
                        Datum_narozeni = DateTime.Parse(table.Rows[0]["datum_narozeni"].ToString()),
                        Zeme = (string)table.Rows[0]["pohlavi"],
                        Klub_ID_Klubu = (int)table.Rows[0]["klub_id_klubu"],
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
