using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;

namespace Bolnica.View.pagesSekretar.ViewModel 
{
    public class ProfilKorisnikaViewModel : BindableBase
    {
        private SekretarView parent;
        private string jmbg;
        private string ime;
        private string prezime;
        private string email;
        public MyICommand GoToIzmenaCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public ProfilKorisnikaViewModel(SekretarView parent,string jmbg) 
        {
            this.parent = parent;
            this.jmbg = jmbg;
            LoadKorisnik();
            GoToIzmenaCommand = new MyICommand(OnToIzmeni);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public string Jmbg 
        {
            get { return jmbg; }
            set 
            { 
                jmbg = value;
                OnPropertyChanged("Jmbg");
            }
        }
        public string Ime 
        {
            get { return ime; }
            set 
            { 
                ime = value;
                OnPropertyChanged("Ime");
            }
        }
        public string Prezime 
        {
            get { return prezime; }
            set 
            { 
                prezime = value;
                OnPropertyChanged("Prezime");
            }
        }
        public string Email 
        {
            get { return email; }
            set 
            { 
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public void LoadKorisnik() 
        {
            Korisnik korisnik = new Korisnik();
            korisnik = KorisnikController.Instance.GetKorisnik(jmbg);
            Ime = korisnik.Ime;
            Prezime = korisnik.Prezime;
            Email = korisnik.Email;
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnToIzmeni() 
        {
            IzmenaKorisnika ik = new IzmenaKorisnika(parent, jmbg);
            parent._mainFrame.NavigationService.Navigate(ik);
        }
    }
}
