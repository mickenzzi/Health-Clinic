using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;
using System.Linq;
using System;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class GuestZakazivanjeViewModel : BindableBase
    {
        private SekretarView parent;
        private string ime;
        private string prezime;
        private string jmbg;
        private bool hitanSlucaj;
        private Pacijent pacijent = new Pacijent();
        public MyICommand GoToTerminCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public GuestZakazivanjeViewModel(SekretarView parent) 
        {
            this.parent = parent;
            GoToTerminCommand = new MyICommand(OnAdd);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
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

        public string Jmbg 
        {
            get { return jmbg; }
            set 
            {
                jmbg = value;
                OnPropertyChanged("Jmbg");
            }
        }

        public bool HitanSlucaj 
        {
            get { return hitanSlucaj; }
            set 
            {
                hitanSlucaj = value;
                OnPropertyChanged("HitanSlucaj");
            }
        }

        public Pacijent CurrentPacijent 
        {
            get { return pacijent; }
            set 
            { 
                pacijent = value;
                OnPropertyChanged("CurrentPacijent");
            }
        }

        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new PredZakazivanje(parent));
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnAdd() 
        {
            if (HitanSlucaj == true)
            {
                if (!string.IsNullOrWhiteSpace(Ime)) 
                {
                    if(Ime.Any(c => c > '0' && c < '9')) 
                    {

                        if (Ime.Any(c => c == '-'))
                        {
                            CurrentPacijent.Ime = Ime;
                        }
                        else
                        {
                            MessageBox.Show("Ime mora sadrzati samo slova.");
                        }
                    }
                    else if (!Char.IsUpper(Ime, 0)) 
                    {
                        MessageBox.Show("Ime mora pocinjati velikim slovom.");
                    }
                    else
                    {
                        CurrentPacijent.Ime = Ime;
                    }
                }
                else 
                {
                  CurrentPacijent.Ime = Ime;
                }

                if (!string.IsNullOrWhiteSpace(Prezime)) 
                {
                    if(Prezime.Any(c=> c> '0' && c < '9')) 
                    {
                        if (Prezime.Any(c => c == '-'))
                        {
                            CurrentPacijent.Prezime = Prezime;
                        }
                        else
                        {
                            MessageBox.Show("Prezime mora sadrzati samo slova.");
                        }
                    }
                    else if (!Char.IsUpper(Prezime, 0))
                    {
                        MessageBox.Show("Prezime mora pocinjati velikim slovom.");
                    }

                    else 
                    {
                        CurrentPacijent.Prezime = Prezime;
                    }
                }
                else 
                {
                    CurrentPacijent.Prezime = Prezime;
                }
                if (!string.IsNullOrWhiteSpace(Jmbg))
                {
                    if (Jmbg.Any(c => c < '0' || c > '9'))
                    {
                        MessageBox.Show("Jmbg mora sadrzati samo brojeve.");
                    }
                    else
                    {
                        CurrentPacijent.Jmbg = Jmbg;
                    }
                }

                CurrentPacijent.Validate();
                if (CurrentPacijent.IsValid)
                {
                    CurrentPacijent.HitanSlucaj = HitanSlucaj;
                    ZdravstveniKarton zdravstveniKarton = new ZdravstveniKarton();
                    zdravstveniKarton.Anamneza = "Nema anamneze";
                    zdravstveniKarton.Id = CurrentPacijent.IdZK;
                    zdravstveniKarton.IdPacijenta = CurrentPacijent.Id;
                    PacijentiController.Instance.AddPacijent(CurrentPacijent);
                    ZdravstveniKartoniController.Instance.AddZdravstveniKarton(zdravstveniKarton);
                    TerminProzor tp = new TerminProzor(parent, Jmbg);
                    MessageBox.Show("Uspesno ste kreirali guest nalog.");
                    parent._mainFrame.NavigationService.Navigate(tp);
                }
            }
            else 
            {
                MessageBox.Show("Ovo nije hitan slucaj.Prebacujete se na kreiranje obicnog naloga...");
                NormalnoZakazivanje nz = new NormalnoZakazivanje(parent);
                parent._mainFrame.NavigationService.Navigate(nz);
            }
        }
    }
}
