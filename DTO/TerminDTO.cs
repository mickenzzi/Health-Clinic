using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class TerminDTO
    {
        private Termin termin;

        public Termin Termin
        {
            get { return this.termin; }
            set { this.termin = value; }
        }

        public TerminDTO()
        {
            termin = new Termin();
        }
    }
}
