using System;


namespace Bolnica.Model
{
   public class Bug
    {
        private string uloga;
        private string poruka;
        private int id;
        public int Id 
        {
            get
            {
                return this.id;
            }
            set 
            {
                this.id = value;
            }
        }
        public String Uloga
        {
            get 
            { 
                return this.uloga; 
            }
            set 
            {
                this.uloga = value;
            }
        }
        public string Poruka 
        {
            get 
            {
                return this.poruka; 
            }
            set 
            {
                this.poruka = value;
            }
        }

        public Bug(string uloga,string poruka) 
        {
            Random rand = new Random();
            this.id = rand.Next() + 11;
            this.uloga = uloga;
            this.poruka = poruka;
        }
        public Bug() 
        {
            Random rand = new Random();
            this.id = rand.Next() + 11;
        }


    }
}
