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
    class InventarRepository
    {
        private static InventarRepository instance = null;

        private InventarRepository()
        {
        }

        public static InventarRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InventarRepository();
                }
                return instance;
            }
        }

        public List<Inventar> GetSavInventar()
        {
            List<Inventar> inventar = new List<Inventar>();

            if (File.Exists("inventar.xml"))
            {
                FileStream fileReader = new FileStream("inventar.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Inventar[]));
                Inventar[] savInventar = (Inventar[])serializer.Deserialize(fileReader);
                for (int i = 0; i < savInventar.Length; i++)
                    inventar.Add(savInventar[i]);

                fileReader.Close();
            }
            return inventar;

        }

        public void SetSavInventar(List<Inventar> inventar)
        {
            Inventar[] savInventar = inventar.ToArray();
            FileStream fileWriter = new FileStream("inventar.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Inventar[]));

            serializer.Serialize(fileWriter, savInventar);
            fileWriter.Close();
        }
    }
}
