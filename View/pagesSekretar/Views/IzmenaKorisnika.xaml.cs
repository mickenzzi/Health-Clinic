using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Bolnica.Model;
using Bolnica.Controller;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class IzmenaKorisnika : Page
    {
        private Korisnik korisnik;
        private SekretarView parent;
        public IzmenaKorisnika(SekretarView parent,string jmbg)
        {
            this.parent = parent;
            InitializeComponent();
            korisnik = KorisnikController.Instance.GetKorisnik(jmbg);
            Email.Text = korisnik.Email;
            Lozinka.Password = korisnik.Sifra;
            Lozinka1.Password = korisnik.Sifra;

        }
        private void IzmeniKorisnika(object sender, RoutedEventArgs e)
        {
            if (Email.Text == null || Email.Text=="")
            {
                MessageBox.Show("Niste uneli email korisnika.");
            }
            else {
                string novaLozinka;
                novaLozinka = Lozinka.Password;
                string kopijaLozinke;
                kopijaLozinke = Lozinka1.Password;
                if (novaLozinka == null || novaLozinka=="" || kopijaLozinke==null || kopijaLozinke=="")
                {
                    MessageBox.Show("Niste uneli sve podatke");
                }
                else
                {
                    if (novaLozinka != kopijaLozinke)
                    {
                        MessageBox.Show("Uneli ste razlicite lozinke.");
                    }
                    else
                    {
                        korisnik.Email = Email.Text;
                        korisnik.Sifra = Lozinka.Password;
                        KorisnikController.Instance.SetKorisnik(korisnik);
                        MessageBox.Show("Uspesno ste izmenili podatke");
                        parent._mainFrame.Content = new ProfilKorisnika(parent);
                    }
                }
            }
        }
        private void Nazad(object sender, MouseButtonEventArgs e)
        {
            parent._mainFrame.Content = new ProfilKorisnika(parent);
        }
    }
}
