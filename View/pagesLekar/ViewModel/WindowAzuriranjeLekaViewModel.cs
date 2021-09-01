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
    public class WindowAzuriranjeLekaViewModel : BindableBase
    {
        private int sifraLeka;
        private string jmbgLekara;
        private string nazivLeka;
        private string dozaLeka;
        private int kolicinaLeka;
        private int sifraSobe;
        private string sastojciLeka;
        private int sifraZameneLeka;
        private string nazivZameneLeka;
        private LekarView parent;
        private Lek lek;
        private Lek selectedLek;
        public ObservableCollection<Lek> Lekovi { get; set; }
        public MyICommand PotvrdaIzmeneLekaCommand { get; set; }
        public MyICommand OdustaniOdIzmeneLekaCommand { get; set; }
        public Action CloseAction { get; set; }

        public WindowAzuriranjeLekaViewModel(LekarView parent, int sifraLeka, string jmbgLekara)
        {
            this.parent = parent;
            this.jmbgLekara = jmbgLekara;
            this.sifraLeka = sifraLeka;
            LoadLek();
            PotvrdaIzmeneLekaCommand = new MyICommand(OnClickPotvrdi);
            OdustaniOdIzmeneLekaCommand = new MyICommand(OnClickOdustani);
        }

        public string NazivLeka
        {
            get { return nazivLeka; }
            set
            {
                nazivLeka = value;
                OnPropertyChanged("NazivLeka");
            }
        }
        public string DozaLeka
        {
            get { return dozaLeka; }
            set
            {
                dozaLeka = value;
                OnPropertyChanged("DozaLeka");
            }
        }
        public int KolicinaLeka
        {
            get { return kolicinaLeka; }
            set
            {
                kolicinaLeka = value;
                OnPropertyChanged("KolicinaLeka");
            }
        }
        public int SifraSobe
        {
            get { return sifraSobe; }
            set
            {
                sifraSobe = value;
                OnPropertyChanged("SifraSobe");
            }
        }
        public string SastojciLeka
        {
            get { return sastojciLeka; }
            set
            {
                sastojciLeka = value;
                OnPropertyChanged("SastojciLeka");
            }
        }
        public int SifraLeka
        {
            get { return sifraLeka; }
            set
            {
                sifraLeka = value;
                OnPropertyChanged("SifraLeka");
            }
        }
        public int SifraZameneLeka
        {
            get { return sifraZameneLeka; }
            set
            {
                sifraZameneLeka = value;
                OnPropertyChanged("SifraZameneLeka");
            }
        }

        public string NazivZameneLeka
        {
            get { return nazivZameneLeka; }
            set
            {
                nazivZameneLeka = value;
                OnPropertyChanged("NazivZameneLeka");
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

        public void LoadLek()
        {
            lek = LekoviController.Instance.GetLekById(sifraLeka);
            if (lek != null)
            {
                NazivLeka = lek.Naziv;
                DozaLeka = lek.Doza;
                KolicinaLeka = lek.Kolicina;
                SifraSobe = lek.SifraSobe;
                SastojciLeka = lek.Sastojci;

                int sifraZameneLeka = lek.Zamena;
                Lek zamena = LekoviController.Instance.GetLekById(sifraZameneLeka);
                NazivZameneLeka = zamena.Naziv;

                List<Lek> lekovi = LekoviController.Instance.GetSveLekove();
                List<Lek> moguceZamene = new List<Lek>();
                if (lekovi == null)
                    lekovi = new List<Lek>();
                foreach (Lek l in lekovi)
                    if (l.Sifra != lek.Sifra && l.Sifra != lek.Zamena)
                        moguceZamene.Add(l);
                Lekovi = new ObservableCollection<Lek>(moguceZamene);
            }
            else
                MessageBox.Show("Prvo izaberite lek!");
        }

        private void OnClickPotvrdi()
        {
            string naziv = NazivLeka;
            string doza = DozaLeka;
            int kolicina = KolicinaLeka;
            int sifraSobe = SifraSobe;
            string sastojci = SastojciLeka;
            int sifraZamene = lek.Zamena;

            if (SelectedLek != null)
                sifraZamene = SelectedLek.Sifra;

            Lek noviLek = new Lek(naziv, doza, kolicina, sifraSobe, sifraZamene, sastojci);
            LekoviController.Instance.IzmeniLek(lek, noviLek);

            CloseAction();
            parent.frejm.Content = new PagePrikazLekova(parent, jmbgLekara);
        }
        private void OnClickOdustani()
        {
            CloseAction();
            parent.frejm.Content = new PagePrikazLekova(parent, jmbgLekara);
        }
    }
}
