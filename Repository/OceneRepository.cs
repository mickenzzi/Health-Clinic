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
    class OceneRepository
    {
        private static OceneRepository instance = null;

        private OceneRepository()
        {
        }

        public static OceneRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OceneRepository();
                }
                return instance;
            }
        }

        public List<Ocena> GetSveOcene()
        {
            List<Ocena> ocene = new List<Ocena>();

            if (File.Exists("ocene.xml"))
            {
                FileStream fileReader = new FileStream("ocene.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Ocena[]));
                Ocena[] sveOcene = (Ocena[])serializer.Deserialize(fileReader);

                for (int i = 0; i < sveOcene.Length; i++)
                    ocene.Add(sveOcene[i]);

                fileReader.Close();
            }
            return ocene;
        }

        public void SetSveOcene(List<Ocena> ocene)
        {
            Ocena[] sveOcene = ocene.ToArray();
            FileStream fileWriter = new FileStream("ocene.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Ocena[]));

            serializer.Serialize(fileWriter, sveOcene);
            fileWriter.Close();
        }

        
    }
}
