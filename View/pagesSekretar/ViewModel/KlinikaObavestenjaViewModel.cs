using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Controller;
using System.Collections.ObjectModel;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class KlinikaObavestenjaViewModel : BindableBase
    {
        private SekretarView parent;
        public MyICommand DeleteCommand { get; set; }
        public MyICommand TransferCommand { get; set; }
        public MyICommand AddCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        private Obavestenje selectedObavestenje;
        private ObservableCollection<Obavestenje> obavestenja;
        public KlinikaObavestenjaViewModel(SekretarView parent)
        {
            this.parent = parent;
            LoadObavestenja();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            TransferCommand = new MyICommand(OnTransfer, CanTransfer);
            AddCommand = new MyICommand(OnAdd);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public void LoadObavestenja() 
        {
            List<Obavestenje> ob = new List<Obavestenje>();
            ob = ObavestenjaController.Instance.GetSvaObavestenja();
            ObservableCollection<Obavestenje> obavestenja = new ObservableCollection<Obavestenje>(ob);
            Obavestenja = obavestenja;
        }
        public Obavestenje SelectedObavestenje
        {
            get { return selectedObavestenje; }
            set
            {
                selectedObavestenje = value;
                OnPropertyChanged("SelectedObavestenje");
                DeleteCommand.RaiseCanExecuteChanged();
                TransferCommand.RaiseCanExecuteChanged();
            }
        }
        public ObservableCollection<Obavestenje> Obavestenja 
        {
            get 
            {
                return obavestenja;
            } 
            set 
            {
                obavestenja = value;
                OnPropertyChanged("Obavestenja"); 
            } 
        }
        private bool CanDelete()
        {
            return SelectedObavestenje != null;
        }
        private void OnDelete()
        {
            ObavestenjaController.Instance.RemoveObavestenje(SelectedObavestenje);
            MessageBox.Show("Uspesno ste obrisali obavestenje");
            Obavestenja.Remove(SelectedObavestenje);
        }
        private bool CanTransfer() 
        {
            return SelectedObavestenje != null;
        }
        private void OnTransfer() 
        {
            IzmenaObavestenja io = new IzmenaObavestenja(parent, SelectedObavestenje.Id);
            parent._mainFrame.NavigationService.Navigate(io);
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnAdd() 
        {
            DodavanjeObavestenja dd = new DodavanjeObavestenja(parent);
            parent._mainFrame.NavigationService.Navigate(dd);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
    }
}
