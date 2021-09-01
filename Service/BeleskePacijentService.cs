using Bolnica.DTO;
using Bolnica.Model;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Service
{
    class BeleskePacijentService
    {
        private static BeleskePacijentService instance = null;

        private BeleskePacijentService()
        {
        }

        public static BeleskePacijentService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BeleskePacijentService();
                }
                return instance;
            }
        }

        public bool obrisiBelesku(int sifraBrisaneBeleske)
        {
            List<Beleska> sveBeleske = BeleskePacijentRepository.Instance.GetSveBeleske();
            foreach (Beleska beleska in sveBeleske)
            {
                if(beleska.SifraBeleske == sifraBrisaneBeleske)
                {
                    sveBeleske.Remove(beleska);
                    BeleskePacijentRepository.Instance.SetSveBeleske(sveBeleske);
                    return true;
                }
            }
            return false;
        }

        public void dodajBelesku(string nazivBeleske, string sadrzajBeleske, PacijentDTO pacijentDTO)
        {
            List<Beleska> sveBeleske = BeleskePacijentRepository.Instance.GetSveBeleske();
            Beleska dodavanaBeleska = new Beleska(sadrzajBeleske, nazivBeleske);
            pacijentDTO.Pacijent.ListaSifriBeleski.Add(dodavanaBeleska.SifraBeleske);
            sveBeleske.Add(dodavanaBeleska);
            BeleskePacijentRepository.Instance.SetSveBeleske(sveBeleske);
        }

        public List<Beleska> GetSveBeleske() 
        {
            return BeleskePacijentRepository.Instance.GetSveBeleske();      
        }

        public void SetSveBeleske(List<Beleska> beleske)
        {
            BeleskePacijentRepository.Instance.SetSveBeleske(beleske);
        }
    }
}
