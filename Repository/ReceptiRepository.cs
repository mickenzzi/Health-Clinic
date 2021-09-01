using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Bolnica.Model;
using System.Xml.Serialization;

namespace Bolnica.Repository
{
    class ReceptiRepository
    {
        private static ReceptiRepository instance = null;

        private ReceptiRepository()
        {
        }

        public static ReceptiRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceptiRepository();
                }
                return instance;
            }
        }

        public List<Recept> GetSveRecepte()
        {
            List<Recept> recepti = new List<Recept>();

            if (File.Exists("recepti.xml"))
            {
                FileStream fileReader = new FileStream("recepti.xml", FileMode.Open);
                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Recept[]));
                Recept[] sviUcitaniRecepti = (Recept[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < sviUcitaniRecepti.Length; i++)
                    recepti.Add(sviUcitaniRecepti[i]);
                
                fileReader.Close();
            }

            List<Recept> odgRecept = new List<Recept>();
            foreach (Recept r in recepti)
                odgRecept.Add(r);

            return odgRecept;
        }

        public bool SetSveRecepte(List<Recept> ucitaniRecepti)
        {
            Recept[] sviRecepti = ucitaniRecepti.ToArray();
            FileStream fileWriter = new FileStream("recepti.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Recept[]));

            serializerPisanje.Serialize(fileWriter, sviRecepti);
            fileWriter.Close();

            return true;
        }
    }
}
