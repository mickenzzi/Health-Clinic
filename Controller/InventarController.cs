using Bolnica.Model;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Controller
{
    class InventarController
    {
        private static InventarController instance = null;

        private InventarController()
        {
        }

        public static InventarController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InventarController();
                }
                return instance;
            }
        }

        public void DodajInventar(Inventar inventar)
        {
            InventarService.Instance.DodajInventar(inventar);
        }

        public List<Inventar> GetSavInventar()
        {
            return InventarService.Instance.GetSavInventar();
        }

        public List<Inventar> GetSveKrevete()
        {
            return InventarService.Instance.GetSveKrevete();
        }
        public void IzmeniInventar(Inventar stari, Inventar novi)
        {
            InventarService.Instance.IzmeniInventar(stari, novi);
        }

        public void IzmeniInventarKrevet(Inventar stari, Inventar novi)
        {
            InventarService.Instance.IzmeniInventarKrevet(stari, novi);
        }

        public void ObrisiInventar(Inventar i)
        {
            InventarService.Instance.ObrisiInventar(i);
        }
        public bool PremestiInventar(Inventar inventar, int brojSobe, int kolicinaInventara, DateTime vremePremestanja)
        {
            return InventarService.Instance.PremestiInventar(inventar, brojSobe, kolicinaInventara, vremePremestanja);
        }


        public Inventar GetInventarBySifra(int sifra)
        {
            return InventarService.Instance.GetInventarBySifra(sifra);
        }


    }
}
