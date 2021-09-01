using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class PacijentDTO
    {
        Pacijent pacijent;
        List<Termin> listaTermina;
        ZdravstveniKarton zdravstveniKarton;

        public List<Termin> ListaTermina
        {
            get { return this.listaTermina; }
            set { this.listaTermina = value; }
        }
        public Pacijent Pacijent
        {
            get { return this.pacijent; }
            set { this.pacijent = value; }
        }
        public ZdravstveniKarton ZdravstveniKarton
        {
            get { return this.zdravstveniKarton; }
            set { this.zdravstveniKarton = value; }
        }

        public PacijentDTO() 
        {
            Pacijent = new Pacijent();
            listaTermina = new List<Termin>();
            zdravstveniKarton = new ZdravstveniKarton();
        }

    }
}
