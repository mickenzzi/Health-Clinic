using System.IO;
using Bolnica.Model;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Bolnica.Repository
{ 
    public class BugRepository
    {
        private static BugRepository instance = null;
        private BugRepository()
        {
        }

        public static BugRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BugRepository();
                }
                return instance;
            }
        }

        public void SetSveBagove(List<Bug> bagovi)
        {
            Bug[] sviBagovi = bagovi.ToArray();
            FileStream fileWriter = new FileStream("bagovi.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Bug[]));

            serializerPisanje.Serialize(fileWriter, sviBagovi);
            fileWriter.Close();
        }

        public List<Bug> GetSveBagove()
        {
            List<Bug> bagovi = new List<Bug>();

            if (File.Exists("bagovi.xml"))
            {
                FileStream fileReader = new FileStream("bagovi.xml", FileMode.Open);
                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Bug[]));
                Bug[] sviUcitaniBagovi = (Bug[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < sviUcitaniBagovi.Length; i++)
                    bagovi.Add(sviUcitaniBagovi[i]);

                fileReader.Close();
            }

            return bagovi;
        }
    }
}
