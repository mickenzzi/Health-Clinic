using Bolnica.Controller;
using System;

namespace Bolnica.Model
{
    public class Lek
    {
        public Recept recept;

        private String naziv;
        private int sifra;
        private int kolicina;
        private int sifraSobe;
        private string doza;
        private int zamena;          // sifra leka, za deserijalizaciju koristi getLekById da vrati objekat leka
        private String sastojci;

        // za dvostruko odobravanje

        private Boolean odobren1;
        private Boolean izmena1;
        private Boolean odobren2;
        private Boolean izmena2;
        private String jmbgLekaraKojiJeOdobrio;
        private String jmbgLekaraKojiJeIzmenio;
        

        public String Naziv
        {
            get { return this.naziv; }
            set { this.naziv = value; }
        }
        public int Sifra
        {
            get { return this.sifra; }
            set { this.sifra = value; }
        }

        public string Doza
        {
            get { return this.doza; }
            set { this.doza = value; }
        }

        public Boolean Odobren1
        {
            get { return this.odobren1; }
            set { this.odobren1 = value; }
        }

        public Boolean Odobren2
        {
            get { return this.odobren2; }
            set { this.odobren2 = value; }
        }

        public Boolean Izmena1
        {
            get { return this.izmena1; }
            set { this.izmena1 = value; }
        }

        public Boolean Izmena2
        {
            get { return this.izmena2; }
            set { this.izmena2 = value; }
        }

        public String JmbgLekaraKojiJeOdobrio
        {
            get { return this.jmbgLekaraKojiJeOdobrio; }
            set { this.jmbgLekaraKojiJeOdobrio = value; }
        }

        public String JmbgLekaraKojiJeIzmenio
        {
            get { return this.jmbgLekaraKojiJeIzmenio; }
            set { this.jmbgLekaraKojiJeIzmenio = value; }
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

        public int Zamena
        {
            get { return this.zamena; }
            set { this.zamena = value; }
        }

        public String Sastojci
        {
            get { return this.sastojci; }
            set { this.sastojci = value;  }
        }

        public String StanjeLeka
        {
            get
            {
                string proverenLek;

                if (odobren2)
                    proverenLek = "Odobren";
                else if (izmena2)
                    proverenLek = "Potrebna izmena";
                else
                    proverenLek = "U razmatranju";

                return proverenLek;
            }
        }

        public string LekDoza
        {
            get
            {
                string vracanje;
                if (doza == "")
                    vracanje = naziv;
                else
                    vracanje = naziv + " " + doza;
                return vracanje;
            }
        }

        public override string ToString()
        {
            string vracanje;
            if (doza == "")
                vracanje = Naziv;
            else
                vracanje = Naziv + " " + Doza;
            return vracanje;
        }

        public Lek(string naziv, string doza, int kolicina, int sifraSobe, int zamena, string sastojci)
        {
            Random rand = new Random();
            this.sifra = rand.Next();
            this.naziv = naziv;
            this.doza = doza;
            this.kolicina = kolicina;
            this.sifraSobe = sifraSobe;
            this.zamena = zamena;
            this.sastojci = sastojci;
            this.odobren1 = false;
            this.odobren2 = false;
            this.izmena1 = false;
            this.izmena2 = false;
            this.jmbgLekaraKojiJeIzmenio = "0";
            this.jmbgLekaraKojiJeOdobrio = "0";
        }

        public Lek(string naziv, string doza, int kolicina, int sifraSobe, int zamena, string sastojci, Boolean odobren1, Boolean odobren2, Boolean izmena1, Boolean izmena2, string jmbgLekaraOdobrio, string jmbgLekaraIzmenio)
        {
            this.naziv = naziv;
            this.doza = doza;
            this.kolicina = kolicina;
            this.sifraSobe = sifraSobe;
            this.zamena = zamena;
            this.sastojci = sastojci;
            this.odobren1 = odobren1;
            this.odobren2 = odobren2;
            this.izmena1 = izmena1;
            this.izmena2 = izmena2;
            this.jmbgLekaraKojiJeOdobrio = jmbgLekaraOdobrio;
            this.jmbgLekaraKojiJeIzmenio = jmbgLekaraIzmenio;
        }

        public Lek() { }

    }
}