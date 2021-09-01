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
    class BeleskePacijentRepository
    {
        private static BeleskePacijentRepository instance = null;

        private BeleskePacijentRepository()
        {
        }

        public static BeleskePacijentRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BeleskePacijentRepository();
                }
                return instance;
            }
        }

        public List<Beleska> GetSveBeleske()
        {
            List<Beleska> beleske = new List<Beleska>();

            if (File.Exists("beleske.xml"))
            {
                FileStream fileReader = new FileStream("beleske.xml", FileMode.Open);

                XmlSerializer serializer = new XmlSerializer(typeof(Beleska[]));

                Beleska[] sveBeleske = (Beleska[])serializer.Deserialize(fileReader);
                for (int i = 0; i < sveBeleske.Length; i++)
                {
                    beleske.Add(sveBeleske[i]);
                }
                fileReader.Close();
            }
            return beleske;
        }
        public void SetSveBeleske(List<Beleska> beleske)
        {
            Beleska[] sveBeleske = beleske.ToArray();
            FileStream fileWriter = new FileStream("beleske.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Beleska[]));

            serializer.Serialize(fileWriter, sveBeleske);
            fileWriter.Close();
        }
    }
}
