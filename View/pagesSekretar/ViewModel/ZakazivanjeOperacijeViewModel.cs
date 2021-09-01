using System;
using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Collections.ObjectModel;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class ZakazivanjeOperacijeViewModel : BindableBase
    {
        private SekretarView parent;
        private string jmbg;
        private Lekar selectedLekar;
        private string vreme;
        private string datum;
        public MyICommand ZakaziOperacijuCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public ObservableCollection<Lekar> Lekari { get; set; }
        public ZakazivanjeOperacijeViewModel(SekretarView parent, string jmbg)
        {
            this.parent = parent;
            this.jmbg = jmbg;
            LoadLekari();
            ZakaziOperacijuCommand = new MyICommand(OnZakazi);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public void LoadLekari()
        {
            List<Lekar> lek = new List<Lekar>();
            lek = LekariController.Instance.GetSviLekari();
            ObservableCollection<Lekar> lekari = new ObservableCollection<Lekar>(lek);
            Lekari = lekari;
        }
        public Lekar SelectedLekar
        {
            get { return selectedLekar; }
            set
            {
                selectedLekar = value;
                OnPropertyChanged("SelectedLekar");
            }
        }
        public string Vreme
        {
            get { return vreme; }
            set
            {
                vreme = value;
                OnPropertyChanged("Vreme");
            }
        }
        public string Datum
        {
            get { return datum; }
            set
            {
                datum = value;
                OnPropertyChanged("Datum");
            }
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new TerminProzor(parent, jmbg));
        }
        public void OnZakazi()
        {
            bool provera1 = false;
            bool provera2 = false;
            DateTime dt;
            string datumVremeTermina;
            if (string.IsNullOrWhiteSpace(Vreme))
            {
                MessageBox.Show("Niste uneli vreme termina.");
            }
            else
            {
                datumVremeTermina = Datum + " " + Vreme;
                if (string.IsNullOrWhiteSpace(datumVremeTermina))
                {
                    MessageBox.Show("Niste uneli parametre termina.");
                    provera1 = false;
                }
                else
                {
                    if (DateTime.TryParse(datumVremeTermina, out dt))
                    {
                        provera1 = true;
                    }
                    else
                    {
                        provera1 = false;
                        MessageBox.Show("Niste uneli datum u odgovarajucem formatu.");
                    }
                }
                if (SelectedLekar == null)
                {
                    provera2 = false;
                    MessageBox.Show("Niste odabrali lekara.");
                }
                else
                {
                    provera2 = true;
                }
                if (provera1 == true && provera2 == true)
                {
                    DateTime datumTermina = DateTime.Parse(datumVremeTermina);
                    bool zauzetTermin = false;
                    Soba soba = SobeController.Instance.GetSlobodnaSoba(TipoviSobe.OperacionaSala);
                    if (datumTermina >= SelectedLekar.DatumPocetkaOdmora && datumTermina <= SelectedLekar.DatumKrajaOdmora)
                    {
                        MessageBox.Show("Izabrani lekar je trenutno na odmoru.");
                    }
                    else
                    {
                        if (datumTermina.Hour < SelectedLekar.PocetakRadnogVremena.Hour || datumTermina.Hour > SelectedLekar.KrajRadnogVremena.Hour)
                        {
                            MessageBox.Show("Vas termin se ne uklapa u lekarovo radno vreme.");
                        }
                        else
                        {
                            zauzetTermin = TerminiController.Instance.GetOdgTermin(datumTermina, SelectedLekar.Id);

                            if (zauzetTermin == true)
                            {
                                MessageBox.Show("Zeljeni termin je zauzet.Izaberite drugi termin.");
                                TerminProzor tp = new TerminProzor(parent, jmbg);
                                parent._mainFrame.NavigationService.Navigate(tp);
                            }
                            else
                            {
                                if (soba != null)
                                {
                                    Pacijent pacijent = PacijentiController.Instance.GetOdgPacijent(jmbg);
                                    Termin termin = new Termin(false, datumTermina, SelectedLekar, pacijent, false, soba.Sifra);
                                    string poruka;
                                    string datum;
                                    datum = datumTermina.ToString();
                                    poruka = "Zakazali ste pregled kod " + SelectedLekar.Ime + " " + SelectedLekar.Prezime + " za " + datum + ".";
                                    Obavestenje o = new Obavestenje(poruka, pacijent.Id);
                                    ObavestenjaController.Instance.AddObavestenje(o);
                                    TerminiController.Instance.ZakaziOperaciju(termin);
                                    MessageBox.Show("Uspesno ste zakazali operaciju.");
                                    TerminProzor tp = new TerminProzor(parent, jmbg);
                                    parent._mainFrame.NavigationService.Navigate(tp);
                                }
                                else
                                {
                                    MessageBox.Show("Trenutno ne postoji nijedna slobodna ordinacija.");
                                    TerminProzor tp = new TerminProzor(parent, jmbg);
                                    parent._mainFrame.NavigationService.Navigate(tp);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
