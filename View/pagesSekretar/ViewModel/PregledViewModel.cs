using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Controller;
using System.Collections.ObjectModel;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class PregledViewModel : BindableBase 
    {
        private SekretarView parent;
        private string jmbg;
        private Termin selectedPregled;
        public ObservableCollection<Termin> Pregledi { get; set; }
        public MyICommand OtkaziPregledCommand { get; set; }
        public MyICommand PomeriPregledCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public PregledViewModel(SekretarView parent, string jmbg)
        {
            this.parent = parent;
            this.jmbg = jmbg;
            LoadPreglede();
            OtkaziPregledCommand = new MyICommand(OnOtkazi, CanOtkazi);
            PomeriPregledCommand = new MyICommand(OnPomeri, CanPomeri);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public Termin SelectedPregled
        {
            get { return selectedPregled; }
            set
            {
                selectedPregled = value;
                OnPropertyChanged("SelectedOperacija");
                OtkaziPregledCommand.RaiseCanExecuteChanged();
                PomeriPregledCommand.RaiseCanExecuteChanged();
            }
        }
        public void LoadPreglede()
        {
            Pacijent pacijent = new Pacijent();
            pacijent = PacijentiController.Instance.GetOdgPacijent(jmbg);
            List<Termin> term = new List<Termin>();
            term = TerminiController.Instance.GetOdgTermine(pacijent.Id, TipoviSobe.Ordinacija);
            ObservableCollection<Termin> pregledi = new ObservableCollection<Termin>(term);
            Pregledi = pregledi;
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new TerminProzor(parent, jmbg));
        }
        private bool CanPomeri()
        {
            return SelectedPregled != null;
        }
        private void OnPomeri()
        {
            PomeranjePregleda po = new PomeranjePregleda(parent, jmbg, SelectedPregled.Sifra);
            parent._mainFrame.NavigationService.Navigate(po);
        }
        private bool CanOtkazi()
        {
            return SelectedPregled != null;
        }
        private void OnOtkazi()
        {
            TerminiController.Instance.OtkaziPregled(SelectedPregled);
            MessageBox.Show("Uspesno ste otkazali pregled.");
            Pregledi.Remove(SelectedPregled);
        }
    }
}
