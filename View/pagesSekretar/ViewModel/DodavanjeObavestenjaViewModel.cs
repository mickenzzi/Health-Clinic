using Bolnica.Model;
using Bolnica.Controller;
using System.Collections.ObjectModel;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class DodavanjeObavestenjaViewModel : BindableBase
    {
        private SekretarView parent;
        public MyICommand AddObavestenjeCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public ObservableCollection<Obavestenje> Obavestenja { get; set; }
        private string porukaText;
        private Obavestenje obavestenje = new Obavestenje();
        public DodavanjeObavestenjaViewModel(SekretarView parent)
        {
            this.parent = parent;
            AddObavestenjeCommand = new MyICommand(OnAdd);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public string PorukaText
        {
            get { return porukaText; }
            set
            {
                if (porukaText != value)
                {
                    porukaText = value;
                    OnPropertyChanged("PorukaText");
                }
            }
        }
        public Obavestenje CurrentObavestenje
        {
            get { return obavestenje; }
            set
            {
                obavestenje = value;
                OnPropertyChanged("CurrentObavestenje");
            }
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new KlinikaObavestenja(parent));
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnAdd() 
        {
            CurrentObavestenje.Poruka = PorukaText;
            CurrentObavestenje.Validate();
            if (CurrentObavestenje.IsValid)
            {
                ObavestenjaController.Instance.AddObavestenje(CurrentObavestenje);
                KlinikaObavestenja ko = new KlinikaObavestenja(parent);
                MessageBox.Show("Uspesno ste dodali obavestenje.");
                parent._mainFrame.NavigationService.Navigate(ko);
            }
        }
    }
}
