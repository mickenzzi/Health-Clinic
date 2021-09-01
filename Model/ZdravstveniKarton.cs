using System;
using System.Collections.Generic;
namespace Bolnica.Model
{
    public class ZdravstveniKarton
    {

        private int id;
        private String anamneza;
        private DateTime datumRodjenja;
        private String mestoStanovanja;
        private String telefon;
        private String ulicaIBroj;
        private Pol pol;
        private BracniStatus bracniStatus;
        private int idPacijenta;

        public String Anamneza
        {
            get { return this.anamneza; }
            set { this.anamneza = value; }
        }

        public DateTime DatumRodjenja
        {
            get { return this.datumRodjenja; }
            set { this.datumRodjenja = value; }
        }
        
        public String MestoStanovanja
        {
            get { return this.mestoStanovanja; }
            set { this.mestoStanovanja = value; }
        }
        
        public String Telefon
        {
            get
            { return this.telefon; }
            set
            {
                this.telefon = value;
            }
        }

        public String UlicaIbroj
        {
            get
            { return this.ulicaIBroj; }
            set
            {
                this.ulicaIBroj = value;
            }
        }

        public Pol Pol
        {
            get { return this.pol; }
            set { this.pol = value; }
        }

        public BracniStatus BracniStatus
        {
            get { return this.bracniStatus; }
            set { this.bracniStatus = value; }
        }

        public int IdPacijenta
        {
            get { return this.idPacijenta; }
            set { this.idPacijenta = value; }
        }

        public int Id 
        {
            get { return this.id; }
            set { this.id = value; }
        }
        


        public ZdravstveniKarton()
        {
        }

        public ZdravstveniKarton(int idk,int idp) 
        {
            this.id = idk;
            this.idPacijenta = idp;
        }

        public ZdravstveniKarton(DateTime datr,String ms,String t,String u,Pol p,BracniStatus bs) 
        {
            
            this.datumRodjenja = datr;
            this.mestoStanovanja = ms;
            this.telefon = t;
            this.ulicaIBroj = u;
            this.pol = p;
            this.bracniStatus = bs;
         
           
        }


    }
}