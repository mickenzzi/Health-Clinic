using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.DTO
{
    public class BolestDTO
    {
        Bolest izabranaBolest;

        public Bolest IzabranaBolest
        {
        get { return this.izabranaBolest; }
        set { this.izabranaBolest = value; }
        }
    }

   
}
