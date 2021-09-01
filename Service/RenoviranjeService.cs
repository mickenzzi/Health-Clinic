using Bolnica.Model;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bolnica.Service
{
    class RenoviranjeService
    {
        private static RenoviranjeService instance = null;

        private RenoviranjeService()
        {
        }

        public static RenoviranjeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RenoviranjeService();
                }
                return instance;
            }
        }

        public List<Renoviranje> GetSvaRenoviranja()
        {
            return RenoviranjaRepository.Instance.GetSvaRenoviranja();
        }
        public void SetSvaRenoviranja(List<Renoviranje> renoviranja)
        {
            RenoviranjaRepository.Instance.SetSvaRenoviranja(renoviranja);
        }

        public bool DodajRenoviranje(Renoviranje renoviranje)
        {
            List<Renoviranje> renoviranja = GetSvaRenoviranja();
            renoviranja.Add(renoviranje);
            SetSvaRenoviranja(renoviranja);
            return true;
        }

        public void ZakaziRenoviranje(Soba soba, DateTime pocetakRenoviranja, DateTime zavrsetakRenoviranja)
        {
            List<Termin> sviTermini = TerminiService.Instance.GetSveTermine();

            foreach (Termin t in sviTermini)
            {
                if (t.Slobodan == false && t.SifraSobe == soba.Sifra
                    && t.DatumVreme.CompareTo(pocetakRenoviranja) > 0
                    && t.DatumVreme.CompareTo(zavrsetakRenoviranja) < 0)
                {
                    MessageBox.Show("Postoje zakazani pregledi u izabranom vremenskom intervalu!");
                    return;
                }
            }
            List<Renoviranje> renoviranja = RenoviranjaRepository.Instance.GetSvaRenoviranja();

            foreach(Renoviranje r in renoviranja)
            {
                if(r.SifraSobe == soba.Sifra && r.DatumPocetka.CompareTo(DateTime.Now) > 0)
                {
                    MessageBox.Show("Vec postoji zakazano renoviranje za izabranu sobu!");
                    return;
                }
            }
            Renoviranje renoviranje = new Renoviranje(soba.Sifra, pocetakRenoviranja, zavrsetakRenoviranja);

            DodajRenoviranje(renoviranje);

        }
    }
}

