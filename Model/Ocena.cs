using System;

namespace Bolnica.Model
{
    public class Ocena
    {
        private String dodatniKomentar;
        private Ocene vrOcene;
        private DateTime vremeOcenjivanja;
        private Lekar lekar;
        private int sifra;


        public Ocena(Ocene vrednostOcene, Lekar lekar, String dodatniKomentar)
        {
            this.vrOcene = vrednostOcene;
            this.lekar = lekar;
            this.dodatniKomentar = dodatniKomentar;
            this.vremeOcenjivanja = DateTime.Now;
            Random r = new Random();
            this.sifra = r.Next();
        }

        public Ocena(Ocene vrednostOcene, String dodatniKomentar)
        {
            this.vrOcene = vrednostOcene;
            this.dodatniKomentar = dodatniKomentar;
            this.vremeOcenjivanja = DateTime.Now;
            Random r = new Random();
            this.sifra = r.Next();
        }

        public int SifraOcene
        {
            get { return this.sifra; }
            set { this.sifra = value; }
        }
        public Ocene VrednostOcene
        {
            get { return this.vrOcene; }
            set { this.vrOcene = value; }
        }
        public Lekar Lekar
        {
            get { return this.lekar; }
            set { this.lekar = value; }
        }
        public DateTime VremeOcenjivanja
        {
            get { return this.vremeOcenjivanja; }
            set { this.vremeOcenjivanja = value; }
        }
        public String DodatniKomentar
        {
            get { return this.dodatniKomentar; }
            set { this.dodatniKomentar = value; }
        }

        public Ocena()
        {
        }
    }
}