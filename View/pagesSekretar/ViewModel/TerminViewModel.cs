using System;
using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class TerminViewModel : BindableBase
    {
        private SekretarView parent;
        private string jmbg;
        private string ime;
        private string prezime;
        public MyICommand OtkaziOperacijuCommand { get; set; }
        public MyICommand ZakaziOperacijuCommand { get; set; }
        public MyICommand OtkaziPregledCommand { get; set; }
        public MyICommand ZakaziPregledCommand { get; set; }
        public MyICommand ZakaziHitanPregledCommand { get; set; }
        public MyICommand ZakaziHitnuOperacijuCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public TerminViewModel(SekretarView parent,string jmbg) 
        {
            this.parent = parent;
            this.jmbg = jmbg;
            LoadPacijent();
            ZakaziOperacijuCommand = new MyICommand(OnZakaziOperaciju);
            OtkaziOperacijuCommand = new MyICommand(OnOtkaziOperaciju);
            ZakaziPregledCommand = new MyICommand(OnZakaziPregled);
            OtkaziPregledCommand = new MyICommand(OnOtkaziPregled);
            ZakaziHitanPregledCommand = new MyICommand(OnZakaziHitanPregled);
            ZakaziHitnuOperacijuCommand = new MyICommand(OnZakaziHitnuOperaciju);
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
        public void LoadPacijent() 
        {
            Pacijent pacijent = new Pacijent();
            pacijent = PacijentiController.Instance.GetOdgPacijent(jmbg);
            Ime = pacijent.Ime;
            Prezime = pacijent.Prezime;
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnZakaziPregled() 
        {
            ZakazivanjePregleda zp = new ZakazivanjePregleda(parent, jmbg);
            parent._mainFrame.NavigationService.Navigate(zp);
        }
        private void OnZakaziOperaciju() 
        {
            ZakazivanjeOperacije zo = new ZakazivanjeOperacije(parent, jmbg);
            parent._mainFrame.NavigationService.Navigate(zo);
        }
        private void OnOtkaziOperaciju() 
        {
            OtkazivanjeOperacije oo = new OtkazivanjeOperacije(parent, jmbg);
            parent._mainFrame.NavigationService.Navigate(oo);
        }
        private void OnOtkaziPregled() 
        {
            OtkazivanjePregleda op = new OtkazivanjePregleda(parent, jmbg);
            parent._mainFrame.NavigationService.Navigate(op);
        }
        private void OnZakaziHitnuOperaciju()
        {
            DateTime datumTermina = System.DateTime.Now;
            Pacijent pacijent = PacijentiController.Instance.GetOdgPacijent(jmbg);
            Lekar lekar = TerminiController.Instance.SlobodanLekar(datumTermina);
            if (lekar != null)
            {
                Soba soba = SobeController.Instance.GetSlobodnaSoba(TipoviSobe.Ordinacija);
                soba.Slobodna = false;
                SobeController.Instance.SetSoba(soba);
                string poruka;
                poruka = "Zakazali ste hitnu operaciju kod " + lekar.Ime + " " + lekar.Prezime + " za " + datumTermina.ToString() + ".";
                Obavestenje o = new Obavestenje(poruka, pacijent.Id);
                ObavestenjaController.Instance.AddObavestenje(o);
                Termin termin = new Termin(false, datumTermina, lekar, pacijent, false, soba.Sifra);
                MessageBox.Show("Uspesno ste zakazali hitnu operaciju.");
                TerminiController.Instance.ZakaziHitnuOperaciju(termin);
            }
            else
            {
                HitnoPomeranjeOperacija ho = new HitnoPomeranjeOperacija(parent, jmbg);
                MessageBox.Show("Neophodno je izvrsiti hitno pomeranje operacije.");
                parent._mainFrame.NavigationService.Navigate(ho);
            }
        }
        private void OnZakaziHitanPregled() 
        {
            DateTime datumTermina = System.DateTime.Now;
            Pacijent pacijent = PacijentiController.Instance.GetOdgPacijent(jmbg);
            Lekar lekar = TerminiController.Instance.SlobodanLekar(datumTermina);
            if (lekar != null)
            {
                Soba soba = SobeController.Instance.GetSlobodnaSoba(TipoviSobe.Ordinacija);
                soba.Slobodna = false;
                SobeController.Instance.SetSoba(soba);
                string poruka;
                poruka = "Zakazali ste hitan pregled kod " + lekar.Ime + " " + lekar.Prezime + " za " + datumTermina.ToString() + ".";
                Obavestenje o = new Obavestenje(poruka, pacijent.Id);
                ObavestenjaController.Instance.AddObavestenje(o);
                Termin termin = new Termin(false, datumTermina, lekar, pacijent, false, soba.Sifra);
                MessageBox.Show("Uspesno ste zakazali hitan pregled.");
                TerminiController.Instance.ZakaziHitanPregled(termin);
            }
            else
            {
                MessageBox.Show("Neophodno je izvrsiti hitno pomeranje pregleda.");
                HitnoPomeranjePregleda ho = new HitnoPomeranjePregleda(parent, jmbg);
                parent._mainFrame.NavigationService.Navigate(ho);
            }
        }
    }
}
