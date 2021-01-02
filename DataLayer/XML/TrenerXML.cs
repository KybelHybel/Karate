using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using DataLayer.Interfaces;
using DataLayer.Items;

namespace DataLayer.XML
{
    public class TrenerXML : ITrener
    {
        private static void SerializeToXml<T>(T obj, string fileName)
        {
            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                var ser = new XmlSerializer(typeof(T));
                ser.Serialize(fileStream, obj);
            }
        }
        public static string GetContentOfXML(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }
            string content;
            content = File.ReadAllText(path);
            return content;
        }
        public static T DeserializeFromXml<T>(string xml) where T : class
        {
            if (xml == null) return null;
            T result;
            var ser = new XmlSerializer(typeof(T));
            using (var tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }
        public Trener SelectHeslo(string prijmeni, string heslo)
        {
            List<Trener> treneri = DeserializeFromXml<List<Trener>>(GetContentOfXML("trener.xml"));
            foreach (var tren in treneri)
            {
                if (tren.Prijmeni == prijmeni && tren.Heslo == heslo) return tren;
            }
            return null;
        }
        public IEnumerable<Trener> SelectArray()
        {
            List<Trener> treneri = DeserializeFromXml<List<Trener>>(GetContentOfXML("trener.xml"));
            treneri = treneri.ToList();
            return treneri;
        }
        public Trener SelectId(int id) {
            List<Trener> treneri = DeserializeFromXml<List<Trener>>(GetContentOfXML("trener.xml"));
            foreach (var tren in treneri)
            {
                if (tren.ID_Trenera == id) return tren;
            }
            return null;
        }
        public int Insert(ITableItem item)
        {
            Trener tren = (Trener)item;
            List<Trener> treneri;
            List<Trener> temp = DeserializeFromXml<List<Trener>>(GetContentOfXML("trener.xml"));
            treneri = temp ?? new List<Trener>();
            int id;
            if (treneri.Count > 0)
            {
                id = treneri.Last().ID_Trenera + 1;
            }
            else id = 1;
            tren.ID_Trenera = id;
            treneri.Add(tren);
            SerializeToXml(treneri, "hraci.xml");
            return 0;
        }
        public int Update(ITableItem item)
        {
            Trener tren = (Trener)item;
            List<Trener> treneri;
            List<Trener> temp = DeserializeFromXml<List<Trener>>(GetContentOfXML("trener.xml"));
            treneri = temp ?? new List<Trener>();
            for (int i = 0; i < treneri.Count; i++)
            {
                if (treneri[i].ID_Trenera == tren.ID_Trenera) treneri.RemoveAt(i);
            }
            treneri.Add(tren);
            treneri = treneri.OrderBy(x => x.ID_Trenera).ToList();
            SerializeToXml(treneri, "trener.xml");
            return 0;
        }

        public int Delete(ITableItem item)
        {
            throw new System.NotImplementedException();
        }

    }
}
