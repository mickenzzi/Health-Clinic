using System;
using Bolnica.Validation;

namespace Bolnica.Model
{
   public class Obavestenje : ValidationBase
   {
        
        private String poruka;
        private int id;
        private int idPacijenta;
        Boolean obavestenPacijent;

        public string Poruka 
        {
            get { return this.poruka; }
            set { 
                 this.poruka = value;
                }
        }

        public int Id 
        {
            get { return this.id; }
            set { 
                this.id = value;
                }
        }

        public int IdPacijenta 
        {
            get { return this.idPacijenta; }
            set { this.idPacijenta = value; }
        }

        public Boolean ObavestenPacijent 
        {
            get { return this.obavestenPacijent; }
            set { this.obavestenPacijent = value; }
        }

        public Obavestenje(string poruka) 
        {
            Random random = new Random();
            this.id = random.Next();
            this.poruka = poruka;
            this.idPacijenta = 0;
            this.obavestenPacijent = false;
        }

        public Obavestenje(string poruka,int id) 
        {
            Random random = new Random();
            this.Id = random.Next()+16;
            this.Poruka = poruka;
            this.IdPacijenta = id;
            this.ObavestenPacijent = true;
        }

        public Obavestenje() 
        {
            Random random = new Random();
            this.Id = random.Next() + 16;
        }

        protected override void ValidateSelf()
        {
            if (string.IsNullOrWhiteSpace(this.poruka))
            {
                this.ValidationErrors["Poruka"] = "Neophodno je uneti poruku obavestenja.";
            }
        }
    }
}