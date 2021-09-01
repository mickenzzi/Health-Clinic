using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.View.pagesLekar.ViewModel
{
    public class WindowIzmeniTerminViewModel : BindableBase
    {
        private LekarView parent;
        private Termin termin;
        private int idTermina;
        private Soba selectedSoba;
        private DateTime selectedDatum;
        private string selectedVreme;
        private string pacijentInfo;
        private string lekarInfo;
        private string jmbgPacijenta;
        public ObservableCollection<string> Vremena { get; set; }
        public ObservableCollection<Soba> Sobe { get; set; }
        public MyICommand PotvrdaIzmeneTerminaCommand { get; set; }
        public Action CloseAction { get; set; }

        public WindowIzmeniTerminViewModel(LekarView parent, int idTermina)
        {
            this.idTermina = idTermina;
            this.parent = parent;
            LoadTermin();
            PotvrdaIzmeneTerminaCommand = new MyICommand(OnPotvrdi);
        }

        public Soba SelectedSoba
        {
            get { return selectedSoba; }
            set
            {
                selectedSoba = value;
                OnPropertyChanged("SelectedSoba");
            }
        }

        public string SelectedSobaText
        {
            get { return selectedSoba.ToString(); }
            set { }
        }

        public DateTime SelectedDatum
        {
            get { return selectedDatum; }
            set 
            { 
                selectedDatum = value;
                OnPropertyChanged("SelectedDatum");
            }
        }

        public string SelectedVreme
        {
            get { return selectedVreme; }
            set 
            { 
                selectedVreme = value;
                OnPropertyChanged("SelectedVreme");
            }
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
        public string LekarInfo
        {
            get { return lekarInfo; }
            set
            {
                lekarInfo = value;
                OnPropertyChanged("LekarInfo");
            }
        }
        public string JmbgPacijenta
        {
            get { return jmbgPacijenta; }
            set
            {
                jmbgPacijenta = value;
                OnPropertyChanged("JmbgPacijenta");
            }
        }

        public void LoadTermin()
        {
            termin = TerminiController.Instance.GetTermin(idTermina);
            Pacijent p = PacijentiController.Instance.GetOdgPacijent(termin.JmbgPacijenta);
            Lekar l = LekariController.Instance.GetOdgLekarByJmbg(termin.JmbgLekara);

            PacijentInfo = p.PacijentInfo;
            LekarInfo = l.LekarInfo;
            JmbgPacijenta = p.Jmbg;

            string[] vremeTermina = TerminiController.Instance.GetVremena();
            Vremena = new ObservableCollection<string>(vremeTermina);
            SelectedVreme = termin.DatumVreme.ToString("HH:mm");
            SelectedDatum = termin.DatumVreme;

            List<Soba> sobe = new List<Soba>();
            sobe = SobeController.Instance.GetSveSobe();
            List<Soba> sobeSource = new List<Soba>();
            if (!l.Specijalista)
            {
                foreach (Soba s in sobe)
                    if (s.Tip == TipoviSobe.Ordinacija)
                        sobeSource.Add(s);
                Sobe = new ObservableCollection<Soba>(sobeSource);
            }
            else
                Sobe = new ObservableCollection<Soba>(sobe);

            Soba selSoba = SobeController.Instance.GetSobuById(termin.SifraSobe);
            SelectedSoba = selSoba;
        }
        private void OnPotvrdi()
        {
            DateTime datum = SelectedDatum;
            string vreme = SelectedVreme;
            string[] delovi = vreme.Split(':');
            int vremeSati = Int32.Parse(delovi[0]);
            int vremeMinuti = Int32.Parse(delovi[1]);
            DateTime datumVremeTermina = new DateTime(datum.Year, datum.Month, datum.Day, vremeSati, vremeMinuti, 0);

            Lekar lekar = LekariController.Instance.GetOdgLekarByJmbg(termin.JmbgLekara);
            int sifraSobe;
            if (SelectedSoba != null)
                sifraSobe = SelectedSoba.Sifra;
            else
                sifraSobe = termin.SifraSobe;

            Termin termin1 = new Termin(termin.JmbgPacijenta, false, datumVremeTermina, sifraSobe, termin.JmbgLekara);
            TerminiController.Instance.IzmeniTermin(termin, termin1);

            Lekar l = LekariController.Instance.GetOdgLekarByJmbg(termin.JmbgLekara);
            parent.frejm.Content = null;
            parent.frejm.Content = new PagePrikazTermina(parent, l.Jmbg);
            CloseAction();
        }
    }
}
