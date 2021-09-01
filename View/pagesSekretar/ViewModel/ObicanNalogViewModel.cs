using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.Controller;
using Bolnica.Model;
using System;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;
using System.Linq;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class ObicanNalogViewModel : BindableBase
    {
        private SekretarView parent;
        private string ime;
        private string prezime;
        private string datumRodjenja;
        private string mestoStanovanja;
        private bool hitanSlucaj;
        private string jmbg;
        private string pol;
        private string bracniStatus;
        private Pol polP;
        private BracniStatus bracniStatusP;
        private string telefon;
        private string ulica;
        public MyICommand AddObicanCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public ObicanNalogViewModel(SekretarView parent)
        {
            this.parent = parent;
            AddObicanCommand = new MyICommand(OnAdd);
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
        public string Telefon
        {
            get { return telefon; }
            set
            {
                telefon = value;
                OnPropertyChanged("Telefon");
            }
        }
        public string DatumRodjenja
        {
            get { return datumRodjenja; }
            set
            {
                datumRodjenja = value;
                OnPropertyChanged("DatumRodjenja");
            }
        }
        public string MestoStanovanja
        {
            get { return mestoStanovanja; }
            set
            {
                mestoStanovanja = value;
                OnPropertyChanged("MestoStanovanja");
            }
        }
        public string Ulica
        {
            get { return ulica; }
            set
            {
                ulica = value;
                OnPropertyChanged("Ulica");
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
        public string PolPacijenta
        {
            get { return pol; }
            set
            {
                pol = value;
                OnPropertyChanged("Pol");
            }
        }
        public string BracniStatusPacijenta
        {
            get { return bracniStatus; }
            set
            {
                bracniStatus = value;
                OnPropertyChanged("BracniStatus");
            }
        }
        public Pol PolP
        {
            get { return polP; }
            set
            {
                polP = value;
                OnPropertyChanged("PolP");
            }
        }
        public BracniStatus BracniStatusP
        {
            get { return bracniStatusP; }
            set
            {
                bracniStatusP = value;
                OnPropertyChanged("BracniStatusP");
            }
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new PacijentProzor(parent));
        }
        private void OnAdd() 
        {
            DateTime dt;
            bool flag;
            bool provera1;
            bool provera2;
            bool provera3;
            bool provera4;
            bool provera5;
            bool provera6;
            bool provera7;
            bool provera8;
            bool provera9;
            if (HitanSlucaj == true)
            {
                KreiranjeGuestNaloga kg = new KreiranjeGuestNaloga(parent);
                parent._mainFrame.NavigationService.Navigate(kg);
            }
            else
            {
                flag = PacijentiController.Instance.PotvrdaPostojanjaPacijenta(Jmbg);
                if (flag == true)
                {
                    PacijentProzor pp = new PacijentProzor(parent);
                    MessageBox.Show("Vas nalog vec postoji u evidenciji.");
                    parent._mainFrame.NavigationService.Navigate(pp);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(DatumRodjenja))
                    {
                        provera1 = false;
                        MessageBox.Show("Unesite datum rodjenja.");
                    }
                    else
                    {
                        if (DateTime.TryParse(DatumRodjenja, out dt))
                        {
                            provera1 = true;
                        }
                        else
                        {
                            provera1 = false;
                            MessageBox.Show("Unesite datum u odgovarajucem formatu.");
                        }
                    }
                    if (string.IsNullOrWhiteSpace(Ime))
                    {
                        provera2 = false;
                        MessageBox.Show("Unesite ime.");
                    }
                    else
                    {
                        if (Ime.Any(c => c < 'A' || c > 'z'))
                        {
                            if (Ime.Any(c => c == '-'))
                            {
                                provera2 = true;
                            }
                            else
                            {
                                MessageBox.Show("Ime mora da sadrzi samo slova.");
                                provera2 = false;
                            }
                        }
                        else if (!Char.IsUpper(Ime, 0)) 
                        {
                            provera2 = false;
                            MessageBox.Show("Ime mora pocinjati velikim slovom.");
                        }
                        else
                        {
                            provera2 = true;
                        }
                    }
                    if (string.IsNullOrWhiteSpace(Prezime))
                    {
                        provera3 = false;
                        MessageBox.Show("Unesite prezime.");
                    }
                    else
                    {
                        if (Prezime.Any(c => c < 'A' || c > 'z'))
                        {
                            if(Prezime.Any(c => c == '-')) 
                            {
                                provera3 = true;
                            }
                            else
                            {
                                MessageBox.Show("Prezime mora da sadrzi samo slova.");
                                provera3 = false; 
                            }
                        }
                        else if (!Char.IsUpper(Prezime, 0)) 
                        {
                            MessageBox.Show("Prezime mora pocinjati velikim slovom.");
                            provera3 = false;
                        }
                        else
                        {
                            provera3 = true;
                        }
                    }
                    if (string.IsNullOrWhiteSpace(Jmbg))
                    {
                        provera4 = false;
                        MessageBox.Show("Unesite jmbg.");
                    }
                    else
                    {
                        if (Jmbg.Any(c => c < '0' || c > '9'))
                        {
                            provera4 = false;
                            MessageBox.Show("Jmbg mora sadrzati samo brojeve.");
                        }
                        else
                        {
                            provera4 = true;
                        }
                    }

                    if (string.IsNullOrWhiteSpace(MestoStanovanja))
                    {
                        provera5 = false;
                        MessageBox.Show("Unesite mesto stanovanja.");
                    }
                    else
                    {
                        if (MestoStanovanja.Any(c => c < 'A' || c > 'z'))
                        {
                            if (MestoStanovanja.Any(c => c == ' '))
                            {
                                provera5 = true;
                            }
                            else
                            {
                                MessageBox.Show("Mesto stanovanja mora sadrzati samo slova.");
                                provera5 = false;
                            }
                        }
                        else
                        {
                            provera5 = true;
                        }
                    }

                    if (string.IsNullOrWhiteSpace(Telefon))
                    {
                        provera6 = false;
                        MessageBox.Show("Unesite kontakt telefon.");
                    }
                    else
                    {
                        provera6 = true;
                    }

                    if (string.IsNullOrWhiteSpace(Ulica))
                    {
                        provera7 = false;
                        MessageBox.Show("Unesite ulicu i broj stanovanja.");
                    }
                    else
                    {
                        provera7 = true;
                    }

                    if (string.IsNullOrWhiteSpace(PolPacijenta))
                    {
                        MessageBox.Show("Niste odabrali pol.");
                        provera8 = false;
                    }
                    else
                    {
                        provera8 = true;
                        if (PolPacijenta == "Muski")
                        {
                            PolP = Pol.Muski;
                        }
                        else
                        {
                            PolP = Pol.Zenski;
                        }
                    }
                    if (string.IsNullOrWhiteSpace(BracniStatusPacijenta))
                    {
                        provera9 = false;
                        MessageBox.Show("Niste odabrali bracni status.");
                    }
                    else
                    {
                        provera9 = true;
                        if (BracniStatusPacijenta == "NeozenjenNeudata")
                        {
                            BracniStatusP = BracniStatus.NeozenjenNeudata;
                        }
                        else if (BracniStatusPacijenta == "OzenjenUdata")
                        {
                            BracniStatusP = BracniStatus.OzenjenUdata;
                        }
                        else if (BracniStatusPacijenta == "UdovacUdovica")
                        {
                            BracniStatusP = BracniStatus.UdovacUdovica;
                        }
                        else
                        {
                            BracniStatusP = BracniStatus.RazvedenRazvedena;
                        }
                    }
                    if (provera1 == true && provera2 == true && provera3 == true && provera4 == true && provera5 == true && provera6 == true && provera7 == true && provera8 == true && provera9 == true )
                    {
                        DateTime datumR = DateTime.Parse(DatumRodjenja);
                        Pacijent pacijent = new Pacijent(Ime, Prezime, Jmbg, HitanSlucaj);
                        ZdravstveniKarton zdravstveniKarton = new ZdravstveniKarton(datumR, MestoStanovanja, Telefon, Ulica, PolP, BracniStatusP);
                        zdravstveniKarton.Id = pacijent.IdZK;
                        zdravstveniKarton.IdPacijenta = pacijent.Id;
                        zdravstveniKarton.Anamneza = "Nema anamneze";
                        PacijentiController.Instance.AddPacijent(pacijent);
                        ZdravstveniKartoniController.Instance.AddZdravstveniKarton(zdravstveniKarton);
                        PacijentProzor pp = new PacijentProzor(parent);
                        MessageBox.Show("Uspesno ste kreirali nalog.");
                        parent._mainFrame.NavigationService.Navigate(pp);
                    }
                }
            }
        }
    }
}
