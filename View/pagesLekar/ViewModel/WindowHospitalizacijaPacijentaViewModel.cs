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
    public class WindowHospitalizacijaPacijentaViewModel : BindableBase
    {
        private LekarView parent;
        private int idTermina;
        private Termin termin;
        private string pacijentInfo;
        private bool trenutnaHospitalizacijaCheck;
        private DateTime selectedDate;
        private int trajanjeHospitalizacije;
        private Soba selectedSoba;
        private Inventar selectedKrevet;
        public ObservableCollection<Soba> Sobe { get; set; }
        public ObservableCollection<Inventar> Kreveti { get; set; }
        public MyICommand ZakaziHospitalizacijuCommand { get; set; }
        public Action CloseAction { get; set; }

        public WindowHospitalizacijaPacijentaViewModel(LekarView parent, int idTermina)
        {
            this.parent = parent;
            this.idTermina = idTermina;
            LoadPacijent();
            ZakaziHospitalizacijuCommand = new MyICommand(OnZakaziHospitalizaciju);
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

        public bool TrenutnaHospitalizacijaCheck
        {
            get { return trenutnaHospitalizacijaCheck; }
            set
            {
                trenutnaHospitalizacijaCheck = value;
                OnPropertyChanged("TrenutnaHospitalizacija");
            }
        }

        public DateTime SelectedDate
        {
            get { return selectedDate; }
            set
            {
                selectedDate = value;
                OnPropertyChanged("SelectedDate");
            }
        }
        public int TrajanjeHospitalizacije
        {
            get { return trajanjeHospitalizacije; }
            set
            {
                trajanjeHospitalizacije = value;
                OnPropertyChanged("TrajanjeHospitalizacije");
            }
        }

        public Soba SelectedSoba
        {
            get { return selectedSoba; }
            set
            {
                selectedSoba = value;
                OnPropertyChanged("SelectedSoba");
                LoadKrevete();
                OnPropertyChanged("Kreveti");
            }
        }

        public Inventar SelectedKrevet
        {
            get { return selectedKrevet; }
            set
            {
                selectedKrevet = value;
                OnPropertyChanged("SelectedKrevet");
            }
            
        }  

        public void LoadPacijent()
        {
            termin = TerminiController.Instance.GetTermin(idTermina);
            PacijentInfo = termin.PacijentInfo;
            List<Soba> sobe = SobeController.Instance.GetSveSobe();
            List<Soba> bolesnickeSobe = new List<Soba>();
            foreach (Soba s in sobe)
                if (s.Tip == TipoviSobe.Bolesnicka)
                    bolesnickeSobe.Add(s);
            ObservableCollection<Soba> sobeObs = new ObservableCollection<Soba>(bolesnickeSobe);
            Sobe = sobeObs;
        }

        private void OnZakaziHospitalizaciju()
        {
            
            DateTime datumHospitalizacije = new DateTime();

            if (TrenutnaHospitalizacijaCheck)
            {
                datumHospitalizacije = DateTime.Now;
            }
            else if (SelectedDate != null)
            {
                DateTime temp = SelectedDate;
                datumHospitalizacije = new DateTime(temp.Year, temp.Month, temp.Day, temp.Hour, temp.Minute, 0);
            }

            if (SelectedSoba != null && !TrajanjeHospitalizacije.Equals(0) && SelectedKrevet != null)
            {
                DateTime krajHospitalizacije = datumHospitalizacije.AddDays(TrajanjeHospitalizacije);
                Inventar noviInventar = new Inventar(TipoviInventara.BolnickiKrevet, SelectedKrevet.RedniBrojUSobi, SelectedSoba.Sifra, termin.JmbgPacijenta, true);
                InventarController.Instance.IzmeniInventarKrevet(SelectedKrevet, noviInventar);

                Termin t = new Termin(termin.JmbgPacijenta, SelectedSoba.Sifra.ToString(), datumHospitalizacije, krajHospitalizacije);
                TerminiController.Instance.ZakaziTermin(t);

                parent.frejm.Content = null;
                parent.frejm.Content = new PageAnamnezaPacijenta(parent, termin.Sifra);
                CloseAction();
                MessageBox.Show("Uspesno ste hospitalizovali pacijenta.");
            }
            else
            {
                MessageBox.Show("Izaberite sve podatke o hospitalizaciji!");
            }
        }

        public void LoadKrevete()
        {
            if (SelectedSoba != null)
            {
                Inventar i = new Inventar();
                List<Inventar> inventarSource = new List<Inventar>();
                foreach (int sifra in SelectedSoba.KrevetiInventar)
                {
                    i = InventarController.Instance.GetInventarBySifra(sifra);
                    if (!i.Zauzet)
                        inventarSource.Add(i);
                }
                ObservableCollection<Inventar> krevetiObs = new ObservableCollection<Inventar>(inventarSource);
                Kreveti = krevetiObs;
            }
        }


    }
}
