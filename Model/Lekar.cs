using System;
using System.Collections.Generic;
using Bolnica.Validation;

namespace Bolnica.Model
{
    public class Lekar : ValidationBase
    { 
        public Ocena[] ocena;

        public static List<Termin> termin;

        private String ime;
        private String prezime;
        private String jmbg;
        private DateTime datumRodjenja;
        private String mestoRodjenja;
        private Boolean specijalista;
        private string specijalizacija;
        private int id;
        private DateTime datumPocetkaOdmora;
        private DateTime datumKrajaOdmora;
        private DateTime pocetakRadnogVremena;
        private DateTime krajRadnogVremena;


        public DateTime PocetakRadnogVremena 
        {
            get { return this.pocetakRadnogVremena; }
            set { this.pocetakRadnogVremena = value; }
        }
        
        public DateTime KrajRadnogVremena 
        {
            get { return this.krajRadnogVremena; }
            set { this.krajRadnogVremena = value; }
        }
        public DateTime DatumPocetkaOdmora 
        {
            get { return this.datumPocetkaOdmora; }
            set { this.datumPocetkaOdmora = value; }
        }

        public DateTime DatumKrajaOdmora
        {
            get { return this.datumKrajaOdmora; }
            set { this.datumKrajaOdmora = value; }
        }

        public DateTime DatumRodjenja 
        {
            get { return this.datumRodjenja; }
            set { this.datumRodjenja = value; }
        }

        public string MestoRodjenja 
        {
            get { return this.mestoRodjenja; }
            set { this.mestoRodjenja = value; }
        }

        public Boolean Specijalista
        {
            get { return this.specijalista; }
            set { this.specijalista = value; }
        }

        public string Specijalizacija 
        {
            get { return this.specijalizacija; }
            set { this.specijalizacija = value; }
        }

        public int Id 
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Jmbg 
        {
            get { return this.jmbg; }
            set { this.jmbg = value; }
        }
        
      

        public String Ime
        {
            get { return this.ime; }
            set { this.ime = value;}
        }
        public String Prezime
        {
            get { return this.prezime; }
            set { this.prezime = value; }
        }

        public String LekarInfo
        {
            get { return Ime + " " + Prezime; }
        }

        public Lekar() 
        {
            Random random = new Random();
            this.id = random.Next() + 101;
        }
        
        public Lekar(string ime, string prezime, string jmbg, DateTime datumRodjenja, string mestoRodjenja, Boolean specijalista,string spec)
        {
            Random random = new Random();
            this.id = random.Next() + 101;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.mestoRodjenja = mestoRodjenja;
            this.specijalista = specijalista;
            this.specijalizacija = spec;
        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        protected override void ValidateSelf()
        {
            if (string.IsNullOrWhiteSpace(this.ime))
            {
                this.ValidationErrors["Ime"] = "Neophodno je uneti ime lekara.";
            }
            if (string.IsNullOrWhiteSpace(this.prezime))
            {
                this.ValidationErrors["Prezime"] = "Neophodno je uneti prezime lekara.";
            }
            if (string.IsNullOrWhiteSpace(this.jmbg))
            {
                this.ValidationErrors["Jmbg"] = "Neophodno je uneti jmbg lekara.";
            }
            if (datumRodjenja==default)
            {
                this.ValidationErrors["DatumRodjenja"] = "Neophodno je uneti datum rodjenja lekara.";
            }
            if (string.IsNullOrWhiteSpace(this.mestoRodjenja))
            {
                this.ValidationErrors["MestoRodjenja"] = "Neophodno je uneti mesto rodjenja lekara.";
            }

        }

    }
}