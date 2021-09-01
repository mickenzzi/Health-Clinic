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
    public class LekarViewModel : BindableBase
    {
        private SekretarView parent;
        private ObservableCollection<Lekar> ll;
        public MyICommand DeleteLekarCommand { get; set; }
        public MyICommand EditLekarCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        private string searchIme;
        private Lekar selectedLekar;
        public LekarViewModel(SekretarView parent) 
        {
            this.parent = parent;
            LoadLekari();
            DeleteLekarCommand = new MyICommand(OnDelete,CanDelete);
            EditLekarCommand = new MyICommand(OnIzmeni, CanIzmeni);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public void LoadLekari() 
        {
            List<Lekar> lek = new List<Lekar>();
            lek = LekariController.Instance.GetSviLekari();
            ObservableCollection<Lekar> lekari = new ObservableCollection<Lekar>(lek);
            Lekari = lekari;
        }
        public Lekar SelectedLekar
        {
            get { return selectedLekar; }
            set
            {   
                selectedLekar = value;
                OnPropertyChanged("SelectedLekar");
                DeleteLekarCommand.RaiseCanExecuteChanged();
                EditLekarCommand.RaiseCanExecuteChanged();
            }
        }
        public ObservableCollection<Lekar> Lekari
        {
            get
            {
                return ll;
            }
            set
            {
                ll = value;
                OnPropertyChanged("Lekari");
            }
        }
        public string SearchIme 
        {
            get { return searchIme; }
            set 
            {
                searchIme = value;
                OnPropertyChanged("SearchIme");

                List<Lekar> lekari = new List<Lekar>();
                List<Lekar> lek = new List<Lekar>();
                lek = LekariController.Instance.GetSviLekari();
                foreach (Lekar l in lek)
                {
                    if (l.Ime.StartsWith(searchIme) && searchIme != null && searchIme != "")
                    {
                        lekari.Add(l);
                    }
                }
                if (lekari.Count == 0)
                {
                    ObservableCollection<Lekar> odgLekari = new ObservableCollection<Lekar>(lek);
                    Lekari = odgLekari;

                }
                else
                {
                    ObservableCollection<Lekar> odgLekari = new ObservableCollection<Lekar>(lekari);
                    Lekari = odgLekari;
                }
            }
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new LekarProzor(parent));
        }
        private bool CanIzmeni() 
        {
            return SelectedLekar != null;
        }
        private void OnIzmeni() 
        {
            IzmenaLekara il = new IzmenaLekara(parent, SelectedLekar.Id);
            parent._mainFrame.NavigationService.Navigate(il);
        }
        private bool CanDelete()
        {
            return SelectedLekar != null;
        }

        private void OnDelete()
        {

            LekariController.Instance.RemoveLekar(SelectedLekar);
            Lekari.Remove(SelectedLekar);
            MessageBox.Show("Uspesno ste izbrisali lekara.");
        }
    }
}
