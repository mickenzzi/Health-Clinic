using Bolnica.Model;
using Bolnica.Controller;
using System.Collections.ObjectModel;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using System.Collections.Generic;
using System;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;
using System.Linq;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class IzmenaPacijentaViewModel : BindableBase
    {
        private SekretarView parent;
        private Pacijent pacijent;
        private ZdravstveniKarton zdravstveniKarton;
        public MyICommand EditPacijentCommand { get; set; }
        public MyICommand GoToObavestenjaCommand { get; set; }
        public MyICommand GoToIzmeniAlergijuCommand { get; set; }
        public MyICommand RemoveAlergijaCommand { get; set; }
        public MyICommand GoToDodavanjeAlergijeCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public ObservableCollection<Alergija> Alergije { get; set; }
        private Alergija selectedAlergija;
        private string jmbgPacijenta;
        private string imePacijenta;
        private string prezimePacijenta;
        private string telefonPacijenta;
        private string datumRodjenjaPacijenta;
        private string mestoStanovanjaPacijenta;
        private string ulicaPacijenta;
        private bool hitanSlucaj;
        private string bracniStatusPacijentaIndex;
        private string polPacijentaIndex;
        private Pol polPacijenta;
        private BracniStatus bracniStatusPacijenta;
        private bool hitanSlucajCheck;
        public IzmenaPacijentaViewModel(SekretarView parent,string jmbg) 
        {
            this.parent = parent;
            this.jmbgPacijenta = jmbg;
            LoadPacijent();
            EditPacijentCommand = new MyICommand(OnIzmeni);
            GoToObavestenjaCommand = new MyICommand(GoToObavestenja);
            RemoveAlergijaCommand = new MyICommand(OnDeleteAlergija, CanDeleteAlergija);
            GoToIzmeniAlergijuCommand = new MyICommand(GoToIzmeniAlergiju, CanIzmeniAlergiju);
            GoToDodavanjeAlergijeCommand = new MyICommand(OnDodajAlergiju);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public string ImePacijenta 
        {
            get { return imePacijenta; }
            set 
            {
                imePacijenta = value;
                OnPropertyChanged("ImePacijenta");
            }
        }
        public string PrezimePacijenta 
        {
            get { return prezimePacijenta; }
            set 
            {
                prezimePacijenta = value;
                OnPropertyChanged("PrezimePacijenta");
            }
        }
        public string JmbgPacijenta 
        {
            get { return jmbgPacijenta; }
            set
            {
                jmbgPacijenta = value;
                OnPropertyChanged("JmbgPacijenta");
            }
        }
        public string TelefonPacijenta 
        {
            get { return telefonPacijenta; }
            set
            {
                telefonPacijenta = value;
                OnPropertyChanged("TelefonPacijenta");
            }
        }
        public string DatumRodjenjaPacijenta 
        {
            get { return datumRodjenjaPacijenta; }
            set 
            {
                datumRodjenjaPacijenta = value;
                OnPropertyChanged("DatumRodjenjaPacijenta");
            }
        }
        public string MestoStanovanjaPacijenta 
        {
            get { return mestoStanovanjaPacijenta; }
            set 
            {
                mestoStanovanjaPacijenta = value;
                OnPropertyChanged("MestoStanovanjaPacijenta");
            }
        }
        public string UlicaPacijenta
        {
            get { return ulicaPacijenta; }
            set
            {
                ulicaPacijenta = value;
                OnPropertyChanged("UlicaPacijenta");
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
        public bool HitanSlucajCheck
        {
            get { return hitanSlucajCheck; }
            set 
            {
                hitanSlucajCheck = value;
                OnPropertyChanged("HitanSlucajCheck");
            }
        }
        public string PolPacijenta 
        {
            get { return polPacijentaIndex; }
            set 
            {
                polPacijentaIndex = value;
                OnPropertyChanged("PolPacijenta");
            }
        }
        public string BracniStatusPacijenta 
        {
            get { return bracniStatusPacijentaIndex; }
            set
            {
                bracniStatusPacijentaIndex = value;
                OnPropertyChanged("BracniStatusPacijenta");
            }
        }
        public Pol PolPacijentaP 
        {
            get { return polPacijenta; }
            set 
            { 
                polPacijenta = value;
                OnPropertyChanged("PolPacijentaP");
            }
        }
        public BracniStatus BracniStatusPacijentaP
        {
            get { return bracniStatusPacijenta; }
            set 
            {
                bracniStatusPacijenta = value;
                OnPropertyChanged("BracniStatusPacijentaP");
            }
        }
        public void LoadAlergije(int idk) 
        {
            List<Alergija> aler = new List<Alergija>();
            aler = AlergijaController.Instance.GetSveAlergije(idk);
            ObservableCollection<Alergija> alergije = new ObservableCollection<Alergija>(aler);
            Alergije = alergije;
        }
        public Alergija SelectedAlergija
        {
            get { return selectedAlergija; }
            set
            {
                selectedAlergija = value;
                OnPropertyChanged("SelectedAlergija");
                GoToDodavanjeAlergijeCommand.RaiseCanExecuteChanged();
                GoToIzmeniAlergijuCommand.RaiseCanExecuteChanged();
                RemoveAlergijaCommand.RaiseCanExecuteChanged();
            }
        }
        private bool CanIzmeniAlergiju() 
        {
            return SelectedAlergija != null;
        }
        private void GoToIzmeniAlergiju() 
        {
            IzmenaAlergije ia = new IzmenaAlergije(parent, SelectedAlergija.Sifra, pacijent.Jmbg);
            parent._mainFrame.NavigationService.Navigate(ia);
        }
        private bool CanDeleteAlergija() 
        {
            return SelectedAlergija != null;
        }
        private void OnDeleteAlergija() 
        {
            AlergijaController.Instance.RemoveAlergija(SelectedAlergija);
            MessageBox.Show("Uspesno ste izbrisali alergiju");
            Alergije.Remove(SelectedAlergija);
        }
        private void OnDodajAlergiju() 
        {
            DodavanjeAlergije da = new DodavanjeAlergije(parent, pacijent.Jmbg);
            parent._mainFrame.NavigationService.Navigate(da);
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        public void LoadPacijent() 
        {
            pacijent = PacijentiController.Instance.GetOdgPacijent(jmbgPacijenta);
            zdravstveniKarton = ZdravstveniKartoniController.Instance.GetOdgKarton(pacijent.Id);
            ImePacijenta = pacijent.Ime;
            PrezimePacijenta = pacijent.Prezime;
            JmbgPacijenta = pacijent.Jmbg;
            HitanSlucaj = pacijent.HitanSlucaj;
            if (HitanSlucaj == true) 
            {
                HitanSlucajCheck = true;
            }
            else 
            {
                HitanSlucajCheck = false;
            }
            DatumRodjenjaPacijenta = zdravstveniKarton.DatumRodjenja.ToString();
            MestoStanovanjaPacijenta = zdravstveniKarton.MestoStanovanja;
            UlicaPacijenta = zdravstveniKarton.UlicaIbroj;
            TelefonPacijenta = zdravstveniKarton.Telefon;
            if (zdravstveniKarton.Pol == Pol.Muski) 
            {
                PolPacijenta = "Muski";
            }
            else 
            {
                PolPacijenta = "Zenski";
            }

            if (zdravstveniKarton.BracniStatus == BracniStatus.NeozenjenNeudata)
            {
                BracniStatusPacijenta = "NeozenjenNeudata";
            }
            else if(zdravstveniKarton.BracniStatus == BracniStatus.OzenjenUdata)
            {
                BracniStatusPacijenta = "OzenjenUdata";
            }
            else if(zdravstveniKarton.BracniStatus == BracniStatus.RazvedenRazvedena)
            {
                BracniStatusPacijenta = "RazvedenRazvedena" ;
            }
            else 
            {
                BracniStatusPacijenta = "UdovacUdovica";
            }

            PolPacijentaP = zdravstveniKarton.Pol;
            BracniStatusPacijentaP = zdravstveniKarton.BracniStatus;
            LoadAlergije(zdravstveniKarton.Id);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new PrikazPacijenata(parent));
        }
        private void OnIzmeni()
        {
            DateTime outd;
            bool provera1 = true;
            bool provera2 = true;
            bool provera3 = true;
            bool provera4 = true;
            bool provera5 = true;
            bool provera6 = true;
            bool provera7 = true;
            if (!string.IsNullOrWhiteSpace(ImePacijenta))
            {
                if (ImePacijenta.Any(c => c <'A' || c > 'z'))
                {
                    if (ImePacijenta.Any(c => c == '-'))
                    {
                        provera1 = true;
                        pacijent.Ime = ImePacijenta;
                    }
                    else
                    {
                        provera1 = false;
                        MessageBox.Show("Ime pacijenta mora sadrzati samo slova.");
                    }
                }
                else if (!Char.IsUpper(ImePacijenta, 0)) 
                {
                    MessageBox.Show("Ime mora pocinjati velikim slovom.");
                    provera1 = false;
                }
                else
                {
                    provera1 = true;
                    pacijent.Ime = ImePacijenta;
                }

            }
            else
            {
                provera1 = false;
                MessageBox.Show("Unesite ime pacijenta.");
            }

            if (!string.IsNullOrWhiteSpace(PrezimePacijenta))
            {
                if (PrezimePacijenta.Any(c => c < 'A' || c > 'z'))
                {
                    if (PrezimePacijenta.Any(c => c == '-'))
                    {
                        provera2 = true;
                        pacijent.Prezime = PrezimePacijenta;
                    }
                    else
                    {
                        provera1 = false;
                        MessageBox.Show("Prezime pacijenta mora sadrzati samo slova.");
                    }
                }
                else if (!Char.IsUpper(PrezimePacijenta, 0)) 
                {
                    provera2 = false;
                    MessageBox.Show("Prezime mora pocinjati velikim slovom.");
                }
                else
                {
                    provera2 = true;
                    pacijent.Prezime = PrezimePacijenta;
                }

            }
            else
            {
                provera2 = false;
                MessageBox.Show("Unesite prezime pacijenta.");
            }
            if(!string.IsNullOrWhiteSpace(JmbgPacijenta)) 
            {
                if(JmbgPacijenta.Any(c => c < '0' || c> '9')) 
                {
                    MessageBox.Show("Jmbg mora sadrzati samo brojeve.");
                    provera7 = false;
                }
                else 
                {
                    pacijent.Jmbg = JmbgPacijenta;
                    provera7 = true;
                }
            }
            else 
            {
                provera7 = false;
                MessageBox.Show("Unesite jmbg pacijenta.");
            }
           
            if (HitanSlucajCheck == true) 
            {
                HitanSlucaj = true;
                pacijent.HitanSlucaj = HitanSlucaj;
            }
            else 
            {
                HitanSlucaj = false;
                pacijent.HitanSlucaj = HitanSlucaj;
            }

            if (string.IsNullOrWhiteSpace(DatumRodjenjaPacijenta)) 
            {
                provera3 = false;
                MessageBox.Show("Unesite datum rodjenja pacijenta.");
            }
            else 
            {
                if (DateTime.TryParse(DatumRodjenjaPacijenta,out outd)) 
                {
                    provera3 = true;
                    zdravstveniKarton.DatumRodjenja = DateTime.Parse(DatumRodjenjaPacijenta);
                }
                else 
                {
                    provera3 = false;
                    MessageBox.Show("Niste uneli datum u odgovarajucem formatu.");   
                }
            }

            if (string.IsNullOrWhiteSpace(MestoStanovanjaPacijenta))
            {
                provera4 = false;
                MessageBox.Show("Unesite mesto stanovanja gde pacijent zivi.");
            }
            else
            {
                if (MestoStanovanjaPacijenta.Any(c => c < 'A' || c > 'z'))
                {
                    if (MestoStanovanjaPacijenta.Any(c => c == ' '))
                    {
                        provera4 = true;
                        zdravstveniKarton.MestoStanovanja = MestoStanovanjaPacijenta;
                    }
                    else
                    {
                        MessageBox.Show("Mesto stanovanja mora sadrzati samo slova.");
                        provera4 = false;
                    }
                }
                else
                {
                    provera4 = true;
                    zdravstveniKarton.MestoStanovanja = MestoStanovanjaPacijenta;
                }
            }

            if (string.IsNullOrWhiteSpace(TelefonPacijenta)) 
            {
                provera5 = false;
                MessageBox.Show("Unesite kontakt telefon pacijenta.");
            }
            else 
            {
                provera5 = true;
                zdravstveniKarton.Telefon = TelefonPacijenta;
            }
            if (string.IsNullOrWhiteSpace(UlicaPacijenta))
            {
                provera6 = false;
                MessageBox.Show("Unesite ulicu gde pacijent zivi.");
            }
            else
            {
                provera6 = true;
                zdravstveniKarton.UlicaIbroj = UlicaPacijenta;
            }
            
            if (PolPacijenta == "Zenski")
            {
                PolPacijentaP = Pol.Zenski;
            }
            else
            {
                PolPacijentaP = Pol.Muski;
            }

            if (BracniStatusPacijenta == "NeozenjenNeudata")
            {
                BracniStatusPacijentaP = BracniStatus.NeozenjenNeudata;
            }
            else if (BracniStatusPacijenta == "OzenjenUdata")
            {
                BracniStatusPacijentaP = BracniStatus.OzenjenUdata;
            }
            else if (BracniStatusPacijenta == "RazvedenRazvedena")
            {
                BracniStatusPacijentaP = BracniStatus.RazvedenRazvedena;
            }
            else
            {
                BracniStatusPacijentaP = BracniStatus.UdovacUdovica;
            }

            zdravstveniKarton.Pol = PolPacijentaP;
            zdravstveniKarton.BracniStatus = BracniStatusPacijentaP;
            if (provera1 == true && provera2 == true && provera3 == true && provera4 == true && provera5 == true && provera6 == true && provera7==true)
            {
                PacijentiController.Instance.SetPacijent(pacijent);
                ZdravstveniKartoniController.Instance.SetKarton(zdravstveniKarton);
                PrikazPacijenata pp = new PrikazPacijenata(parent);
                parent._mainFrame.NavigationService.Navigate(pp);
                MessageBox.Show(("Uspesno ste izmenili pacijenta."));
            }
        }
        public void GoToObavestenja() 
        {
            PrikazObavestenja po = new PrikazObavestenja(pacijent.Id, parent);
            parent._mainFrame.NavigationService.Navigate(po);
        }
    }
}
