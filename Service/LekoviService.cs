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
    class LekoviService
    {
        private static LekoviService instance = null;

        private LekoviService()
        {
        }

        public static LekoviService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LekoviService();
                }
                return instance;
            }
        }

        public List<Lek> GetSveLekove()
        {
            return LekoviRepository.Instance.GetSveLekove();
        }
        public void SetSveLekove(List<Lek> lekovi)
        {
            LekoviRepository.Instance.SetSveLekove(lekovi);
        }

        public bool DodajLek(Lek lek)
        {
            List<Lek> sviLekovi = LekoviRepository.Instance.GetSveLekove();
            foreach (Lek l in sviLekovi)
            {
                if (lek.Naziv == l.Naziv && lek.Doza == l.Doza)
                {
                    MessageBox.Show("Lek vec postoji!");
                    return false;
                }
            }
            sviLekovi.Add(lek);
            LekoviRepository.Instance.SetSveLekove(sviLekovi);
            return true;
        }

        public void IzmeniLek(Lek stari, Lek novi)
        {
            List<Lek> lekovi = LekoviRepository.Instance.GetSveLekove();
            foreach (Lek l in lekovi)
            {
                if (l.Sifra == stari.Sifra)
                {
                    l.Kolicina = novi.Kolicina;
                    l.SifraSobe = novi.SifraSobe;
                    l.Naziv = novi.Naziv;
                    l.Odobren1 = novi.Odobren1;
                    l.Odobren2 = novi.Odobren2;
                    l.Izmena1 = novi.Izmena1;
                    l.Izmena2 = novi.Izmena2;
                    l.JmbgLekaraKojiJeIzmenio = novi.JmbgLekaraKojiJeIzmenio;
                    l.JmbgLekaraKojiJeOdobrio = novi.JmbgLekaraKojiJeOdobrio;
                    l.Zamena = novi.Zamena;
                    l.Sastojci = novi.Sastojci;
                    
                }
            }

            LekoviRepository.Instance.SetSveLekove(lekovi);
        }

        public void ObrisiLek(Lek lek)
        {
            Lek obrisi = new Lek();
            List<Lek> sviLekovi = LekoviRepository.Instance.GetSveLekove();
            foreach (Lek l in sviLekovi)
            {
                if (lek.SifraSobe == l.SifraSobe && lek.Sifra == l.Sifra)
                {
                    obrisi = l;
                    break;
                }
            }
            sviLekovi.Remove(obrisi);
            LekoviRepository.Instance.SetSveLekove(sviLekovi);
        }

        public Lek GetLekById(int id)
        {
            List<Lek> sviLekovi = GetSveLekove();
            if (sviLekovi == null)
                sviLekovi = new List<Lek>();

            Lek nadjenLek = new Lek();

            foreach (Lek l in sviLekovi)
            {
                if (l.Sifra == id)
                    nadjenLek = l;
            }

            return nadjenLek;
        }
    }
}
