using System.Collections.Generic;
using Bolnica.Model;
using System.Xml.Serialization;
using System.IO;
using System;

namespace Bolnica.Repository
{
    class LekariRepository
    {

        private static LekariRepository instance = null;

        private LekariRepository()
        {
        }

        public static LekariRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LekariRepository();
                }
                return instance;
            }
        }

        public List<Lekar> GetSveLekare()
        {
            List<Lekar> lekari = new List<Lekar>();

            if (File.Exists("lekari.xml"))
            {
                FileStream fileReader = new FileStream("lekari.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Lekar[]));
                Lekar[] sviLekari = (Lekar[])serializer.Deserialize(fileReader);
                for (int i = 0; i < sviLekari.Length; i++)
                    lekari.Add(sviLekari[i]);
               
                fileReader.Close();
            }
            return lekari;
        }

        public void SetSveLekare(List<Lekar> lekari)
        {
            Lekar[] sviLekari = lekari.ToArray();
            FileStream fileWriter = new FileStream("lekari.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Lekar[]));

            serializer.Serialize(fileWriter, sviLekari);
            fileWriter.Close();
        }

    }
}
