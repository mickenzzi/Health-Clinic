using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;
using System.Linq;
using System;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class ZakazivanjeViewModel : BindableBase
    {
        private SekretarView parent;
        public MyICommand ProveriCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public ZakazivanjeViewModel(SekretarView parent) 
        {
            this.parent = parent;
            ProveriCommand = new MyICommand(OnProveri);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        private string ime;
        private string prezime;
        private string jmbg;
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
        public string Jmbg 
        {
            get { return jmbg; }
            set 
            {
                jmbg = value;
                OnPropertyChanged("Jmbg");
            }
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnProveri() 
        {
            bool flag;
            bool provera1;
            bool provera2;
            bool provera3;
            if(string.IsNullOrWhiteSpace(Ime)) 
            {
                provera1 = false;
                MessageBox.Show("Niste uneli ime.");
            }
            else 
            {
                if(Ime.Any(c => c > '0' && c < '9')) 
                {
                    provera1 = false;
                    MessageBox.Show("Ime ne moze sadrzati brojeve.");
                }
                else if (!Char.IsUpper(Ime, 0)) 
                {
                    provera1 = false;
                    MessageBox.Show("Ime mora pocinjati velikim slovom.");
                }
                else  
                {
                    provera1 = true;
                }
            }
            if (string.IsNullOrWhiteSpace(Prezime))
            {
                provera2 = false;
                MessageBox.Show("Niste uneli prezime.");
            }
            else
            {
                if (Prezime.Any(c => c > '0' && c < '9'))
                {
                    provera2 = false;
                    MessageBox.Show("Prezime ne moze sadrzati brojeve.");
                }
                else if (!Char.IsUpper(Prezime, 0)) 
                {
                    provera2 = false;
                    MessageBox.Show("Prezime mora pocinjati velikim slovom.");
                }
                else
                {
                    provera2 = true;
                }
            }

            if (string.IsNullOrWhiteSpace(Jmbg))
            {
                provera3 = false;
                MessageBox.Show("Niste uneli jmbg.");
            }
            else
            {
                provera3 = true;
            }
            if (provera1 == true && provera2 == true && provera3 == true)
            {
                flag = PacijentiController.Instance.PotvrdaPostojanjaPacijenta(Jmbg);
                if (flag == true)
                {
                    MessageBox.Show("Vas nalog vec postoji  u evidenciji.Prebacujete se na rad sa terminima...");
                    TerminProzor tp = new TerminProzor(parent, Jmbg);
                    parent._mainFrame.NavigationService.Navigate(tp);
                }
                else
                {
                    MessageBox.Show("Neophodno je prvo kreirati nalog.Prebacujete se na kreiranje guest naloga...");
                    GuestZakazivanje gz = new GuestZakazivanje(parent);
                    parent._mainFrame.NavigationService.Navigate(gz);
                }
            }
        }
    }
}
