using System.Collections.Generic;
using Bolnica.Model;
using System.Xml.Serialization;
using System.IO;
using System;

namespace Bolnica.Repository
{
    class KorisnikRepository
    {

        private static KorisnikRepository instance = null;

        private KorisnikRepository()
        {
        }

        public static KorisnikRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KorisnikRepository();
                }
                return instance;
            }
        }

        public void SetSveKorisnike(List<Korisnik> korisnici)
        {
            Korisnik[] sviKorisnici = korisnici.ToArray();
            FileStream fileWriter = new FileStream("korisnici.xml", FileMode.Create);
            XmlSerializer serializerPisanje = new XmlSerializer(typeof(Korisnik[]));

            serializerPisanje.Serialize(fileWriter, sviKorisnici);
            fileWriter.Close();
        }

        public List<Korisnik> GetSviKorisnici()
        {
            List<Korisnik> korisnici = new List<Korisnik>();

            if (File.Exists("korisnici.xml"))
            {
                FileStream fileReader = new FileStream("korisnici.xml", FileMode.Open);
                XmlSerializer serializerCitanje = new XmlSerializer(typeof(Korisnik[]));
                Korisnik[] sviUcitaniKorisnici = (Korisnik[])serializerCitanje.Deserialize(fileReader);

                for (int i = 0; i < sviUcitaniKorisnici.Length; i++)
                    korisnici.Add(sviUcitaniKorisnici[i]);
 
                fileReader.Close();
            }
            return korisnici;
        }


        
    }
}
