using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class BeleskeDTO
    {
        private List<Beleska> listaBeleski;

        public List<Beleska> ListaBeleski
        {
            get { return this.listaBeleski; }
            set { this.listaBeleski = value; }
        }

        public BeleskeDTO()
        {
            listaBeleski = new List<Beleska>();
        }
    }
}
