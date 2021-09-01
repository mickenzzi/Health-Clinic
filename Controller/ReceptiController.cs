using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.Controller
{
    class ReceptiController
    {
        private static ReceptiController instance = null;

        private ReceptiController()
        {
        }

        public static ReceptiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceptiController();
                }
                return instance;
            }
        }

        public List<Recept> GetSveRecepte()
        {
            return ReceptiService.Instance.GetSveRecepte();
        }

        public void SetRecept(Recept recept)
        {
            ReceptiService.Instance.SetRecept(recept);
        }

        public void DodajRecept(Recept recept)
        {
            ReceptiService.Instance.DodajRecept(recept);
        }

        public void ObrisiRecept(Recept recept)
        {
            ReceptiService.Instance.ObrisiRecept(recept);
        }




    }
}
