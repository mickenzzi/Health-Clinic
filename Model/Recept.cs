using System;
using Bolnica.Controller;
using System.Collections.Generic;


namespace Bolnica.Model
{
   public class Recept
   {
        private String nazivZdravstveneUstanove = "Bolnica KT5";
        private DateTime datumIzdavanjaLeka;

        private int sifraLeka;
        private int kolicinaLeka;
        private String nacinUpotrebe;
        private int sifraRecepta;
        private String jmbgPacijenta;


        public String NazivZdravstveneUstanove
        {
            get { return this.nazivZdravstveneUstanove; }
            set { this.nazivZdravstveneUstanove = value; }
        }

        public DateTime DatumIzdavanjaLeka
        {
            get { return this.datumIzdavanjaLeka; }
            set { this.datumIzdavanjaLeka = value; }
        }
        public String NacinUpotrebe
        {
            get { return this.nacinUpotrebe; }
            set { this.nacinUpotrebe = value; }
        }

        public int SifraLeka
        {
            get { return this.sifraLeka; }
            set { this.sifraLeka = value; }
        }

        public int KolicinaLeka
        {
            get { return this.kolicinaLeka; }
            set { this.kolicinaLeka = value; }
        }

        public String JmbgPacijenta
        {
            get { return this.jmbgPacijenta; }
            set { this.jmbgPacijenta = value; }
        }

        public int SifraRecepta
        {
            get { return this.sifraRecepta; }
            set { this.sifraRecepta = value; }
        }

        public String LekDoza
        {
            get
            {
                List<Recept> recepti = ReceptiController.Instance.GetSveRecepte();
                string vracanje = "";
                List<Lek> lekovi = LekoviController.Instance.GetSveLekove();

                foreach (Lek l in lekovi)
                    if (sifraLeka == l.Sifra)
                        vracanje = l.Naziv + " " + l.Doza;

                return vracanje;
            }
        }
        public Recept(int sifraLeka, int kolicinaLeka, String nacinUpotrebe, String jmbgPacijenta, DateTime datumIzdavanja)
        {
            Random rand = new Random();
            this.SifraRecepta = rand.Next();
            this.SifraLeka = sifraLeka;
            this.KolicinaLeka = kolicinaLeka;
            this.NacinUpotrebe = nacinUpotrebe;
            this.JmbgPacijenta = jmbgPacijenta;
            this.DatumIzdavanjaLeka = datumIzdavanja;
        }

        public Recept() { }
    }
}