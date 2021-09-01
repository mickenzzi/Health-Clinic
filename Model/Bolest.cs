using System;

namespace Bolnica.Model
{
   public class Bolest
   {
      private DateTime datumDijagnoze;
      private String tokBolesti;
      private Terapija terapija;
      private String naziv;

      public String Naziv
      {
          get { return this.naziv; }
          set { this.naziv = value; }
      }
        public DateTime DatumDijagnoze
        {
            get { return this.datumDijagnoze; }
            set { this.datumDijagnoze = value; }
        }

        public Terapija Terapija
        {
            get { return this.terapija; }
            set { this.terapija = value; }
        }

        public Bolest(String tokBolesti, Terapija terapija, String naziv) 
        {
            this.tokBolesti = tokBolesti;
            this.terapija = terapija;
            this.naziv = naziv;
            this.datumDijagnoze = DateTime.Now;
        }
        public Bolest()
        {
        }
    }
}