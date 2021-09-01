using System;

namespace Bolnica.Model
{
   public class Terapija
   {
      
      private String opisTerapije;

      public String OpisTerapije
      {
            get { return this.opisTerapije; }
            set { this.opisTerapije = value; }
      }
        public Terapija(String opisTerapije)
        {
            this.opisTerapije = opisTerapije;
        }
        public Terapija()
        {
        }
   }
}