using System;
using Bolnica.Validation;

namespace Bolnica.Model
{
   public class Alergija : ValidationBase
   {
      private String naziv;
      private String sifraAlergije;
      private int idKartonaPacijenta;
      private int sifra;

        public int Sifra 
        {
            get { return this.sifra; }
            set { this.sifra = value; }
        }
        public int IdKartonaPacijenta 
        {
            get { return this.idKartonaPacijenta; }
            set { this.idKartonaPacijenta = value; }
        }
        public String Naziv 
        {
            get { return this.naziv; }
            set { this.naziv = value; }
        }

        public string SifraAlergije 
        {
            get { return this.sifraAlergije; }
            set { this.sifraAlergije = value; }
        }


        public Alergija() 
        {
            Random rand = new Random();
            this.sifra = rand.Next() + 11;
        }
        public Alergija(string nazivAlergije,string sifraAlergije) 
        {
            this.naziv = nazivAlergije;
            this.sifraAlergije = sifraAlergije;
            Random rand = new Random();
            this.sifra = rand.Next() + 11;
        }

        public Alergija(string nazivAlergije, string sifraAlergije, int sifra)
        {
            this.sifra = sifra;
            this.naziv = naziv;
            this.sifraAlergije = sifraAlergije;
        }

        protected override void ValidateSelf()
        {
            if (string.IsNullOrWhiteSpace(this.naziv))
            {
                this.ValidationErrors["Naziv"] = "Neophodno je uneti naziv alergije.";
            }
            if (string.IsNullOrWhiteSpace(this.sifraAlergije))
            {
                this.ValidationErrors["SifraAlergije"] = "Neophodno je uneti sifru alergije.";
            }
        }
    }
}