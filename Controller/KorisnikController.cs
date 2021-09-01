using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.Controller
{
    class KorisnikController
    {
        private static KorisnikController instance = null;

        private KorisnikController()
        {
        }

        public static KorisnikController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KorisnikController();
                }
                return instance;
            }
        }

        public List<Korisnik> GetSviKorisnici()
        {
            return KorisnikService.Instance.GetSviKorisnici();
        }

        public void SetSveKorisnike(List<Korisnik> korisnici)
        {
            KorisnikService.Instance.SetSveKorisnike(korisnici);
        }

        public bool AddKorisnik(string ime,string prezime,string jmbg,string email,string sifra)
        {
            Korisnik korisnik = new Korisnik(ime, prezime, jmbg, email, sifra);
            return KorisnikService.Instance.AddKorisnik(korisnik);
        }
        
        public string GetLozinka(string jmbg) 
        {
            return KorisnikService.Instance.GetLozinka(jmbg);
        }

        public bool SetKorisnik(Korisnik korisnik) 
        {
            return KorisnikService.Instance.SetKorisnik(korisnik);
        }
        public Korisnik GetKorisnik(string jmbg) 
        {
            return KorisnikService.Instance.GetKorisnik(jmbg);
        }
    }
}
