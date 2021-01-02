using System.Collections.Generic;
using System.Data;
using DataLayer.Database;
using DataLayer.Interfaces;
using DataLayer.Items;
using System;

namespace DataLayer.DbTables
{
    public class DbOragnizator : IOragnizator
    {
        protected string SqlSelect
            => "Select id_organizatora, jmeno, prijmeni, datum_narozeni from organizator";

        protected string SqlInsert
           => "Insert into organizator (jmeno, prijmeni, datum_narozeni,heslo)" +
              " values (@jmeno, @prijmeni, @datum_narozeni,@heslo)";

        protected string SqlUpdate
            => "Update organizator set jmeno = @jmeno, prijmeni = @prijmeni, datum_narozeni = @datum_narozeni heslo = @heslo where id_organizatora = @id_organizatora";

        protected string SqlDelete
            => "delete from organizator where id_organizatora = @id_organizatora";

        private static string SqlSelectLogin
            => "Select ID_Organizatora, Jmeno, Prijmeni, Datum_narozeni from Organizator where Prijmeni = @prijmeni and Heslo = @heslo";

        public Organizator SelectHeslo(string prijmeni, string heslo)
        {
            Organizator r = null;
            var args = new Dictionary<string, string>
            {
                { "@prijmeni", prijmeni },
                { "@heslo", heslo }
            };

            using (var table = TableData.Querry(SqlSelectLogin, args))
            {
                if (table.Rows.Count != 0)
                {
                    r = new Organizator
                    {
                        ID_organizatora = (int)table.Rows[0]["ID_Organizatora"],
                        Jmeno = (string)table.Rows[0]["jmeno"],
                        Prijmeni = (string)table.Rows[0]["prijmeni"],
                        Datum_narozeni = DateTime.Parse(table.Rows[0]["datum_narozeni"].ToString())
                    };
                }
            }
            return r;
        }
        public IEnumerable<Organizator> SelectArray()
        {
            List<Organizator> Organizatori = new List<Organizator>();

            using (var table = TableData.Querry(SqlSelect))
            {
                foreach (DataRow tablerow in table.Rows)
                {
                    Organizator orga = new Organizator();

                    orga.ID_organizatora = int.Parse(tablerow[0].ToString());
                    orga.Jmeno = tablerow[1].ToString();
                    orga.Prijmeni = tablerow[2].ToString();
                    orga.Datum_narozeni = DateTime.Parse(tablerow[3].ToString());

                    Organizatori.Add(orga);
                }
            }
            return Organizatori;
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
