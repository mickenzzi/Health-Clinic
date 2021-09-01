using System.Collections.Generic;
using Bolnica.Model;
using System.Xml.Serialization;
using System.IO;



namespace Bolnica.Repository
{
    class ObavestenjaRepository
    {
        private static ObavestenjaRepository instance = null;

        private ObavestenjaRepository()
        {
        }

        public static ObavestenjaRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObavestenjaRepository();
                }
                return instance;
            }
        }


        public List<Obavestenje> GetSvaObavestenja()
        {
            List<Obavestenje> obavestenja = new List<Obavestenje>();
            List<Obavestenje> odgObavestenja = new List<Obavestenje>();

            if (File.Exists("obavestenja.xml"))
            {
                FileStream fileReader = new FileStream("obavestenja.xml", FileMode.Open);

                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Obavestenje[]));

                Obavestenje[] svaUcitanaObavestenja = (Obavestenje[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < svaUcitanaObavestenja.Length; i++)
                {
                    obavestenja.Add(svaUcitanaObavestenja[i]);
                }

                fileReader.Close();
            }
            foreach (Obavestenje o in obavestenja)
            {
                if (o.IdPacijenta == 0 && o.ObavestenPacijent==false)
                {
                    odgObavestenja.Add(o);
                }
            }

            return odgObavestenja;
        }

        public List<Obavestenje> GetObavestenjaPacijenta(int idPacijenta) 
        {
            List<Obavestenje> obavestenja = new List<Obavestenje>();
            List<Obavestenje> odgObavestenja = new List<Obavestenje>();

            if (File.Exists("obavestenja.xml"))
            {
                FileStream fileReader = new FileStream("obavestenja.xml", FileMode.Open);

                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Obavestenje[]));

                Obavestenje[] svaUcitanaObavestenja = (Obavestenje[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < svaUcitanaObavestenja.Length; i++)
                {
                    obavestenja.Add(svaUcitanaObavestenja[i]);
                }

                fileReader.Close();
            }
            foreach (Obavestenje o in obavestenja)
            {
                if (o.IdPacijenta == idPacijenta && o.ObavestenPacijent == true)
                {
                    odgObavestenja.Add(o);
                }
            }

            return odgObavestenja;
        }
        public bool AddObavestenje(Obavestenje obavestenje)
        {
            List<Obavestenje> obavestenja = new List<Obavestenje>();

            if (File.Exists("obavestenja.xml"))
            {
                FileStream fileReader = new FileStream("obavestenja.xml", FileMode.Open);

                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Obavestenje[]));

                Obavestenje[] svaUcitanaObavestenja = (Obavestenje[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < svaUcitanaObavestenja.Length; i++)
                {
                    obavestenja.Add(svaUcitanaObavestenja[i]);
                }

                fileReader.Close();
            }


            foreach (Obavestenje o in obavestenja)
            {
                if (o.Id==obavestenje.Id)
                {
                    return false;
                }
            }
            obavestenja.Add(obavestenje);

            Obavestenje[] svaObavestenja = obavestenja.ToArray();
            FileStream fileWriter = new FileStream("obavestenja.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Obavestenje[]));

            serializerPisanje.Serialize(fileWriter, svaObavestenja);
            fileWriter.Close();

            return true;
        }


        public bool SetObavestenje(Obavestenje obavestenje)
        {
            List<Obavestenje> obavestenja = new List<Obavestenje>();
            if (File.Exists("obavestenja.xml"))
            {
                FileStream fileReader = new FileStream("obavestenja.xml", FileMode.Open);

                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Obavestenje[]));

                Obavestenje[] svaUcitanaObavestenja = (Obavestenje[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < svaUcitanaObavestenja.Length; i++)
                {
                    obavestenja.Add(svaUcitanaObavestenja[i]);
                }

                fileReader.Close();
            }
            foreach (Obavestenje o in obavestenja)
            {
                if (o.Id == obavestenje.Id)
                {
                    o.Poruka = obavestenje.Poruka;
                    o.IdPacijenta = obavestenje.IdPacijenta;
                }
            }


            Obavestenje[] svaObavestenja = obavestenja.ToArray();
            FileStream fileWriter = new FileStream("obavestenja.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Obavestenje[]));

            serializerPisanje.Serialize(fileWriter, svaObavestenja);
            fileWriter.Close();

            return true;
        }


        public void RemoveObavestenje(Obavestenje obavestenje)
        {
            List<Obavestenje> obavestenja = new List<Obavestenje>();

            if (File.Exists("obavestenja.xml"))
            {
                FileStream fileReader = new FileStream("obavestenja.xml", FileMode.Open);
                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Obavestenje[]));
                Obavestenje[] svaUcitanaObavestenja = (Obavestenje[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < svaUcitanaObavestenja.Length; i++)
                    obavestenja.Add(svaUcitanaObavestenja[i]);

                fileReader.Close();
            }
            for (int i = 0; i < obavestenja.Count; i++)
            {
                if (obavestenja[i].Id == obavestenje.Id)
                {
                    obavestenja.RemoveAt(i);
                }
            }

            Obavestenje[] svaObavestenja = obavestenja.ToArray();
            FileStream fileWriter = new FileStream("obavestenja.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Obavestenje[]));

            serializerPisanje.Serialize(fileWriter, svaObavestenja);
            fileWriter.Close();
        }
    }
}
