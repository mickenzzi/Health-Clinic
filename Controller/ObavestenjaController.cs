using Bolnica.Model;
using Bolnica.Service;
using System.Collections.Generic;

namespace Bolnica.Controller
{
    class ObavestenjaController
    {
        private static ObavestenjaController instance = null;

        private ObavestenjaController()
        {
        }

        public static ObavestenjaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObavestenjaController();
                }
                return instance;
            }
        }

        public List<Obavestenje> GetSvaObavestenja()
        {
            return ObavestenjaService.Instance.GetSvaObavestenja();
        }
        public bool AddObavestenje(Obavestenje obavestenje)
        {
            return ObavestenjaService.Instance.AddObavestenje(obavestenje);
        }
        public bool SetObavestenje(Obavestenje obavestenje)
        {
            return ObavestenjaService.Instance.SetObavestenje(obavestenje);
        }

        public void RemoveObavestenje(Obavestenje obavestenje)
        {
            ObavestenjaService.Instance.RemoveObavestenje(obavestenje);
        }
        public Obavestenje GetObavestenje(int id) 
        {
            return ObavestenjaService.Instance.GetObavestenje(id);
        }

        public List<Obavestenje> GetObavestenjaPacijenta(int idPacijenta) 
        {
            return ObavestenjaService.Instance.GetObavestenjaPacijenta(idPacijenta);
        }
    }
}
