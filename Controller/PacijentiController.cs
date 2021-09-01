using Bolnica.DTO;
using Bolnica.Model;
using Bolnica.Service;
using System;
using System.Collections.Generic;


namespace Bolnica.Controller
{
    class PacijentiController
    {
        private static PacijentiController instance = null;

        private PacijentiController()
        {
        }

        public static PacijentiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PacijentiController();
                }
                return instance;
            }
        }

        public bool AddPacijent(Pacijent pacijent)
        {

            return PacijentiService.Instance.AddPacijent(pacijent);
        }

        public void SetPacijent(Pacijent pacijent)
        {

            PacijentiService.Instance.setPacijent(pacijent);
        }

        public void RemovePacijent(Pacijent pacijent)
        {
            PacijentiService.Instance.RemovePacijent(pacijent);
        }

        public List<Pacijent> GetSvePacijente()
        {
            return PacijentiService.Instance.GetSvePacijente();
        }

        public bool PotvrdaPostojanjaPacijenta(string jmbg)
        {
            return PacijentiService.Instance.PotvrdaPostojanjaPacijenta(jmbg);
        }

        public Pacijent GetOdgPacijent(string jmbg)
        {
            return PacijentiService.Instance.GetOdgPacijent(jmbg);
        }

        public IspisiDTO ZakaziPregled(Pacijent p, Termin t)
        {
            return PacijentiService.Instance.ZakaziPregled(p, t);
        }

        public void OtkaziPregled(Pacijent p, Termin t)
        {
            PacijentiService.Instance.OtkaziPregled(p, t);
        }

        public bool AzurirajTermin(DateTime novoVreme, Termin termin, Pacijent pacijent)
        {
            return PacijentiService.Instance.AzurirajTermin(novoVreme, termin, pacijent);
        }
        public List<Termin> GetTermineOdDo(Pacijent p, DateTime odDatum, DateTime doDatum, String lekar)
        {
            return PacijentiService.Instance.GetTermineOdDo(p, odDatum, doDatum, lekar);
        }

        public List<Termin> GetTerminePoLekaru(String lekar)
        {
            return PacijentiService.Instance.GetTerminePoLekaru(lekar);
        }
        public String GetAnamnezu(String jmbg)
        {
            return PacijentiService.Instance.GetAnamnezu(jmbg);
        }
    }
}
