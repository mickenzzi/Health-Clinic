using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class IspisiDTO
    {
        private bool status1;
        private bool status2;

        public bool Status1
        {
            get { return this.status1; }
            set { this.status1 = value; }
        }
        public bool Status2
        {
            get { return this.status2; }
            set { this.status2 = value; }
        }

        public IspisiDTO()
        {
            status1 = false;
            status2 = false;
        }
    }
}
