using System.Collections.Generic;
using System.Data;
using DataLayer.Database;
using DataLayer.Interfaces;
using DataLayer.Items;
using System;

namespace DataLayer.DbTables
{
    public class DbSoutez : ISoutez
    {
        protected string SqlSelect
               => "Select id_souteze,nazev,kdy,startovne,adresa_id_adresy,organizator_id_organizatora from soutez";

        protected string SqlInsert
            => "Insert into soutez (nazev,kdy,startovne,adresa_id_adresy,organizator_id_organizatora)" +
               " values (@nazev, @kdy, @startovne,@adresa_id_adresy,@organizator_id_organizatora)";

        protected string SqlUpdate
            => "Update soutez set nazev = @nazev, kdy = @kdy, startovne = @startovne" +
            "adresa_id_adresy = @adresa_id_adresy, organizator_id_organizatora = @organizator_id_organizatora where id_souteze = @id_souteze";
        protected string SqlDelete
            => "delete from soutez where id_souteze = @id_souteze";
        private static string SqlSelectId
            =>"Select id_souteze, nazev, kdy, startovne, adresa_id_adresy,organizator_id_organizatora from soutez" +
            " where id_souteze = @id_souteze";
        public IEnumerable<Soutez> SelectArray()
        {
            List<Soutez> Souteze = new List<Soutez>();

            using (var table = TableData.Querry(SqlSelect))
            {
                foreach (DataRow tablerow in table.Rows)
                {
                    Soutez sout = new Soutez();

                    sout.ID_Souteze = int.Parse(tablerow[0].ToString());
                    sout.Nazev = tablerow[1].ToString();
                    sout.Kdy = DateTime.Parse(tablerow[2].ToString());
                    sout.Startovne = int.Parse(tablerow[3].ToString());
                    sout.Adresa_ID_Adresy = int.Parse(tablerow[4].ToString());
                    sout.Organizator_ID_Organizatora = int.Parse(tablerow[5].ToString());
                    Souteze.Add(sout);
                }
            }
            return Souteze;
        }
        public Soutez SelectId(int id)
        {
            Soutez a = null;
            var args = new Dictionary<string, string>
            {
                {"@id_souteze", id.ToString() }
            };
            using (var table = TableData.Querry(SqlSelectId, args))
            {
                if (table.Rows.Count != 0)
                {
                    a = new Soutez
                    {
                        ID_Souteze = (int)table.Rows[0]["id_klubu"],
                        Nazev = (string)table.Rows[0]["nazev"],
                        Kdy = DateTime.Parse(table.Rows[0]["kdy"].ToString()),
                        Startovne = (int)table.Rows[0]["startovne"],
                        Adresa_ID_Adresy = (int)table.Rows[0]["adresa_id_adresy"],
                        Organizator_ID_Organizatora = (int)table.Rows[0]["organizator_id_organizatora"],
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
