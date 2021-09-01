using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.Controller
{
    class AlergijaController
    {
        private static AlergijaController instance = null;

        private AlergijaController()
        {
        }

        public static AlergijaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AlergijaController();
                }
                return instance;
            }
        }

        public List<Alergija> GetSveAlergije()
        {
            return AlergijaService.Instance.GetSveAlergije();
        }

        public void SetSveAlergije(List<Alergija> alergije)
        {
            AlergijaService.Instance.SetSveAlergije(alergije);
        }

        public bool AddAlergija(Alergija alergija)
        {
            return AlergijaService.Instance.AddAlergija(alergija);
        }

        public List<Alergija> GetSveAlergije(int idk)
        {
            return AlergijaService.Instance.GetSveAlergije(idk);
        }

        public void RemoveAlergija(Alergija alergija) 
        {
            AlergijaService.Instance.RemoveAlergija(alergija);
        }

        public void SetAlergija(Alergija alergija) 
        {
            AlergijaService.Instance.SetAlergija(alergija);
        }

        public Alergija GetOdgAlergija(int idAlergije) 
        {
           return AlergijaService.Instance.GetOdgAlergija(idAlergije);
        }
    }
}
