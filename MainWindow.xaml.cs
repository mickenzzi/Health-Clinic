using Bolnica.Model;
using Bolnica.View;
using System;
using System.Windows;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.Views;
using Bolnica.View.pagesSekretar;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Pacijent p;
        public static Upravnik u;
        public static Sekretar s;
        public static Lekar l;
        public static PacijentView pv;
        public static UpravnikView uv;
        public static SekretarView sv;
        public static LekarView lv;

        private static MainWindow instance = null;

        public static MainWindow Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainWindow();
                }
                return instance;
            }
        }

        


        public MainWindow()
        {
            InitializeComponent();
        }

        


        private void Prosledi(object sender, RoutedEventArgs e)
        {
            String ime = Korisnik.Text;
            String lozinka = Sifra.Password;
         
            
            if (ime == "sibin")
            {
                if (lozinka == "ftn1") 
                {
                    u = new Upravnik();
                    uv = new UpravnikView();
                    this.Hide();
                    uv.Show();
                }
                else
                {
                    MessageBox.Show("Vasa lozinka je neispravna", "Prijava", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if(ime == "dejan") 
            {
                if (lozinka == "ftn2") 
                {
                    p = new Pacijent();
                    pv = new PacijentView();
                    this.Hide();
                    pv.Show();
                }
                else
                {
                    MessageBox.Show("Vasa lozinka je neispravna", "Prijava", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if(ime == "vlada") 
            {
                if (lozinka == "ftn3") 
                {
                    l = new Lekar();
                    lv = new LekarView();
                    this.Hide();
                    lv.Show();
                }
                else
                {
                    MessageBox.Show("Vasa lozinka je neispravna", "Prijava", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (ime == "milorad") 
            {
                string sifra;
                sifra = KorisnikController.Instance.GetLozinka("2212998180850");
                if (lozinka == sifra) 
                {
                    s = new Sekretar();
                    sv = new SekretarView();
                    this.Hide();
                    sv.Show();
                }
                else 
                {
                    MessageBox.Show("Vasa lozinka je neispravna", "Prijava", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            else 
            {
                MessageBox.Show("Uneli ste pogresno korisnicko ime", "Prijava",MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Registracija(object sender, RoutedEventArgs e)
        {
            View.pagesSekretar.RegistracijaKorisnika reg = new RegistracijaKorisnika(this);
            _mainWindow.NavigationService.Navigate(reg);
        }
    }
}
