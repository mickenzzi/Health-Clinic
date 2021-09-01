using Bolnica.Model;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Controller
{
    class TerminiController
    {
        private static TerminiController instance = null;

        private TerminiController()
        {
        }

        public static TerminiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TerminiController();
                }
                return instance;
            }
        }


        public List<Termin> GetSveTermine()
        {
            return TerminiService.Instance.GetSveTermine();
        }

        public void SetTermin(Termin t)
        {
            TerminiService.Instance.SetTermin(t);
        }

        public bool ZakaziOperaciju(Termin termin)
        {
            return TerminiService.Instance.ZakaziOperaciju(termin);
        }

        public bool ZakaziPregled(Termin termin)
        {
            return TerminiService.Instance.ZakaziPregled(termin);
        }


        public bool ZakaziHitanPregled(Termin termin)
        {

            return TerminiService.Instance.ZakaziPregled(termin);

        }

        public bool ZakaziHitnuOperaciju(Termin termin)
        {
            return TerminiService.Instance.ZakaziOperaciju(termin);
        }
        public void OtkaziTermin(Termin termin)
        {
            TerminiService.Instance.OtkaziOperaciju(termin);
        }

        public void OtkaziOperaciju(Termin termin)
        {
            string poruka;
            poruka = "Otkazali ste operaciju kod " + termin.Lekar.Ime + " " + termin.Lekar.Prezime + " za " + termin.DatumVreme.ToString() + ".";
            Obavestenje o = new Obavestenje(poruka, termin.Pacijent.Id);
            ObavestenjaController.Instance.AddObavestenje(o);
            TerminiService.Instance.OtkaziOperaciju(termin);
        }
        public void OtkaziPregled(Termin termin)
        {
            string poruka;
            poruka = "Otkazali ste pregled kod " + termin.Lekar.Ime + " " + termin.Lekar.Prezime + " za " + termin.DatumVreme.ToString() + ".";
            Obavestenje o = new Obavestenje(poruka, termin.Pacijent.Id);
            ObavestenjaController.Instance.AddObavestenje(o);
            TerminiService.Instance.OtkaziPregled(termin);
        }
        public Lekar SlobodanLekar(DateTime datum)
        {
            return TerminiService.Instance.SlobodanLekar(datum);
        }
        public bool ZakaziTermin(Termin t)
        {
            return TerminiService.Instance.ZakaziTermin(t);
        }
        public List<Termin> GetOdgTermine(int idPacijenta, TipoviSobe tip)
        {

            return TerminiService.Instance.GetOdgTermine(idPacijenta, tip);
        }
        public bool GetOdgTermin(DateTime datum, int idLekara)
        {
            return TerminiService.Instance.GetOdgTermin(datum,idLekara);
        }
        public Termin GetTermin(int idTermina) 
        {
            return TerminiService.Instance.GetTermin(idTermina);
        }
        public List<Termin> getZakazaneTermine(Pacijent p)
        {
            return TerminiService.Instance.getZakazaneTermine(p);
        }
        public string[] GetVremena()
        {
            return TerminiService.Instance.GetVremena();
        }
        public bool IzmeniTermin(Termin stari,Termin novi) 
        {
            return TerminiService.Instance.IzmeniTermin(stari, novi);
        }

        public bool IzmeniHospitalizaciju(Termin stari, Termin novi)
        {
            return TerminiService.Instance.IzmeniHospitalizaciju(stari, novi);
        }

        public DateTime GetDatumTermina(int sifraSobe) 
        {
            return TerminiService.Instance.GetDatumTermina(sifraSobe);
        }

    }
}
