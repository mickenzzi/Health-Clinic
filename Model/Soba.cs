

using System;
using System.Collections.Generic;

namespace Bolnica.Model
{
    public class Soba
    {
        private int sifra;
        private int brojSobe;
        private TipoviSobe tip;
        private int sprat;
        private int kapacitet;
        private int zauzetost;
        private Boolean slobodna;
        private List<int> krevetiInventar = new List<int>();

        public List<int> KrevetiInventar
        {
            get { return this.krevetiInventar; }
            set { this.krevetiInventar = value; }
        }
        public int Sifra
        {
            get { return this.sifra; }
            set { this.sifra = value; }
        }

        public String IspisTipSpratBroj
        {
            get { return Tip + " " + Sprat + " " + BrojSobe; }
        }
        public String SobaSprat
        {
            get { return BrojSobe + " " + Sprat; }
        }

        public TipoviSobe Tip
        {
            get { return this.tip; }
            set { this.tip = value; }
        }
        public int Sprat
        {
            get { return this.sprat; }
            set { this.sprat = value; }
        }
        public int BrojSobe
        {
            get { return this.brojSobe; }
            set { this.brojSobe = value; }
        }


        public int Kapacitet
        {
            get { return this.kapacitet; }
            set { this.kapacitet = value; }
        }
        public int Zauzetost
        {
            get { return this.zauzetost; }
            set { this.zauzetost = value; }
        }

        public Boolean Slobodna
        {
            get { return this.slobodna; }
            set { this.slobodna = value; }
        }

        public override string ToString()
        {
            return Tip + " " + Sprat + " " + BrojSobe;
        }
        public Soba(int brojSobe, TipoviSobe tipSobe, int sprat, int kapacitet)
        {
            Random random = new Random();
            this.sifra = random.Next() + 17;
            this.brojSobe = brojSobe;
            this.tip = tipSobe;
            this.sprat = sprat;
            this.kapacitet = kapacitet;
            this.zauzetost = 0;
        }
        public Soba() { }
       
    }
}