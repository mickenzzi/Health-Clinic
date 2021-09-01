using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Controller;
using System.Collections.ObjectModel;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;
using System;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class PacijentViewModel : BindableBase
    {
        private ObservableCollection<Pacijent> pp;
        private Pacijent selectedPacijent;
        private SekretarView parent;
        private string searchIme;
        public MyICommand TransferToIzmeniPacijentaCommand { get; set; }
        public MyICommand TransferToTerminPacijentaCommand { get; set; }
        public MyICommand ObrisiPacijentaCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public PacijentViewModel(SekretarView parent) 
        {
            this.parent = parent;
            LoadPacijente();
            TransferToIzmeniPacijentaCommand = new MyICommand(GoToIzmeni, CanIzmeni);
            TransferToTerminPacijentaCommand = new MyICommand(GoToTermin, CanGoToTermin);
            ObrisiPacijentaCommand = new MyICommand(OnObrisi, CanObrisi);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public void LoadPacijente() 
        {
            List<Pacijent> pac = new List<Pacijent>();
            pac = PacijentiController.Instance.GetSvePacijente();
            ObservableCollection<Pacijent> pacijenti = new ObservableCollection<Pacijent>(pac);
            Pacijenti = pacijenti;
        }
        public Pacijent SelectedPacijent 
        {
            get { return selectedPacijent; }
            set 
            {
                selectedPacijent = value;
                OnPropertyChanged("SelectedPacijent");
                TransferToIzmeniPacijentaCommand.RaiseCanExecuteChanged();
                TransferToTerminPacijentaCommand.RaiseCanExecuteChanged();
                ObrisiPacijentaCommand.RaiseCanExecuteChanged();
            }
        }
        public string SearchIme
        {
            get { return searchIme; }
            set
            {
                
                searchIme = value;
                OnPropertyChanged("SearchIme");

                List<Pacijent> pacijenti = new List<Pacijent>();
                List<Pacijent> pac = new List<Pacijent>();
                pac = PacijentiController.Instance.GetSvePacijente();
                foreach (Pacijent p in pac)
                {
                    if (p.Ime.StartsWith(searchIme) && searchIme != null && searchIme != "")
                    {
                        pacijenti.Add(p);
                    }
                }
                if (pacijenti.Count == 0)
                {
                    ObservableCollection<Pacijent> odgPacijenti = new ObservableCollection<Pacijent>(pac);
                    Pacijenti = odgPacijenti;

                }
                else
                {
                    ObservableCollection<Pacijent> odgPacijenti = new ObservableCollection<Pacijent>(pacijenti);
                    Pacijenti = odgPacijenti;
                }
            }
        }

        public ObservableCollection<Pacijent> Pacijenti
        {
            get
            {
                return pp;
            }
            set
            {
                pp = value;
                OnPropertyChanged("Pacijenti");
            }
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private bool CanIzmeni() 
        {
            return SelectedPacijent != null;
        }
        private bool CanObrisi() 
        {
            return SelectedPacijent != null;
        }
        private bool CanGoToTermin() 
        {
            return SelectedPacijent != null;
        }
        private void OnObrisi() 
        {
            PacijentiController.Instance.RemovePacijent(SelectedPacijent);
            MessageBox.Show("Uspesno ste izbrisali pacijenta.");
            Pacijenti.Remove(SelectedPacijent);
        }
        private void GoToIzmeni() 
        {
            IzmenaPacijenta ip = new IzmenaPacijenta(parent, SelectedPacijent.Jmbg);
            parent._mainFrame.NavigationService.Navigate(ip);
        }
        private void GoToTermin() 
        {
            TerminProzor tp = new TerminProzor(parent, SelectedPacijent.Jmbg);
            parent._mainFrame.NavigationService.Navigate(tp);
        }

        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new PacijentProzor(parent));
        }
    }
}
