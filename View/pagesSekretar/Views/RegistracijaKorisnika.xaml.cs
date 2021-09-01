using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Bolnica.Controller;
using System.Linq;

namespace Bolnica.View.pagesSekretar
{
    public partial class RegistracijaKorisnika : Page
    {
        private MainWindow parent;
        public RegistracijaKorisnika(MainWindow parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void Potvrdi(object sender, RoutedEventArgs e)
        {
            bool imeProvera=false;
            bool prezimeProvera = false ;
            bool jmbgProvera = false ;
            bool emailProvera;
            bool sifraProvera;
            string ime = ImeK.Text;
            if (ImeK.Text.Length == 0)
            {
                imeProvera = true;
            }
            else
            {
                if(ImeK.Text.Any(c=> c < 'A' || c > 'z')) 
                {
                    if(ImeK.Text.Any(c => c == '-')) 
                    {
                        imeProvera = false;
                    }
                    else 
                    {
                        imeProvera = true;
                    }
                }
                
            }
            string prezime = PrezimeK.Text;
            if (PrezimeK.Text.Length == 0)
            {
                prezimeProvera = true;
            }
            else
            {
                if (PrezimeK.Text.Any(c => c < 'A' || c > 'z'))
                {
                    if (PrezimeK.Text.Any(c => c == '-'))
                    {
                        prezimeProvera = false;
                    }
                    else
                    {
                        prezimeProvera = true;
                    }
                }
            }
            string jmbg = JmbgK.Text;
            if (JmbgK.Text.Length == 0)
            {
                jmbgProvera = true;
            }
            else
            {
                if (JmbgK.Text.Any(c => c < '0' || c > '9'))
                {
                    jmbgProvera = true;
                }
                else
                {
                    jmbgProvera = false;
                }
            }
            string email = EmailK.Text;
            if (EmailK.Text.Length == 0)
            {
                emailProvera = true;
            }
            else
            {
                emailProvera = false;
            }
            string sifra = Sifra1.Password;
            if (sifra.Length < 8 && sifra.Any(c => c <'0' && c > '9'))
            {
                Sifra2.Password = "";
                Sifra1.Password = "";
                MessageBox.Show("Lozinka nedovoljno jaka");
                sifraProvera = true;
            }
            else
            {
                sifraProvera = false;
            }
            if (Sifra1.Password.Length == 0)
            {
                sifraProvera = true;
            }
            else
            {
                sifraProvera = false;
            }
            string potvrdaSifre = Sifra2.Password;
            if (imeProvera == false || prezimeProvera == false || jmbgProvera == false || emailProvera == false || sifraProvera == false)
            {
                if (sifra != potvrdaSifre)
                {
                    MessageBox.Show("Uneli ste dve razlicite lozinke!");
                }
                else
                {
                    KorisnikController.Instance.AddKorisnik(ime, prezime, jmbg, email, sifra);
                    MainWindow mv = new MainWindow();
                    this.Visibility=Visibility.Hidden;
                    mv.Show();
                }
            }
            else
            {
                MessageBox.Show("Niste uneli sve podatke");
            }
        }
        private void Nazad(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
