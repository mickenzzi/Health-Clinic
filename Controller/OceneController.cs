using Bolnica.Model;
using Bolnica.Repository;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Controller
{
    class OceneController
    {
        private static OceneController instance = null;

        private OceneController()
        {
        }

        public static OceneController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OceneController();
                }
                return instance;
            }
        }
        public bool DodajOcenu(Ocena ocena)
        {
            return OceneService.Instance.DodajOcenu(ocena);
        }
    }
}

