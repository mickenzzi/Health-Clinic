using Bolnica.Model;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Controller
{
    class SobeController
    {
        private static SobeController instance = null;

        private SobeController()
        {
        }

        public static SobeController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SobeController();
                }
                return instance;
            }
        }
        public void SetSoba(Soba soba)
        {
            SobeService.Instance.SetSoba(soba);
        }

        public List<Soba> GetSveSobe()
        {
            return SobeService.Instance.GetSveSobe();
        }

        public bool DodajSobu(Soba soba)
        {
            return SobeService.Instance.DodajSobu(soba);
        }

        public void ObrisiSobu(Soba soba)
        {
            SobeService.Instance.ObrisiSobu(soba);
        }

        public Soba GetSobu(int sifraSobe)
        {
            return SobeService.Instance.GetSobu(sifraSobe);
        }

        public Soba GetSlobodnaSoba(TipoviSobe tip)
        {
            return SobeService.Instance.GetSlobodnaSoba(tip);
        }

        public Soba GetSobuById(int sifraSobe)
        {
            return SobeService.Instance.GetSobuById(sifraSobe);
        }
        public List<Soba> GetZauzeteSobe() 
        {
            return SobeService.Instance.GetZauzeteSobe();
        }
    }
}
