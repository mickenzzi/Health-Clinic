using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Service
{
    class AlergijaService
    {
        private static AlergijaService instance = null;

        private AlergijaService()
        {
        }

        public static AlergijaService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AlergijaService();
                }
                return instance;
            }
        }
        public List<Alergija> GetSveAlergije()
        {
            return AlergijaRepository.Instance.GetSveAlergije();
        }

        public void SetSveAlergije(List<Alergija> alergije)
        {
            AlergijaRepository.Instance.SetSveAlergije(alergije);
        }

 

        public bool AddAlergija(Alergija alergija)
        {
            List<Alergija> alergije = GetSveAlergije();

            foreach (Alergija a in alergije)
                if (a.Sifra == alergija.Sifra)
                    return false;

            alergije.Add(alergija);
            SetSveAlergije(alergije);
            return true;
        }

        public List<Alergija> GetSveAlergije(int idKartonaPacijenta)
        {

            List<Alergija> alergije = new List<Alergija>();
            alergije = AlergijaRepository.Instance.GetSveAlergije();
            List<Alergija> odgovarajuceAlergije = new List<Alergija>();
            foreach (Alergija a in alergije)
                if (a.IdKartonaPacijenta == idKartonaPacijenta)
                    odgovarajuceAlergije.Add(a);

            return odgovarajuceAlergije;
        }

        public Alergija GetOdgAlergija(int idAlergije)
        {
            List<Alergija> alergije = new List<Alergija>();
            alergije = AlergijaRepository.Instance.GetSveAlergije();
            Alergija alergija = new Alergija();
            foreach (Alergija a in alergije)
            {
                if (a.Sifra == idAlergije)
                {
                    alergija = a;
                }
            }
            return alergija;
        }

        public void RemoveAlergija(Alergija alergija)
        {
            List<Alergija> alergije = GetSveAlergije();

            for (int i = 0; i < alergije.Count; i++)
                if (alergije[i].Sifra == alergija.Sifra)
                    alergije.RemoveAt(i);

            SetSveAlergije(alergije);
        }

        public void SetAlergija(Alergija alergija)
        {
            List<Alergija> alergije = GetSveAlergije();

            foreach (Alergija a in alergije)
                if (a.Sifra == alergija.Sifra)
                {
                    a.Naziv = alergija.Naziv;
                    a.SifraAlergije = alergija.SifraAlergije;
                }
            SetSveAlergije(alergije);
        }
    }
}
