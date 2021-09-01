using Bolnica.Controller;
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
    class InventarService
    {

        private static InventarService instance = null;

        private InventarService()
        {
        }

        public static InventarService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InventarService();
                }
                return instance;
            }
        }

        public List<Inventar> GetSavInventar()
        {
            return InventarRepository.Instance.GetSavInventar();
        }

        public void SetSavInventar(List<Inventar> inventar)
        {
            InventarRepository.Instance.SetSavInventar(inventar);
        }


        public void DodajInventar(Inventar inventar)
        {
            List<Inventar> savInventar = GetSavInventar();
            savInventar.Add(inventar);
            SetSavInventar(savInventar);
        }

        public List<Inventar> GetSveKrevete()
        {
            List<Inventar> inventar = GetSavInventar();
            List<Inventar> kreveti = new List<Inventar>();
            foreach (Inventar i in inventar)
                if (i.TipInventara == TipoviInventara.BolnickiKrevet)
                    kreveti.Add(i);
            return kreveti;
        }

        public void IzmeniInventar(Inventar stari, Inventar novi)
        {
            List<Inventar> inventar = GetSavInventar();
            foreach (Inventar i in inventar)
            {
                if (i.SifraSobe == stari.SifraSobe)
                {
                    i.Kolicina = novi.Kolicina;
                    i.TipInventara = novi.TipInventara;
                }
            }
            SetSavInventar(inventar);
        }

        public void IzmeniInventarKrevet(Inventar stari, Inventar novi)
        {
            List<Inventar> inventar = GetSavInventar();
            foreach (Inventar i in inventar)
            {
                if (i.Sifra == stari.Sifra)
                {
                    i.Zauzet = novi.Zauzet;
                    i.JmbgPacijenta = novi.JmbgPacijenta;
                }
            }
            SetSavInventar(inventar);
        }

        public Inventar GetInventarBySifra(int sifra)
        {
            List<Inventar> inventar = GetSavInventar();
            Inventar inventarReturn = new Inventar();
            foreach (Inventar i in inventar)
                if (i.Sifra == sifra)
                    inventarReturn = i;
            return inventarReturn;
        }


        public void ObrisiInventar(Inventar i)
        {
            Inventar obrisi = new Inventar();
            List<Inventar> savInventar = GetSavInventar();
            foreach (Inventar inventar in savInventar)
            {
                if (inventar.SifraSobe == i.SifraSobe && inventar.TipInventara == i.TipInventara)
                {
                    obrisi = inventar;
                    break;
                }
            }
            savInventar.Remove(obrisi);
            SetSavInventar(savInventar);
        }

        public bool DaLiJeKolicinaManjaOdRaspolozive(Inventar inventar, int kolicinaInventara)
        {
            if (kolicinaInventara > inventar.Kolicina)
            {
                MessageBox.Show("Kolicina ne sme biti veca od raspolozive!");
                return true;
            }
            return false;
        }

        public bool DaLiSePreklapaSaTerminom(DateTime vremePremestanja, Inventar inventar)
        {
            List<Termin> termini = TerminiController.Instance.GetSveTermine();
            foreach (Termin t in termini)
            {
                if (t.DatumVreme == vremePremestanja && inventar.SifraSobe == t.SifraSobe && t.Slobodan)
                {
                    MessageBox.Show("Izabrano vreme se preklapa sa nekim od termina!");
                    return true;
                }
            }
            return false;
        }

        public bool PremestiInventar(Inventar inventar, int brojSobe, int kolicinaInventara, DateTime vremePremestanja)
        {
            List<Inventar> savInventar = GetSavInventar();
            List<Soba> sveSobe = SobeRepository.Instance.GetSveSobe();

            if (InventarService.Instance.DaLiJeKolicinaManjaOdRaspolozive(inventar, kolicinaInventara))
            {
                return false;
            }

            if (InventarService.Instance.DaLiSePreklapaSaTerminom(vremePremestanja, inventar))
            {
                return false;
            }

            int sifraSobe = inventar.SifraSobe;

            if (kolicinaInventara == inventar.Kolicina)
            {
                PremestiSve(sveSobe, savInventar, sifraSobe, brojSobe, inventar);
                return true;
            }
            else
            {
                PremestiDeo(sveSobe, savInventar, brojSobe, sifraSobe, inventar, kolicinaInventara);
                return true;
            }
        }

        public bool PremestiSve(List<Soba> sveSobe, List<Inventar> savInventar, int sifraSobe, int brojSobe, Inventar inventar)
        {
            foreach (Soba s in sveSobe)
            {
                if (s.BrojSobe == brojSobe)
                {
                    sifraSobe = s.Sifra;
                }
            }
            foreach (Inventar i in savInventar)
            {
                if (inventar.SifraSobe == i.SifraSobe && inventar.TipInventara == i.TipInventara)
                {
                    i.SifraSobe = sifraSobe;
                }
            }

            SetSavInventar(savInventar);
            return true;
        }

        public bool PremestiDeo(List<Soba> sveSobe, List<Inventar> savInventar, int brojSobe, int sifraSobe, Inventar inventar, int kolicinaInventara)
        {
            Inventar preneti = new Inventar();

            foreach (Soba s in sveSobe)
            {
                if (s.BrojSobe == brojSobe)
                {
                    sifraSobe = s.Sifra;
                }
            }
            foreach (Inventar i in savInventar)
            {
                if (inventar.SifraSobe == i.SifraSobe && inventar.TipInventara == i.TipInventara)
                {
                    i.Kolicina -= kolicinaInventara;
                }
            }

            preneti.SifraSobe = sifraSobe;
            preneti.Kolicina = kolicinaInventara;
            preneti.TipInventara = inventar.TipInventara;

            savInventar.Add(preneti);
            SetSavInventar(savInventar);
            return true;
        }


    }
}
