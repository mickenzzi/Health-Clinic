using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.Views;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class IzmenaAlergijeViewModel : BindableBase
    {
        private SekretarView parent;
        private int idAlergije;
        private string jmbg;
        private string sifraAlergije;
        private string nazivAlergije;
        private Alergija alergija;
        public MyICommand EditAlergijaCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public IzmenaAlergijeViewModel(SekretarView parent,int  idAlergije,string jmbg) 
        {
            this.parent = parent;
            this.idAlergije = idAlergije;
            this.jmbg = jmbg;
            LoadAlergija();
            EditAlergijaCommand = new MyICommand(OnIzmeni);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public string SifraAlergije 
        {
            get { return sifraAlergije; }
            set 
            {
                sifraAlergije = value;
                OnPropertyChanged("SifraAlergije");
            }
        }
        public string NazivAlergije 
        {
            get { return nazivAlergije; }
            set
            {
                nazivAlergije = value;
                OnPropertyChanged("NazivAlergije");
            }
        }
        public void LoadAlergija() 
        {
            alergija = AlergijaController.Instance.GetOdgAlergija(idAlergije);
            SifraAlergije = alergija.SifraAlergije;
            NazivAlergije = alergija.Naziv;
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnIzmeni() 
        {
            if (string.IsNullOrWhiteSpace(SifraAlergije) || string.IsNullOrWhiteSpace(NazivAlergije))
            {
                MessageBox.Show("Niste uneli podatke o alergiji.");
            }
            else
            {
                alergija.Naziv = NazivAlergije;
                alergija.SifraAlergije = SifraAlergije;
                AlergijaController.Instance.SetAlergija(alergija);
                IzmenaPacijenta ip = new IzmenaPacijenta(parent, jmbg);
                MessageBox.Show("Uspesno ste izmenili alergiju.");
                parent._mainFrame.NavigationService.Navigate(ip);
                
            }
        }
        private void OnBack() 
        {
            IzmenaPacijenta ip = new IzmenaPacijenta(parent, jmbg);
            parent._mainFrame.NavigationService.Navigate(ip);
        }
    }
}
