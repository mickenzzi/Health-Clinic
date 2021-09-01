using Bolnica.Model;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Controller
{
    class LekoviController
    {

        private static LekoviController instance = null;

        private LekoviController()
        {
        }

        public static LekoviController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LekoviController();
                }
                return instance;
            }
        }


        public bool DodajLek(Lek lek)
        {
           return  LekoviService.Instance.DodajLek(lek);
        }

        public List<Lek> GetSveLekove()
        {
            return LekoviService.Instance.GetSveLekove();
        }
        public void SetSveLekove(List<Lek> lekovi)
        {
            LekoviService.Instance.SetSveLekove(lekovi);
        }

        public void IzmeniLek(Lek starilek, Lek noviLek)
        {
            LekoviService.Instance.IzmeniLek(starilek, noviLek);
        }

        public void ObrisiLek(Lek lek)
        {
            LekoviService.Instance.ObrisiLek(lek);
        }

        public Lek GetLekById(int id)
        {
            return LekoviService.Instance.GetLekById(id);
        }
    }
}
