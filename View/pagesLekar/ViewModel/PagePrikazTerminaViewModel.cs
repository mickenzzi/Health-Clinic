using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bolnica.View.pagesLekar.ViewModel
{
    public class PagePrikazTerminaViewModel : BindableBase
    {
        private Lekar lekar;
        private string jmbgLekara;
        private string lekarInfo;
        private string pacijentInfo;
        private Termin selectedTermin;
        private Pacijent selectedPacijent;
        private Termin selectedHospitalizovani;
        private Soba selectedSoba;
        private Lekar selectedLekar;
        private string selectedVreme = "08:00";
        private DateTime selectedDatum = DateTime.Now;
        private LekarView parent;
        private bool prostorijeEnabled;
        public ObservableCollection<Pacijent> Pacijenti { get; set; }
        public ObservableCollection<Termin> Termini { get; set; }
        public ObservableCollection<Termin> Hospitalizovani { get; set; }
        public ObservableCollection<Soba> Sobe { get; set; }
        public ObservableCollection<Lekar> Lekari { get; set; }
        public ObservableCollection<string> Vremena { get; set; }
        public MyICommand IzmeniTerminCommand { get; set; }
        public MyICommand OtkaziTerminCommand { get; set; }
        public MyICommand ZakaziTerminCommand { get; set; }
        public MyICommand AnamnezaPacijentaCommand { get; set; }
        public MyICommand KartonPacijentaCommand { get; set; }
        public MyICommand OtpustiPacijentaCommand { get; set; }
        public MyICommand ProduziHospitalizacijuCommand { get; set; }


        public PagePrikazTerminaViewModel(LekarView parent, string jmbgLekara)
        {
            this.parent = parent;
            this.jmbgLekara = jmbgLekara;
            LoadTermine();
            ZakaziTerminCommand = new MyICommand(OnZakaziTermin);
            IzmeniTerminCommand = new MyICommand(OnIzmeniTermin);
            OtkaziTerminCommand = new MyICommand(OnOtkaziTermin);
            AnamnezaPacijentaCommand = new MyICommand(OnPrikaziAnamnezuPacijenta);
            KartonPacijentaCommand = new MyICommand(OnPrikaziKartonPacijenta);
            ProduziHospitalizacijuCommand = new MyICommand(OnProduziHospitalizaciju);
            OtpustiPacijentaCommand = new MyICommand(OnOtpustiPacijenta);
        }

        public string LekarInfo
        {
            get { return lekarInfo; }
            set
            {
                lekarInfo = value;
                OnPropertyChanged("LekarInfo");
            }
        }

        public string PacijentInfo
        {
            get { return pacijentInfo; }
            set
            {
                pacijentInfo = value;
                OnPropertyChanged("PacijentInfo");
            }
        }

        public Termin SelectedTermin
        {
            get { return selectedTermin; }
            set
            {
                selectedTermin = value;
                OnPropertyChanged("SelectedTermin");
            }
        }

        public Termin SelectedHospitalizovani
        {
            get { return selectedHospitalizovani; }
            set
            {
                selectedHospitalizovani = value;
                OnPropertyChanged("SelectedHospitalizovani");
            }
        }

        public Pacijent SelectedPacijent
        {
            get { return selectedPacijent; }
            set
            {
                selectedPacijent = value;
                OnPropertyChanged("SelectedPacijent");
            }
        }

        public Soba SelectedSoba
        {
            get { return selectedSoba; }
            set
            {
                selectedSoba = value;
                OnPropertyChanged("SelectedSoba");
            }
        }

        public Lekar SelectedLekar
        {
            get { return selectedLekar; }
            set
            {
                selectedLekar = value;
                OnPropertyChanged("SelectedLekar");
                LekariComboBox_SelectionChanged();
                OnPropertyChanged("Sobe");
            }
        }

        public string SelectedVreme
        {
            get { return selectedVreme; }
            set
            {
                selectedVreme = value;
                OnPropertyChanged("SelectedVreme");
            }
        }

        public DateTime SelectedDatum
        {
            get { return selectedDatum; }
            set
            {
                selectedDatum = value;
                OnPropertyChanged("SelectedDatum");
            }
        }

        public bool ProstorijeEnabled
        {
            get { return prostorijeEnabled; }
            set
            {
                prostorijeEnabled = value;
                OnPropertyChanged("ProstorijeEnabled");
            }
        }

        private void OnZakaziTermin()
        {
            if (SelectedPacijent == null || SelectedLekar == null || SelectedSoba == null || SelectedVreme == null || SelectedDatum == null)
                MessageBox.Show("Izaberite sve podatke o terminu.");
            else
            {
                string vreme = SelectedVreme;
                DateTime datum = SelectedDatum;

                string[] delovi = vreme.Split(':');
                int vremeSati = Int32.Parse(delovi[0]);
                int vremeMinuti = Int32.Parse(delovi[1]);

                DateTime datumVremeTermina = new DateTime(datum.Year, datum.Month, datum.Day, vremeSati, vremeMinuti, 0);

                Termin t = new Termin(SelectedPacijent.Jmbg, false, datumVremeTermina, SelectedSoba.Sifra, SelectedLekar.Jmbg);

                if (TerminiController.Instance.ZakaziTermin(t))
                {
                    if (lekar.Jmbg == t.JmbgLekara)
                        Termini.Add(t);

                    string terminOpis;
                    if (SelectedSoba.Tip == TipoviSobe.OperacionaSala)
                        terminOpis = "operaciju";
                    else
                        terminOpis = "pregled";
                    MessageBox.Show("Zakazali ste " + terminOpis + " pacijentu " + SelectedPacijent.PacijentInfo + " kod lekara " + SelectedLekar.LekarInfo + ".");
                    parent.frejm.Content = null;
                    parent.frejm.Content = new PagePrikazTermina(parent, lekar.Jmbg);
                }
                else
                    MessageBox.Show("Termin je zauzet.");
            }
        }

        private void OnIzmeniTermin()
        {
            if (SelectedTermin != null)
            {
                WindowIzmeniTermin it = new WindowIzmeniTermin(parent, SelectedTermin.Sifra);
                it.ShowDialog();
            }
            else
                MessageBox.Show("Prvo izaberite termin!");
        }

        private void OnOtkaziTermin()
        {
            if (SelectedTermin != null)
            {
                TerminiController.Instance.OtkaziTermin(SelectedTermin);
                parent.frejm.Content = null;
                parent.frejm.Content = new PagePrikazTermina(parent, jmbgLekara);
            }
            else
                MessageBox.Show("Prvo izaberite termin!");
        }

        private void OnPrikaziAnamnezuPacijenta()
        {
            if (SelectedTermin != null)
            {
                int provera = DateTime.Compare(SelectedTermin.DatumVreme, DateTime.Now);
                if (provera > 0)
                    MessageBox.Show("Pregled jos nije zapoceo!");
                else
                {
                    parent.frejm.Content = new PageAnamnezaPacijenta(parent, SelectedTermin.Sifra);
                }
            }
            else
                MessageBox.Show("Prvo izaberite termin!");
        }


        private void OnPrikaziKartonPacijenta()
        {
            if (SelectedTermin != null)
            {
                parent.frejm.Content = new PageKartonPacijenta(parent, SelectedTermin.Sifra);
                Console.WriteLine("Id selektovanog termina: " + SelectedTermin.Sifra);
            }
            else
                MessageBox.Show("Prvo izaberite termin!");
        }

        private void OnProduziHospitalizaciju()
        {
            if (SelectedHospitalizovani != null)
            {
                WindowProduziHospitalizaciju ph = new WindowProduziHospitalizaciju(parent, SelectedHospitalizovani.Sifra);
                ph.ShowDialog();
            }
            else
                MessageBox.Show("Izaberite pacijenta!");
        }

        private void OnOtpustiPacijenta()
        {
            TerminiController.Instance.OtkaziTermin(SelectedHospitalizovani);
            List<Soba> sobe = SobeController.Instance.GetSveSobe();
            List<Inventar> inventar = InventarController.Instance.GetSavInventar();
            foreach (Soba s in sobe)
                foreach (Inventar i in inventar)
                    if (i.SifraSobe == s.Sifra && i.JmbgPacijenta == SelectedHospitalizovani.JmbgPacijenta)
                    {
                        Inventar inv = new Inventar(TipoviInventara.BolnickiKrevet, i.RedniBrojUSobi, s.Sifra, null, false);
                        InventarController.Instance.IzmeniInventarKrevet(i, inv);
                    }
            parent.frejm.Content = null;
            parent.frejm.Content = new PagePrikazTermina(parent, lekar.Jmbg);


        }

        private void LekariComboBox_SelectionChanged()
        {
            List<Soba> sveSobe = new List<Soba>();
            List<Soba> odgovarajuceSobe = new List<Soba>();
            sveSobe = SobeController.Instance.GetSveSobe();
            if (SelectedLekar != null)
            {
                if (!SelectedLekar.Specijalista)
                {
                    foreach (Soba s in sveSobe)
                        if (s.Tip == TipoviSobe.Ordinacija)
                            odgovarajuceSobe.Add(s);
                }
                else if (SelectedLekar.Specijalista)
                {
                    foreach (Soba s in sveSobe)
                        if (s.Tip == TipoviSobe.Ordinacija || s.Tip == TipoviSobe.OperacionaSala)
                            odgovarajuceSobe.Add(s);
                }
                Sobe = new ObservableCollection<Soba>(odgovarajuceSobe);
            }
        }

        public void LoadTermine()
        {
            lekar = LekariController.Instance.GetOdgLekarByJmbg(jmbgLekara);
            List<Termin> sviTermini = new List<Termin>();
            List<Termin> izabraniTermini = new List<Termin>();
            sviTermini = TerminiController.Instance.GetSveTermine();
            foreach (Termin termin in sviTermini)
                if (termin.JmbgLekara == lekar.Jmbg)
                    izabraniTermini.Add(termin);
            Termini = new ObservableCollection<Termin>(izabraniTermini);

            LekarInfo = lekar.Ime + " " + lekar.Prezime;

            List<Pacijent> sviPacijenti = new List<Pacijent>();
            sviPacijenti = PacijentiController.Instance.GetSvePacijente();
            ObservableCollection<Pacijent> pac = new ObservableCollection<Pacijent>(sviPacijenti);
            Pacijenti = pac;

            List<Lekar> sviLekari = new List<Lekar>();
            sviLekari = LekariController.Instance.GetSviLekari();
            Lekari = new ObservableCollection<Lekar>(sviLekari);

            List<Soba> sveSobe = new List<Soba>();
            List<Soba> bolesnickeSobe = new List<Soba>();
            sveSobe = SobeController.Instance.GetSveSobe();
            foreach (Soba s in sveSobe)
                if (s.Tip == TipoviSobe.Bolesnicka)
                    bolesnickeSobe.Add(s);

            List<Termin> hospitalizacija = new List<Termin>();
            foreach (Termin t in sviTermini)
                foreach (Soba s in bolesnickeSobe)
                    if (t.SifraSobe == (s.Sifra))
                        hospitalizacija.Add(t);
            Hospitalizovani = new ObservableCollection<Termin>(hospitalizacija);

            string[] vremeTermina = TerminiController.Instance.GetVremena();
            Vremena = new ObservableCollection<string>(vremeTermina);
        }
    }
}
