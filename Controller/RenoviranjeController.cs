using Bolnica.Model;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Controller
{
    class RenoviranjeController
    {
        private static RenoviranjeController instance = null;

        private RenoviranjeController()
        {
        }

        public static RenoviranjeController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RenoviranjeController();
                }
                return instance;
            }
        }


        public void ZakaziRenoviranje(Soba soba, DateTime pocetakRenoviranja, DateTime zavrsetakRenoviranja)
        {
            RenoviranjeService.Instance.ZakaziRenoviranje(soba, pocetakRenoviranja, zavrsetakRenoviranja);
        }
    }
}
