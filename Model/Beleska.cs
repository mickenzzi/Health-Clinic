using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Model
{
    public class Beleska
    {
        private String sadrzajBeleske;
        private int sifraBeleske;
        private String nazivBeleske;
        private DateTime datumKreiranjaBeleske;

        public String NazivBeleske
        {
            get { return this.nazivBeleske; }
            set { this.nazivBeleske = value; }
        }
        public DateTime DatumKreiranjaBeleske
        {
            get { return this.datumKreiranjaBeleske; }
            set { this.datumKreiranjaBeleske = value; }
        }
        public String SadrzajBeleske
        {
            get { return this.sadrzajBeleske; }
            set { this.sadrzajBeleske = value; }
        }

        public int SifraBeleske
        {
            get { return this.sifraBeleske; }
            set { this.sifraBeleske = value; }
        }

        public Beleska() 
        {
        }

        public Beleska(string sadrzajBeleske, string nazivBeleske)
        {
            this.sadrzajBeleske = sadrzajBeleske;
            Random random = new Random();
            this.sifraBeleske = random.Next();
            this.datumKreiranjaBeleske = DateTime.Now;
            this.nazivBeleske = nazivBeleske;
        }
    }
}
