using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using System.Xml.Serialization;
using System.IO;

namespace Bolnica.Repository
{
    class ZdravstveniKartoniRepository
    {
        private static ZdravstveniKartoniRepository instance = null;

        private ZdravstveniKartoniRepository()
        {
        }

        public static ZdravstveniKartoniRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZdravstveniKartoniRepository();
                }
                return instance;
            }
        }

        public void SetSveKartone(List<ZdravstveniKarton> zdravstveniKartoni)
        {
            ZdravstveniKarton[] sviKartoni = zdravstveniKartoni.ToArray();
            FileStream fileWriter = new FileStream("kartoni.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(ZdravstveniKarton[]));

            serializerPisanje.Serialize(fileWriter, sviKartoni);
            fileWriter.Close();
        }

        
        public List<ZdravstveniKarton> GetSveKartone()
        {
            List<ZdravstveniKarton> zdravstveniKartoni = new List<ZdravstveniKarton>();

            if (File.Exists("kartoni.xml"))
            {
                FileStream fileReader = new FileStream("kartoni.xml", FileMode.Open);
                XmlSerializer serializerCitanje = new XmlSerializer(typeof(ZdravstveniKarton[]));
                ZdravstveniKarton[] sviUcitaniKartoni = (ZdravstveniKarton[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < sviUcitaniKartoni.Length; i++)
                    zdravstveniKartoni.Add(sviUcitaniKartoni[i]);

                fileReader.Close();
            }

            return zdravstveniKartoni;
        }
    }
}
