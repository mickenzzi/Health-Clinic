using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bolnica.Repository
{
    class RenoviranjaRepository
    {

        private static RenoviranjaRepository instance = null;

        private RenoviranjaRepository()
        {
        }

        public static RenoviranjaRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RenoviranjaRepository();
                }
                return instance;
            }
        }

        public List<Renoviranje> GetSvaRenoviranja()
        {
            List<Renoviranje> renoviranja = new List<Renoviranje>();

            if (File.Exists("renoviranja.xml"))
            {
                FileStream fileReader = new FileStream("renoviranja.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Renoviranje[]));
                Renoviranje[] svaRenoviranja = (Renoviranje[])serializer.Deserialize(fileReader);
                for (int i = 0; i < svaRenoviranja.Length; i++)
                    renoviranja.Add(svaRenoviranja[i]);

                fileReader.Close();
            }
            return renoviranja;
        }

        public void SetSvaRenoviranja(List<Renoviranje> renoviranja)
        {
            Renoviranje[] svaRenoviranja = renoviranja.ToArray();
            FileStream fileWriter = new FileStream("renoviranja.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Renoviranje[]));

            serializerPisanje.Serialize(fileWriter, svaRenoviranja);
            fileWriter.Close();
        }

        

    }
}
