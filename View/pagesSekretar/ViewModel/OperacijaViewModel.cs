using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Controller;
using System.Collections.ObjectModel;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class OperacijaViewModel : BindableBase
    {
        private SekretarView parent;
        private string jmbg;
        private Termin selectedOperacija;
        public ObservableCollection<Termin> Operacije { get; set; }
        public MyICommand OtkaziOperacijuCommand { get; set; }
        public MyICommand PomeriOperacijuCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public OperacijaViewModel(SekretarView parent, string jmbg) 
        {
            this.parent = parent;
            this.jmbg = jmbg;
            LoadOperacije();
            OtkaziOperacijuCommand = new MyICommand(OnOtkazi, CanOtkazi);
            PomeriOperacijuCommand = new MyICommand(OnPomeri, CanPomeri);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public Termin SelectedOperacija 
        {
            get { return selectedOperacija; }
            set 
            { 
                selectedOperacija = value;
                OnPropertyChanged("SelectedOperacija");
                OtkaziOperacijuCommand.RaiseCanExecuteChanged();
                PomeriOperacijuCommand.RaiseCanExecuteChanged();
            }
        }
        public void LoadOperacije() 
        {
            Pacijent pacijent = new Pacijent();
            pacijent = PacijentiController.Instance.GetOdgPacijent(jmbg);
            List<Termin> term = new List<Termin>();
            term = TerminiController.Instance.GetOdgTermine(pacijent.Id, TipoviSobe.OperacionaSala);
            ObservableCollection<Termin> operacije  = new ObservableCollection<Termin>(term);
            Operacije = operacije; 
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
            return SelectedOperacija != null;
        }
        private void OnPomeri() 
        {
            PomeranjeOperacije po = new PomeranjeOperacije(parent, jmbg, SelectedOperacija.Sifra);
            parent._mainFrame.NavigationService.Navigate(po);
        }
        private bool CanOtkazi() 
        {
            return SelectedOperacija != null;
        }
        private void OnOtkazi() 
        {
            TerminiController.Instance.OtkaziOperaciju(SelectedOperacija);
            MessageBox.Show("Uspesno ste otkazali operaciju.");
            Operacije.Remove(SelectedOperacija);
        }
    }
}
