

using System;

namespace Bolnica.Model
{
   public class BolesnickaSoba : Soba
   {
      private int kapacitet;
      private int zauzetost;
      
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

        public BolesnickaSoba() { }
   
   }
}