using Bolnica.DTO;
using Bolnica.Model;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Controller
{
    class BeleskePacijentController
    {
        private static BeleskePacijentController instance = null;

        private BeleskePacijentController()
        {
        }

        public static BeleskePacijentController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BeleskePacijentController();
                }
                return instance;
            }
        }

        public bool obrisiBelesku(int sifraBrisaneBeleske) 
        {
            return  BeleskePacijentService.Instance.obrisiBelesku(sifraBrisaneBeleske);
        }
        public void dodajBelesku(string nazivBeleske, string sadrzajBeleske, PacijentDTO pacijentDTO) 
        {
            BeleskePacijentService.Instance.dodajBelesku(nazivBeleske, sadrzajBeleske, pacijentDTO);
        }

        public List<Beleska> GetSveBeleske()
        {
            return BeleskePacijentService.Instance.GetSveBeleske();
        }

        public void SetSveBeleske(List<Beleska> beleske)
        {
            BeleskePacijentService.Instance.SetSveBeleske(beleske);
        }
    }
}
