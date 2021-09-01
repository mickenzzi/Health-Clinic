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
    class KorisnikService
    {
        private static KorisnikService instance = null;

        private KorisnikService()
        {
        }

        public static KorisnikService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KorisnikService();
                }
                return instance;
            }
        }

        public List<Korisnik> GetSviKorisnici()
        {
            return KorisnikRepository.Instance.GetSviKorisnici();
        }

        public void SetSveKorisnike(List<Korisnik> korisnici)
        {
            KorisnikRepository.Instance.SetSveKorisnike(korisnici);
        }

        public bool AddKorisnik(Korisnik korisnik)
        {
            List<Korisnik> korisnici = GetSviKorisnici();


            foreach (Korisnik k in korisnici)
            {
                if (k.Jmbg == korisnik.Jmbg)
                {
                    return false;
                }
            }
            korisnici.Add(korisnik);
            SetSveKorisnike(korisnici);
            return true;
        }

        public String GetLozinka(string jmbg) 
        {
            string lozinka;
            lozinka = "0";
            List<Korisnik> korisnici = new List<Korisnik>();
            korisnici = KorisnikRepository.Instance.GetSviKorisnici();
            foreach(Korisnik k in korisnici) 
            {
                if (k.Jmbg == jmbg) 
                {
                    lozinka = k.Sifra;
                }
            }
            return lozinka;
        }

        public bool SetKorisnik(Korisnik korisnik)
        {
            List<Korisnik> korisnici = GetSviKorisnici();
            foreach (Korisnik k in korisnici)
                if (k.Jmbg == korisnik.Jmbg)
                {
                    k.Ime = korisnik.Ime;
                    k.Prezime = korisnik.Prezime;
                    k.Sifra = korisnik.Sifra;
                    k.Email = korisnik.Email;

                }
            SetSveKorisnike(korisnici);
            return true;
        }

        public Korisnik GetKorisnik(string jmbg) 
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            Korisnik korisnik = new Korisnik();
            korisnici = KorisnikRepository.Instance.GetSviKorisnici();
            foreach(Korisnik k in korisnici) 
            {
                if (k.Jmbg == jmbg) 
                {
                    korisnik = k;
                }
            }

            return korisnik;
        }
    }
}
