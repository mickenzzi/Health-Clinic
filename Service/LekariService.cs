using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Repository;
using System.Xml.Serialization;

namespace Bolnica.Service
{
    class LekariService
    {
        private static LekariService instance = null;

        private LekariService()
        {
        }

        public static LekariService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LekariService();
                }
                return instance;
            }
        }
        public List<Lekar> GetSveLekare()
        {
            return LekariRepository.Instance.GetSveLekare();
        }

        public void SetSveLekare(List<Lekar> lekari)
        {
            LekariRepository.Instance.SetSveLekare(lekari);
        }

        public bool AddLekar(Lekar lekar)
        {
            List<Lekar> lekari = GetSveLekare();

            foreach (Lekar l in lekari)
            {
                if (l.Ime == lekar.Ime && l.Prezime == lekar.Prezime)
                {
                    return false;
                }
            }
            lekari.Add(lekar);
            SetSveLekare(lekari);
            return true;
        }

        public bool SetLekar(Lekar lekar)
        {
            List<Lekar> lekari = GetSveLekare();
            foreach (Lekar l in lekari)
            {
                if (l.Id == lekar.Id)
                {
                    l.Jmbg = lekar.Jmbg;
                    l.Ime = lekar.Ime;
                    l.Prezime = lekar.Prezime;
                    l.DatumRodjenja = lekar.DatumRodjenja;
                    l.MestoRodjenja = lekar.MestoRodjenja;
                    l.Specijalista = lekar.Specijalista;
                    l.Specijalizacija = lekar.Specijalizacija;
                    l.DatumPocetkaOdmora = lekar.DatumPocetkaOdmora;
                    l.DatumKrajaOdmora = lekar.DatumKrajaOdmora;
                    l.PocetakRadnogVremena = lekar.PocetakRadnogVremena;
                    l.KrajRadnogVremena = lekar.KrajRadnogVremena;


                }
            }
            SetSveLekare(lekari);
            return true;
        }

        public void RemoveLekar(Lekar lekar)
        {
            List<Lekar> lekari = GetSveLekare();
            for (int i = 0; i < lekari.Count; i++)
                if (lekari[i].Id == lekar.Id)
                    lekari.RemoveAt(i);

            SetSveLekare(lekari);
        }

        public Lekar GetOdgLekar(int id) 
        {
            Lekar lekar = new Lekar();
            List<Lekar> lekari = new List<Lekar>();
            lekari = LekariRepository.Instance.GetSveLekare();
            foreach(Lekar l in lekari) 
            {
                if (l.Id == id) 
                {
                    lekar = l;
                }
            }
            return lekar;
        }

        public Lekar GetOdgLekarByJmbg(string jmbg)
        {
            List<Lekar> lekari = GetSveLekare();
            Lekar lekar = new Lekar();

            foreach (Lekar l in lekari)
                if (l.Jmbg == jmbg)
                    lekar = l;

            return lekar;
        }



    }
}
