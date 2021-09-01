using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{ 
    public class DodavanjeAlergijaViewModel : BindableBase
    {
        private SekretarView parent;
        private string sifraAlergije;
        private string nazivAlergije;
        private string jmbg;
        private Alergija alergija = new Alergija();
        public MyICommand AddAlergijaCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public DodavanjeAlergijaViewModel(SekretarView parent,string jmbg) 
        {
            this.parent = parent;
            this.jmbg = jmbg; ;
            AddAlergijaCommand = new MyICommand(OnAdd);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public string SifraAlergije 
        {
            get { return sifraAlergije; }
            set 
            {
                if (sifraAlergije != value)
                {
                    sifraAlergije = value;
                    OnPropertyChanged("SifraAlergije");
                }
            }
        }
        public string NazivAlergije 
        {
            get { return nazivAlergije; }
            set 
            {
                if (nazivAlergije != value)
                {
                    nazivAlergije = value;
                    OnPropertyChanged("NazivAlergije");
                }
            }
        }
        private void OnBack() 
        {
            IzmenaPacijenta ip = new IzmenaPacijenta(parent, jmbg);
            parent._mainFrame.NavigationService.Navigate(ip);
        }
        public Alergija CurrentAlergija
        {
            get { return alergija; }
            set
            {
                alergija = value;
                OnPropertyChanged("CurrentAlergija");
            }
        }
        private void OnHome() 
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnAdd() 
        {
            Pacijent pacijent = new Pacijent();
            pacijent = PacijentiController.Instance.GetOdgPacijent(jmbg);
            CurrentAlergija.SifraAlergije = SifraAlergije;
            CurrentAlergija.Naziv = NazivAlergije;
            CurrentAlergija.IdKartonaPacijenta = pacijent.IdZK;
            CurrentAlergija.Validate();
            if (CurrentAlergija.IsValid)
            {
                AlergijaController.Instance.AddAlergija(CurrentAlergija);
                IzmenaPacijenta ip = new IzmenaPacijenta(parent, jmbg);
                MessageBox.Show("Uspesno ste dodali alergiju.");
                parent._mainFrame.NavigationService.Navigate(ip);

            }
        }
    }
}
