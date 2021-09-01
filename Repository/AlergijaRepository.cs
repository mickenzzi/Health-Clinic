using System.Collections.Generic;
using System.IO;
using Bolnica.Model;
using System.Xml.Serialization;

namespace Bolnica.Repository
{
    class AlergijaRepository
    {
        private static AlergijaRepository instance = null;

        private AlergijaRepository()
        {
        }

        public static AlergijaRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AlergijaRepository();
                }
                return instance;
            }
        }
        public List<Alergija> GetSveAlergije()
        {
            List<Alergija> alergije = new List<Alergija>();

            if (File.Exists("alergije.xml"))
            {
                FileStream fileReader = new FileStream("alergije.xml", FileMode.Open);
                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Alergija[]));
                Alergija[] sveUcitaneAlergije = (Alergija[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < sveUcitaneAlergije.Length; i++)
                    alergije.Add(sveUcitaneAlergije[i]);

                fileReader.Close();
            }

            return alergije;
        }

        public void SetSveAlergije(List<Alergija> alergije)
        {
            Alergija[] sveAlergije = alergije.ToArray();
            FileStream fileWriter = new FileStream("alergije.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Alergija[]));

            serializerPisanje.Serialize(fileWriter, sveAlergije);
            fileWriter.Close();
        }
    }
}
