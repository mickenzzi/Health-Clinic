using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bolnica.Repository
{
    class SobeRepository
    {

        private static SobeRepository instance = null;

        private SobeRepository()
        {
        }

        public static SobeRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SobeRepository();
                }
                return instance;
            }
        }

        public List<Soba> GetSveSobe()
        {
            List<Soba> sobe = new List<Soba>();

            if (File.Exists("sobe.xml"))
            {
                FileStream fileReader = new FileStream("sobe.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Soba[]));
                Soba[] sveSobe = (Soba[])serializer.Deserialize(fileReader);
                for (int i = 0; i < sveSobe.Length; i++)
                    sobe.Add(sveSobe[i]);

                fileReader.Close();
            }

            return sobe;
        }

        public void SetSveSobe(List<Soba> sobe)
        {
            Soba[] sveSobe = sobe.ToArray();
            FileStream fileWriter = new FileStream("sobe.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Soba[]));

            serializerPisanje.Serialize(fileWriter, sveSobe);
            fileWriter.Close();
        }
    }


}
