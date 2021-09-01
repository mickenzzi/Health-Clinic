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
    class PacijentiRepository
    {
        private static PacijentiRepository instance = null;

        private PacijentiRepository()
        {
        }

        public static PacijentiRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PacijentiRepository();
                }
                return instance;
            }
        }


        public List<Pacijent> GetSvePacijente()
        {
            List<Pacijent> pacijenti = new List<Pacijent>();


            if (File.Exists("pacijenti.xml"))
            {
                FileStream fileReader = new FileStream("pacijenti.xml", FileMode.Open);

                XmlSerializer serializer = new XmlSerializer(typeof(Pacijent[]));

                Pacijent[] sviPacijenti = (Pacijent[])serializer.Deserialize(fileReader);
                for (int i = 0; i < sviPacijenti.Length; i++)
                {
                    pacijenti.Add(sviPacijenti[i]);
                }

                fileReader.Close();
            }


            return pacijenti;
        }

        public void setSvePacijente(List<Pacijent> pacijenti)
        {
            Pacijent[] sviPacijenti = pacijenti.ToArray();
            FileStream fileWriter = new FileStream("pacijenti.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Pacijent[]));

            serializer.Serialize(fileWriter, sviPacijenti);
            fileWriter.Close();
        }

      
        public void SetPacijent(Pacijent pacijent)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            if (File.Exists("pacijenti.xml"))
            {
                FileStream fileReader = new FileStream("pacijenti.xml", FileMode.Open);
                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Pacijent[]));
                Pacijent[] sviUcitaniPacijenti = (Pacijent[])serializerCitanje.Deserialize(fileReader);
                for (int i = 0; i < sviUcitaniPacijenti.Length; i++)
                    pacijenti.Add(sviUcitaniPacijenti[i]);

                fileReader.Close();
            }



            foreach (Pacijent p in pacijenti)
            {
                if (p.Jmbg == pacijent.Jmbg)
                {
                    p.Ime = pacijent.Ime;
                    p.Prezime = pacijent.Prezime;
                    p.HitanSlucaj = pacijent.HitanSlucaj;
                    p.IdZK = pacijent.IdZK;
                    p.recepti = pacijent.recepti;
                    p.ListaBolesti = pacijent.ListaBolesti;
                    p.ListaSifriBeleski = pacijent.ListaSifriBeleski;

                }
            }



            Pacijent[] sviPacijenti = pacijenti.ToArray();
            FileStream fileWriter = new FileStream("pacijenti.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Pacijent[]));

            serializerPisanje.Serialize(fileWriter, sviPacijenti);
            fileWriter.Close();
        }


        public void RemovePacijent(Pacijent pacijent) 
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            if (File.Exists("pacijenti.xml"))
            {
                FileStream fileReader = new FileStream("pacijenti.xml", FileMode.Open);

                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Pacijent[]));

                Pacijent[] sviUcitaniPacijenti = (Pacijent[])serializerCitanje.Deserialize(fileReader);
                for (int i = 0; i < sviUcitaniPacijenti.Length; i++)
                {
                    pacijenti.Add(sviUcitaniPacijenti[i]);
                }

                fileReader.Close();
            }

            for (int i = 0; i < pacijenti.Count; i++)
            {
                if (pacijenti[i].Id == pacijent.Id)
                {
                    pacijenti.RemoveAt(i);
                }
            }
            Pacijent[] sviPacijenti = pacijenti.ToArray();
            FileStream fileWriter = new FileStream("pacijenti.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Pacijent[]));

            serializerPisanje.Serialize(fileWriter, sviPacijenti);
            fileWriter.Close();
        }

        public bool AddPacijent(Pacijent pacijent)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            if (File.Exists("pacijenti.xml"))
            {
                FileStream fileReader = new FileStream("pacijenti.xml", FileMode.Open);

                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Pacijent[]));

                Pacijent[] sviUcitaniPacijenti = (Pacijent[])serializerCitanje.Deserialize(fileReader);
                for (int i = 0; i < sviUcitaniPacijenti.Length; i++)
                {
                    pacijenti.Add(sviUcitaniPacijenti[i]);
                }

                fileReader.Close();
            }

            foreach (Pacijent p in pacijenti)
            {
                if (p.Id==pacijent.Id)
                {
                    return false;
                }
            }
            pacijenti.Add(pacijent);

            Pacijent[] sviPacijenti = pacijenti.ToArray();
            FileStream fileWriter = new FileStream("pacijenti.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Pacijent[]));

            serializerPisanje.Serialize(fileWriter, sviPacijenti);
            fileWriter.Close();

            return true;
        }

    }
}
