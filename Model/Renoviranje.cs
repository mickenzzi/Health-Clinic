using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Model
{
    public class Renoviranje
    {

        private int sifraSobe;
        private DateTime datumPocetka;
        private DateTime datumZavrsetka;

        public int SifraSobe
        {
            get { return this.sifraSobe; }
            set { this.sifraSobe = value; }
        }

        public DateTime DatumPocetka
        {
            get { return this.datumPocetka; }
            set { this.datumPocetka = value; }
        }

        public DateTime DatumZavrsetka
        {
            get { return this.datumZavrsetka; }
            set { this.datumZavrsetka = value; }
        }

        public Renoviranje() { }
        public Renoviranje(int sifraSobe, DateTime datumPocetka, DateTime datumZavrsetka)
        {
            this.sifraSobe = sifraSobe;
            this.datumPocetka = datumPocetka;
            this.datumZavrsetka = datumZavrsetka;
        }
    }
}
