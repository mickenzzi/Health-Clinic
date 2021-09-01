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
    class LekoviRepository
    {

        private static LekoviRepository instance = null;

        private LekoviRepository()
        {
        }

        public static LekoviRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LekoviRepository();
                }
                return instance;
            }
        }

        public List<Lek> GetSveLekove()
        {
            List<Lek> lekovi = new List<Lek>();

            if (File.Exists("lekovi.xml"))
            {
                FileStream fileReader = new FileStream("lekovi.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Lek[]));

                Lek[] sviLekovi = (Lek[])serializer.Deserialize(fileReader);
                for (int i = 0; i < sviLekovi.Length; i++)
                    lekovi.Add(sviLekovi[i]);

                fileReader.Close();
            }

            return lekovi;
        }

        public void SetSveLekove(List<Lek> lekovi)
        {
            Lek[] sviLekovi = lekovi.ToArray();
            FileStream fileWriter = new FileStream("lekovi.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Lek[]));

            serializer.Serialize(fileWriter, sviLekovi);
            fileWriter.Close();
        }


    }
}
