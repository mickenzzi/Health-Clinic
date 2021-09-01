using Bolnica.Repository;
using Bolnica.Model;
using System.Collections.Generic;

namespace Bolnica.Service
{
    class ObavestenjaService
    {
        private static ObavestenjaService instance = null;

        private ObavestenjaService()
        {
        }

        public static ObavestenjaService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObavestenjaService();
                }
                return instance;
            }
        }

        public List<Obavestenje> GetSvaObavestenja() 
        {
            return ObavestenjaRepository.Instance.GetSvaObavestenja();
        }

        public bool AddObavestenje(Obavestenje obavestenje)
        {
            return ObavestenjaRepository.Instance.AddObavestenje(obavestenje);
        }

        public bool SetObavestenje(Obavestenje obavestenje) 
        {
            return ObavestenjaRepository.Instance.SetObavestenje(obavestenje);
        }

        public void RemoveObavestenje(Obavestenje obavestenje) 
        {
            ObavestenjaRepository.Instance.RemoveObavestenje(obavestenje);
        }

        public Obavestenje GetObavestenje(int id) 
        {
            Obavestenje obavestenje = new Obavestenje();
            List<Obavestenje> obavestenja = new List<Obavestenje>();
            obavestenja = ObavestenjaRepository.Instance.GetSvaObavestenja();
            foreach(Obavestenje o in obavestenja) 
            {
                if (o.Id == id) 
                {
                    obavestenje = o;
                }
            }
            return obavestenje;
        }

        public List<Obavestenje> GetObavestenjaPacijenta(int idPacijenta) 
        {
            return ObavestenjaRepository.Instance.GetObavestenjaPacijenta(idPacijenta);
        }

    }
}
