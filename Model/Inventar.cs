
using Bolnica.Controller;
using System;

namespace Bolnica.Model
{
    public class Inventar
    {
        private TipoviInventara tipInventara;
        private int kolicina;
        private int sifraSobe;
        private string jmbgPacijenta;  // dodato za krevete
        bool zauzet;
        private int sifra;
        private int redniBrojUSobi;

        public TipoviInventara TipInventara
        {
            get { return this.tipInventara; }
            set { this.tipInventara = value; }
        }

        public int Kolicina
        {
            get { return this.kolicina; }
            set { this.kolicina = value; }
        }

        public int SifraSobe
        {
            get { return this.sifraSobe; }
            set { this.sifraSobe = value; }
        }

        public int Sifra
        {
            get { return this.sifra; }
            set { this.sifra = value; }
        }

        public int RedniBrojUSobi
        {
            get { return this.redniBrojUSobi; }
            set { this.redniBrojUSobi = value; }
        }

        public string JmbgPacijenta
        {
            get { return this.jmbgPacijenta; }
            set { this.jmbgPacijenta = value; }
        }

        public bool Zauzet
        {
            get { return this.zauzet; }
            set { this.zauzet = value; }
        }

        public int BrojSobe
        {
            get { return SobeController.Instance.GetSobu(this.sifraSobe).BrojSobe; }
        }

        public Inventar()
        {
        }

        public Inventar(TipoviInventara tip, int kolicina, int sifraSobe)
       {
            this.tipInventara = tip;
            this.kolicina = kolicina;
            this.sifraSobe = sifraSobe;
       }

        public Inventar(TipoviInventara tip, int redniBroj, int sifraSobe, string jmbgP, bool z)
        {
            this.sifra = StaticRandom.Instance.Next() + 10;     //Pri kreiranju bolesnicke sobe, generisu se kreveti - sprecava da imaju istu random sifru
            this.tipInventara = tip;
            this.redniBrojUSobi = redniBroj;
            this.sifraSobe = sifraSobe;
            this.jmbgPacijenta = jmbgP;
            this.zauzet = z;
        }

        public override string ToString()
        {
            return TipInventara.ToString() + " " + redniBrojUSobi.ToString();
        }
    }
}