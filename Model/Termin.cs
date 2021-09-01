using Bolnica.Controller;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Bolnica.Model
{
   public class Termin
   {

        private Boolean slobodan;
        private DateTime datumVreme;
        private int sifraSobe;
        private Lekar lekar;
        private Pacijent pacijent;
        private Boolean pomeren;
        private int sifra;
        private int idPacijenta;
        private Soba soba;
        private bool ocenjen;
        private string jmbgPacijenta;
        private string jmbgLekara;
        private DateTime krajTermina;

        public String JmbgPacijenta
        {
            get { return this.jmbgPacijenta; }
            set { this.jmbgPacijenta = value; }
        }

        public String JmbgLekara
        {
            get { return this.jmbgLekara; }
            set { this.jmbgLekara = value; }
        }

        public DateTime KrajTermina
        {
            get { return this.krajTermina; }
            set { this.krajTermina = value; }
        }

        public Boolean Slobodan 
        {
            get { return this.slobodan; }
            set { this.slobodan = value; }
        }

        public String[] Vremena
        {
            get
            {
                string[] vremena = {"08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30",
                                    "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30"};
                return vremena;
            }

        }

        public bool Ocenjen
        {
            get { return this.ocenjen; }
            set { this.ocenjen = value; }
        }

        public int SifraSobe
        {
            get { return this.sifraSobe; }
            set { this.sifraSobe = value; }
        }
        public Soba Soba
        {
            get { return this.soba; }
            set { this.soba = value; }
        }
        public DateTime DatumVreme
        {
            get { return this.datumVreme; }
            set { this.datumVreme = value; }
        }
       public Lekar Lekar
        {
            get { return this.lekar; }
            set { this.lekar = value; }
        }
        public int IdPacijenta
        {
            get { return this.idPacijenta; }
            set { this.idPacijenta = value; }
        }
       public Pacijent Pacijent 
        {
            get { return this.pacijent; }
            set { this.pacijent = value; }
        }
       public Boolean Pomeren
        {
            get { return this.pomeren; }
            set { this.pomeren = value; }
        }

        public int Sifra 
        {
            get { return this.sifra; }
            set { this.sifra = value; }
        }

        public string ImePrzLekar 
        {
            get 
            {
                Lekar l = LekariController.Instance.GetOdgLekarByJmbg(JmbgLekara);
                return l.Ime +" "+ l.Prezime; 
            }
            set { }
        }

        public string LekarInfo 
        {
            get
            {
                return Lekar.Ime + " " + Lekar.Prezime;
            }
            set { }
        }

        public string PacijentInfo
        {
            get 
            {
                Pacijent p = PacijentiController.Instance.GetOdgPacijent(JmbgPacijenta);
                return p.Ime + " " + p.Prezime; 
            }
            set { }
        }

        public String IspisTipSpratBroj
        {
            get
            {
                Soba soba = SobeController.Instance.GetSobuById(SifraSobe);
                return soba.Tip + " " + soba.Sprat + " " + soba.BrojSobe;
            }
        }

        public string NazivKreveta
        {
            get
            {
                string retVal = " ";
                Soba s = SobeController.Instance.GetSobuById(SifraSobe);
                foreach (int sifra in s.KrevetiInventar)
                {
                    Inventar i = InventarController.Instance.GetInventarBySifra(sifra);
                    if (i.JmbgPacijenta == JmbgPacijenta)
                        retVal = i.ToString();
                }
                return retVal;

            }
        }

        public String TipTermina
        {
            get
            {
                Soba soba = SobeController.Instance.GetSobuById(SifraSobe);
                if (soba != null)
                {
                    if (soba.Tip == TipoviSobe.OperacionaSala)
                        return "operacija";
                    else if (soba.Tip == TipoviSobe.Ordinacija)
                        return "pregled";
                    else
                        return "hospitalizacija";
                }
                return "";
            }
        }

        public Termin(Pacijent pac, Boolean s, DateTime dv, Soba sob, Lekar l)
        {
            Random random = new Random();
            this.sifra = random.Next() + 14;
            this.pacijent = pac;
            this.slobodan = s;
            this.datumVreme = dv;
            this.soba = sob;
            this.lekar = l;
            this.ocenjen = false;
        }

        public Termin(Boolean s, DateTime dv, Lekar l,Pacijent pac,Boolean p, int sifraSobe)
        {
            Random random = new Random();
            this.sifra = random.Next() + 14;
            this.slobodan = s;
            this.datumVreme = dv;
            this.lekar = l;
            this.pomeren = p;
            this.sifraSobe = sifraSobe;
            this.Pacijent = pac;
            this.ocenjen = false;
        }

        public Termin(string jmbgPac, Boolean s, DateTime dv, int sifraSobe, string jmbgLek)
        {
            Random random = new Random();
            this.sifra = random.Next() + 14;
            this.JmbgPacijenta = jmbgPac;
            this.slobodan = s;
            this.datumVreme = dv;
            this.SifraSobe = sifraSobe;
            this.JmbgLekara = jmbgLek;
            this.ocenjen = false;
        }

        public Termin() 
        {
            this.ocenjen = false;
        }

        public Termin(string pacijent, string soba, DateTime datum, DateTime kraj)
        {
            Random random = new Random();
            this.Sifra = random.Next() + 14;
            this.JmbgPacijenta = pacijent;
            this.SifraSobe = Int32.Parse(soba);
            this.DatumVreme = datum;
            this.KrajTermina = kraj;
        }



    }
}