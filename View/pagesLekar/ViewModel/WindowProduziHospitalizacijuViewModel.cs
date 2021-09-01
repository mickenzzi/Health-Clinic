using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bolnica.View.pagesLekar.ViewModel
{
    public class WindowProduziHospitalizacijuViewModel : BindableBase
    {
        private LekarView parent;
        private Termin termin;
        private int idTermina;
        private string pacijentInfo;
        private int produzetakHospitalizacije;
        public Action CloseAction { get; set; }
        public MyICommand ProduzetakHospitalizacijeCommand { get; set; }

        public WindowProduziHospitalizacijuViewModel(LekarView parent, int idTermina)
        {
            this.parent = parent;
            this.idTermina = idTermina;
            LoadTermin();
            ProduzetakHospitalizacijeCommand = new MyICommand(OnProduziHospitalizaciju);
        }

        public string PacijentInfo
        {
            get { return pacijentInfo; }
            set
            {
                pacijentInfo = value;
                OnPropertyChanged("PacijentInfo");
            }
        }

        public int ProduzetakHospitalizacije
        {
            get { return produzetakHospitalizacije; }
            set
            {
                produzetakHospitalizacije = value;
                OnPropertyChanged("ProduzetakHospitalizacije");
            }
        }

        public void LoadTermin()
        {
            termin = TerminiController.Instance.GetTermin(idTermina);
            PacijentInfo = termin.PacijentInfo;
        }

        private void OnProduziHospitalizaciju()
        {
            if (!ProduzetakHospitalizacije.Equals(null))
            {
                int produzetakDani = ProduzetakHospitalizacije;
                DateTime temp = termin.KrajTermina;
                DateTime krajTerminaUpdated = new DateTime(temp.Year, temp.Month, temp.Day, temp.Hour, temp.Minute, 0);
                krajTerminaUpdated = krajTerminaUpdated.AddDays(produzetakDani);
                Termin t = new Termin(termin.JmbgPacijenta, termin.SifraSobe.ToString(), termin.DatumVreme, krajTerminaUpdated); ;
                if (TerminiController.Instance.IzmeniHospitalizaciju(termin, t))
                {
                    CloseAction();
                    MessageBox.Show("Hospitalizacija je produzena za " + produzetakDani + " dana.");
                    parent.frejm.Content = null;
                    Lekar l = LekariController.Instance.GetOdgLekarByJmbg(termin.JmbgLekara);
                    parent.frejm.Content = new PagePrikazTermina(parent, l.Jmbg);
                }
            }
            else
                MessageBox.Show("Unesite broj dana.");
        }
    }
}
