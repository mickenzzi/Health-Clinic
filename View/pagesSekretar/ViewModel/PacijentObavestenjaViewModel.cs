using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Controller;
using System.Collections.ObjectModel;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class PacijentObavestenjaViewModel : BindableBase
    {
        private SekretarView parent;
        private int idPacijenta;
        private Obavestenje selectedObavestenjePacijenta;
        public ObservableCollection<Obavestenje> Obavestenja { get; set; }
        public ObservableCollection<Obavestenje> ObavestenjaPacijenta { get; set; }
        public MyICommand DeleteObavestenjeCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public PacijentObavestenjaViewModel(SekretarView parent,int idPacijenta) 
        {
            this.parent = parent;
            this.idPacijenta = idPacijenta;
            LoadObavestenja();
            LoadObavestenjaPacijenta(idPacijenta);
            DeleteObavestenjeCommand = new MyICommand(OnDelete, CanDelete);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public Obavestenje SelectedObavestenjePacijenta
        {
            get { return selectedObavestenjePacijenta; }
            set
            {
                selectedObavestenjePacijenta = value;
                OnPropertyChanged("SelectedObavestenjePacijenta");
                DeleteObavestenjeCommand.RaiseCanExecuteChanged();
            }
        }
        public void LoadObavestenjaPacijenta(int id)
        {
            List<Obavestenje> ob = new List<Obavestenje>();
            ob = ObavestenjaController.Instance.GetObavestenjaPacijenta(id);
            ObservableCollection<Obavestenje> obavestenja = new ObservableCollection<Obavestenje>(ob);
            ObavestenjaPacijenta = obavestenja;
        }
        public void LoadObavestenja()
        {
            List<Obavestenje> ob = new List<Obavestenje>();
            ob = ObavestenjaController.Instance.GetSvaObavestenja();
            ObservableCollection<Obavestenje> obavestenja = new ObservableCollection<Obavestenje>(ob);
            Obavestenja = obavestenja;
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new PrikazPacijenata(parent));
        }
        private bool CanDelete()
        {
            return SelectedObavestenjePacijenta != null;
        }
        private void OnDelete()
        {
            ObavestenjaController.Instance.RemoveObavestenje(SelectedObavestenjePacijenta);
            MessageBox.Show("Uspesno ste izbrisali obavestenje.");
            Obavestenja.Remove(SelectedObavestenjePacijenta);
        }
    }
}
