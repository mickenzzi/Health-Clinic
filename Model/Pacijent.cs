using System;
using System.Collections.Generic;
using Bolnica.Validation;

namespace Bolnica.Model
{
   public class Pacijent : ValidationBase
   {

      private int id;
      private String ime;
      private List<int> sifreZakazanihTermina;
      private String prezime;
      private String jmbg;
      private Boolean hitanSlucaj;
      private int idZK;
      private int brojZakazivanjaUDanu;
      private DateTime datumPoslednjegZakazivanja;
      private int brojPomeranjaUDanu;
      private DateTime datumPoslednjegPomeranja;
      private DateTime datumPoslednjegOcenjivanjaBolnice;
      private List<Bolest> listaBolesti;
      private List<int> listaSifriBeleski;
      private Boolean blokiran;

        public Boolean Blokiran
        {
            get { return this.blokiran; }
            set { this.blokiran = value; }
        }
        public List<int> ListaSifriBeleski
        {
            get { return this.listaSifriBeleski; }
            set { this.listaSifriBeleski = value; }
        }
        public List<Bolest> ListaBolesti
        {
            get { return this.listaBolesti; }
            set { this.listaBolesti = value; }
        }
        public int BrojPomeranjaUDanu
        {
            get { return this.brojPomeranjaUDanu; }
            set { this.brojPomeranjaUDanu = value; }
        }
        public int BrojZakazivanjaUDanu
        {
            get { return this.brojZakazivanjaUDanu; }
            set { this.brojZakazivanjaUDanu = value; }
        }
        public DateTime DatumPoslednjegOcenjivanjaBolnice
        {
            get { return this.datumPoslednjegOcenjivanjaBolnice; }
            set { this.datumPoslednjegOcenjivanjaBolnice = value; }
        }
        public DateTime DatumPoslednjegPomeranja
        {
            get { return this.datumPoslednjegPomeranja; }
            set { this.datumPoslednjegPomeranja = value; }
        }
        public DateTime DatumPoslednjegZakazivanja
        {
            get { return this.datumPoslednjegZakazivanja; }
            set { this.datumPoslednjegZakazivanja = value; }
        }
        public int Id
        { 
            get { return this.id; }
            set { this.id = value; }
        }
     public List<int> SifreZakazanihTermina 
        { 
          get { return this.sifreZakazanihTermina; }
          set { this.sifreZakazanihTermina = value; }
        }
     
        public List<Recept> recepti;
        
        public String Ime 
        {
            get { return this.ime; }
            set { this.ime = value; }
        }
      
        public String Prezime
        {
            get { return this.prezime; }
            set { this.prezime = value; }
        }
     
        public String Jmbg
        {
            get { return this.jmbg; }
            set { this.jmbg = value; }
        }
        
        public Boolean HitanSlucaj
        {
            get { return this.hitanSlucaj; }
            set { this.hitanSlucaj = value; }
        }
        public int IdZK
        {
            get { return this.idZK; }
            set { this.idZK = value; }
        }

        public String PacijentInfo
        {
            get { return this.ime + " " + this.prezime; }
        }


        public Pacijent(String ime, String prezime, String jmbg, Boolean hitanSlucaj)
        {
            Random random = new Random();
            this.id = random.Next();
            this.idZK = random.Next()+10;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.hitanSlucaj = hitanSlucaj;
            this.brojZakazivanjaUDanu = 0;
            this.brojPomeranjaUDanu = 0;
            this.datumPoslednjegOcenjivanjaBolnice = DateTime.Now;
            this.blokiran = false;

        }
        public Pacijent() 
        {
            Random random = new Random();
            this.id = random.Next();
            this.idZK = random.Next() + 10;
            this.brojZakazivanjaUDanu = 0;
            this.brojPomeranjaUDanu = 0;
            this.datumPoslednjegOcenjivanjaBolnice = DateTime.Now;
        }

        protected override void ValidateSelf()
        {
            if (string.IsNullOrWhiteSpace(this.ime))
            {
                this.ValidationErrors["Ime"] = "Neophodno je uneti ime pacijenta.";
            }
            if (string.IsNullOrWhiteSpace(this.prezime))
            {
                this.ValidationErrors["Prezime"] = "Neophodno je uneti prezime pacijenta.";
            }
            if (string.IsNullOrWhiteSpace(this.jmbg))
            {
                this.ValidationErrors["Jmbg"] = "Neophodno je uneti jmbg pacijenta.";
            }
        }
    }
}