using Bolnica.Model;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Service
{
    class OceneService
    {
        private static OceneService instance = null;

        private OceneService()
        {
        }

        public static OceneService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OceneService();
                }
                return instance;
            }
        }
        public List<Ocena> GetSveOcene()
        {
            return OceneRepository.Instance.GetSveOcene();
        }

        public void SetSveOcene(List<Ocena> ocene)
        {
            OceneRepository.Instance.SetSveOcene(ocene);

        }

        public bool DodajOcenu(Ocena ocena)
        {
            List<Ocena> ocene = GetSveOcene();

            foreach (Ocena o in ocene)
            {
                if (o.SifraOcene == ocena.SifraOcene)
                {
                    return false;
                }
            }
            ocene.Add(ocena);
            SetSveOcene(ocene);
            return true;
        }
        

    }
}
