using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.Controller
{
    class LekariController
    {
        private static LekariController instance = null;

        private LekariController()
        {
        }

        public static LekariController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LekariController();
                }
                return instance;
            }
        }

        public bool AddLekar(Lekar lekar) 
        {
            return LekariService.Instance.AddLekar(lekar);
        }

        public bool SetLekar(Lekar lekar)
        {
            return LekariService.Instance.SetLekar(lekar);
        }

        public void SetSveLekare(List<Lekar> lekari)
        {
            LekariService.Instance.SetSveLekare(lekari);
        }


        public List<Lekar> GetSviLekari()
        {
            return LekariService.Instance.GetSveLekare();
        }

        public void RemoveLekar(Lekar lekar)
        {
            LekariService.Instance.RemoveLekar(lekar);
        }

        public Lekar GetOdgLekar(int id) 
        {
            return LekariService.Instance.GetOdgLekar(id);
        }

        public Lekar GetOdgLekarByJmbg(string jmbg)
        {
            return LekariService.Instance.GetOdgLekarByJmbg(jmbg);
        }
    }
}
