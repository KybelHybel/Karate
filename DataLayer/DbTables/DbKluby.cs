using System.Collections.Generic;
using System.Data;
using DataLayer.Database;
using DataLayer.Interfaces;
using DataLayer.Items;

namespace DataLayer.DbTables
{
    public class DbKluby : IKluby
    {
        protected string SqlSelect
            => "Select id_klubu, nazev, email,adresa_id_adresy,trener_id_trenera from klub";
        protected string SqlInsert
            => "Insert into klub (nazev, email,adresa_id_adresy,trener_id_trenera)" +
               " values (@nazev, @email,@adresa_id_adresy,@trener_id_trenera)";
        protected string SqlUpdate
            => "Update klub set nazev = @nazev, email = @email,adresa_id_adresy =@adresa_id_adresy, trener_id_trenera = @trener_id_trenera" +
            " where id_klubu = id_klubu";
        protected string SqlDelete
            => "delete from klub where id_klubu = id_klubu";
        private static string SqlSelectId
            => "SELECT id_klubu, nazev, email,adresa_id_adresy,trener_id_trenera FROM klub WHERE id_klubu = @id_klubu";
        public IEnumerable<Kluby> VyberVsechnyKluby()
        {
            List<Kluby> kluby = new List<Kluby>();

            using (var table = TableData.Querry(SqlSelect))
            {
                foreach (DataRow column in table.Rows)
                {
                    Kluby _kluby = new Kluby
                    {
                        ID_Klubu = int.Parse(column[0].ToString()),
                        Nazev = column[1].ToString(),
                        Email = column[2].ToString(),
                        Adresa_ID_Adresy = int.Parse(column[3].ToString()),
                        Trener_ID_Trenera = int.Parse(column[4].ToString())
                    };

                    kluby.Add(_kluby);
                }
            }

            return kluby;
        }
        public Kluby SelectId(int id)
        {
            Kluby a = null;
            var args = new Dictionary<string, string>
            {
                {"@id_klubu", id.ToString() }
            };
            using (var table = TableData.Querry(SqlSelectId, args))
            {
                if (table.Rows.Count != 0)
                {
                    a = new Kluby
                    {
                        ID_Klubu = (int)table.Rows[0]["id_klubu"],
                        Nazev = (string)table.Rows[0]["nazev"],
                        Email = (string)table.Rows[0]["email"],
                        Adresa_ID_Adresy = (int)table.Rows[0]["adresa_id_adresy"],
                        Trener_ID_Trenera = (int)table.Rows[0]["trener_id_trenera"],
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
