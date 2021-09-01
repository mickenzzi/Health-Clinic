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
    public class WindowIzdavanjeReceptaViewModel : BindableBase
    {
        private LekarView parent;
        private Termin termin;
        private int idTermina;
        private Pacijent pacijent;
        private string pacijentInfo;
        private string jmbgPacijenta;
        private string zdravstvenaUstanova = "Bolnica KT5";
        private DateTime datumIzdavanjaLeka;
        public ObservableCollection<Lek> Lekovi { get; set; }
        private int kolicina;
        private string nacinUpotrebe;
        public MyICommand IzdajReceptCommand { get; set; }
        private Lek selectedLek;
        public Action CloseAction {get; set;}

        public WindowIzdavanjeReceptaViewModel(LekarView parent, int idTermin)
        {
            this.parent = parent;
            this.idTermina = idTermin;
            LoadPacijent();
            IzdajReceptCommand = new MyICommand(OnIzdajRecept);
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
        public string JmbgPacijenta
        {
            get { return jmbgPacijenta; }
            set
            {
                jmbgPacijenta = value;
                OnPropertyChanged("JmbgPacijenta");
            }
        }
        public string ZdravstvenaUstanova
        {
            get { return zdravstvenaUstanova; }
            set
            {
                zdravstvenaUstanova = value;
                OnPropertyChanged("ZdravstvenaUstanova");
            }
        }
        public DateTime DatumIzdavanjaLeka
        {
            get { return datumIzdavanjaLeka; }
            set
            {
                datumIzdavanjaLeka = value;
                OnPropertyChanged("DatumIzdavanjaLeka");
            }
        }
        public int Kolicina
        {
            get { return kolicina; }
            set
            {
                kolicina = value;
                OnPropertyChanged("Kolicina");
            }
        }
        public string NacinUpotrebe
        {
            get { return nacinUpotrebe; }
            set
            {
                nacinUpotrebe = value;
                OnPropertyChanged("NacinUpotrebe");
            }
        }

        public Lek SelectedLek
        {
            get { return selectedLek; }
            set
            {
                selectedLek = value;
                OnPropertyChanged("SelectedLek");
            }
        }

        public void LoadPacijent()
        {
            termin = TerminiController.Instance.GetTermin(idTermina);
            pacijent = PacijentiController.Instance.GetOdgPacijent(termin.JmbgPacijenta);
            PacijentInfo = pacijent.PacijentInfo;
            JmbgPacijenta = pacijent.Jmbg;
            DatumIzdavanjaLeka = DateTime.Now;

            List<Lek> lekovi = LekoviController.Instance.GetSveLekove();
            List<Lek> odobreniLekovi = new List<Lek>();
            foreach (Lek l in lekovi)
                if (l.Odobren2)
                    odobreniLekovi.Add(l);
            Lekovi = new ObservableCollection<Lek>(odobreniLekovi);
        }

        private void OnIzdajRecept()
        {
            Pacijent pacijent = PacijentiController.Instance.GetOdgPacijent(jmbgPacijenta);
            int sifraLeka = SelectedLek.Sifra;
            int kolicinaLeka = Kolicina;
            string nacinUpotrebe = NacinUpotrebe;
            DateTime datumIzdavanja = DatumIzdavanjaLeka;
            bool izdavanje = true;

            List<Alergija> alergije = AlergijaController.Instance.GetSveAlergije(pacijent.IdZK);
            foreach (Alergija a in alergije)
            {
                if (SelectedLek.Naziv.ToLower() == a.Naziv.ToLower())
                {
                    izdavanje = false;
                    break;
                }
                string sastojci = SelectedLek.Sastojci;
                char[] delimiterChars = { ',', ';' };
                string[] sastojciParsirani = sastojci.Split(delimiterChars);
                foreach (var word in sastojciParsirani)
                {
                    string wordLowerCase = word.ToLower();
                    string alergijaLowerCase = a.Naziv.ToLower();
                    if (wordLowerCase.Equals(alergijaLowerCase))
                    {
                        izdavanje = false;
                        break;
                    }       
                }
            }

            if (!izdavanje)
                MessageBox.Show("Pacijent je alergican na lek, izaberite zamenu!");
            else
            {
                Recept rec = new Recept(sifraLeka, kolicinaLeka, nacinUpotrebe, jmbgPacijenta, datumIzdavanja);
                ReceptiController.Instance.DodajRecept(rec);

                parent.frejm.Content = null;
                parent.frejm.Content = new PageAnamnezaPacijenta(parent, termin.Sifra);
                CloseAction();
                MessageBox.Show("Recept uspesno izdat!");
            }

        }

    }
}
