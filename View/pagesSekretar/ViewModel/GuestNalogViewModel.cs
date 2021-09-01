using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;
using System.Linq;
using System;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class GuestNalogViewModel : BindableBase
    {
        private SekretarView parent;
        private string ime;
        private string prezime;
        private string jmbg;
        private bool hitanSlucaj;
        private bool flag;
        private Pacijent pacijent = new Pacijent();
        public MyICommand AddGuestCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public GuestNalogViewModel(SekretarView parent)
        {
            this.parent = parent;
            AddGuestCommand = new MyICommand(OnKreiraj);
            BackCommand = new MyICommand(OnBack);
        }
        public string Ime 
        {
            get { return ime; }
            set 
            {
                if (ime != value)
                {
                    ime = value;
                    OnPropertyChanged("Ime");
                }
            }
        }
        public string Prezime 
        {
            get { return prezime; }
            set 
            {
                if (prezime != value)
                {
                    prezime = value;
                    OnPropertyChanged("Prezime");
                }
            }
        }
        public string Jmbg 
        {
            get { return jmbg; }
            set 
            {
                if (jmbg != value)
                {
                    jmbg = value;
                    OnPropertyChanged("Jmbg");
                }
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
            parent._mainFrame.NavigationService.Navigate(new PacijentProzor(parent));
        }
        private void OnKreiraj() 
        {
            bool provera1=false;
            bool provera2=false;
            bool provera3 = false;
            if (HitanSlucaj == true) 
            {
                flag = PacijentiController.Instance.PotvrdaPostojanjaPacijenta(Jmbg);
                if (flag == true)
                {
                    PacijentProzor pp = new PacijentProzor(parent);
                    MessageBox.Show("Vas nalog vec postoji u nasem sistemu.");
                    parent._mainFrame.NavigationService.Navigate(pp);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(Ime))
                    {
                        if (Ime.Any(c => c < 'A' || c > 'z')) 
                        {

                            if (Ime.Any(c => c == '-'))
                            {
                                provera1 = true;
                            }
                            else
                            {
                                provera1 = false;
                                MessageBox.Show("Ime mora sadrzati samo slova.");
                            }
                        }
                        else if (!Char.IsUpper(Ime,0)) 
                        {
                            MessageBox.Show("Ime mora pocinjati velikim slovom.");
                            provera1 = false;
                        }
                        else 
                        {
                            provera1 = true;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(Prezime))
                    {
                        if (Prezime.Any(c => c >= '0' && c <= '9'))
                        {
                            if (Prezime.Any(c => c == '-'))
                            {
                                provera2 = true;
                            }
                            else
                            {
                                provera2 = false;
                                MessageBox.Show("Prezime mora sadrzati samo slova.");
                            }
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
                    if (!string.IsNullOrWhiteSpace(Jmbg))
                    {
                        if (Jmbg.Any(c => c < '0' || c > '9'))
                        {
                            MessageBox.Show("Jmbg mora sadrzati samo brojeve.");
                            provera3 = false;
                        }
                        else
                        {
                            provera3 = true;
                        }
                    }
                    CurrentPacijent.Ime = Ime;
                    CurrentPacijent.Prezime = Prezime;
                    CurrentPacijent.Jmbg = Jmbg;
                    CurrentPacijent.Validate();
                    if (CurrentPacijent.IsValid && provera1 == true && provera2 == true && provera3==true)
                    {
                        CurrentPacijent.HitanSlucaj = HitanSlucaj;
                        ZdravstveniKarton zdravstveniKarton = new ZdravstveniKarton();
                        zdravstveniKarton.Anamneza = "Nema anamneze";
                        zdravstveniKarton.Id = CurrentPacijent.IdZK;
                        zdravstveniKarton.IdPacijenta = CurrentPacijent.Id;
                        PacijentiController.Instance.AddPacijent(CurrentPacijent);
                        ZdravstveniKartoniController.Instance.AddZdravstveniKarton(zdravstveniKarton);
                        PacijentProzor pp = new PacijentProzor(parent);
                        MessageBox.Show("Uspesno ste kreirali guest nalog.");
                        parent._mainFrame.NavigationService.Navigate(pp);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Ovo nije hitan slucaj.Prebacujete se na kreiranje obicnog naloga...");
                KreiranjeObicnogNaloga ko = new KreiranjeObicnogNaloga(parent);
                parent._mainFrame.NavigationService.Navigate(ko);
            }
        }
    }
}
