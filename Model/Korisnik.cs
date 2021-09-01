using System;

namespace Bolnica.Model
{
   public class Korisnik
   {
   
      private String ime;
      private String prezime;
      private String jmbg;
      private String email;
      private String sifra;

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

        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public String Sifra
        {
            get { return this.sifra; }
            set { this.sifra = value; }
        }

        public Korisnik() { }
        
        public Korisnik(string imek,string prezimek,string jmbgk,string emailk,string sifrak) 
        {
            this.ime = imek;
            this.prezime = prezimek;
            this.jmbg = jmbgk;
            this.email = emailk;
            this.sifra = sifrak;
        }

    }
}