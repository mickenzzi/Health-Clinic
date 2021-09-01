using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class IzmenaObavestenjaViewModel : BindableBase
    {
        private SekretarView parent;
        private string porukaText;
        private int idObavestenja;
        private Obavestenje obavestenje;
        public MyICommand IzmeniObavestenjeCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public IzmenaObavestenjaViewModel(SekretarView parent,int idObavestenja) 
        {
            this.parent = parent;
            this.idObavestenja = idObavestenja;
            LoadObavestenje();
            IzmeniObavestenjeCommand = new MyICommand(OnIzmeni);
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
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new KlinikaObavestenja(parent));
        }
        private void OnIzmeni() 
        {
            CurrentObavestenje.Poruka = PorukaText;
            CurrentObavestenje.Validate();
            if (CurrentObavestenje.IsValid)
            {
                KlinikaObavestenja ko = new KlinikaObavestenja(parent);
                ObavestenjaController.Instance.SetObavestenje(CurrentObavestenje);
                MessageBox.Show("Uspesno ste izmenili obavestenje.");
                parent._mainFrame.NavigationService.Navigate(ko);
            }
        }
        public void LoadObavestenje() 
        {
            CurrentObavestenje = ObavestenjaController.Instance.GetObavestenje(idObavestenja);
            PorukaText = CurrentObavestenje.Poruka;
        }
    }
}
