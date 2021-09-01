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
using System.Windows.Navigation;

namespace Bolnica.View.pagesLekar.ViewModel
{
    public class PagePrikazLekovaViewModel : BindableBase
    {
        private LekarView parent;
        private string jmbgLekara;
        private Lek selectedLek;
        private Lekar lekar;
        private string sastojciLeka;
        private bool vratiNaIzmenuLekIsEnabled;
        private bool odobriLekIsEnabled;
        private bool izmeniLekIsEnabled = true;
        private Lek selectedLekTemporary;
        private ObservableCollection<Lek> lekovi;

        public MyICommand OdobriLekCommand { get; set; }
        public MyICommand VratiLekNaIzmenuCommand { get; set; }
        public MyICommand IzmeniLekCommand { get; set; }
        
        public MyICommand IspisiSastojkeLekaCommand { get; set; }

        public PagePrikazLekovaViewModel(LekarView parent, string jmbgLekara)
        {
            this.parent = parent;
            this.jmbgLekara = jmbgLekara;
            LoadAll();
            OdobriLekCommand = new MyICommand(OdobriLekClick, DozvoliRadSaLekom);
            VratiLekNaIzmenuCommand = new MyICommand(VratiNaIzmenuClick, DozvoliRadSaLekom);
            IzmeniLekCommand = new MyICommand(IzmeniLekClick, DozvoliRadSaLekom);
            IspisiSastojkeLekaCommand = new MyICommand(IspisiSastojkeLeka, DozvoliRadSaLekom);

        }

        public void LoadAll()
        {
            lekar = LekariController.Instance.GetOdgLekarByJmbg(jmbgLekara);
            List<Lek> sviLekovi = new List<Lek>();
            List<Lek> lekovi = new List<Lek>();
            sviLekovi =  LekoviController.Instance.GetSveLekove();
            foreach (Lek l in sviLekovi)
                lekovi.Add(l);
            ObservableCollection<Lek> lekoviObs = new ObservableCollection<Lek>(lekovi);
            Lekovi = lekoviObs;

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

        public ObservableCollection<Lek> Lekovi 
        {
            get { return lekovi; }
            set
            {
                lekovi = value;
                OnPropertyChanged("Lekovi"); 
            } 
        }

        public Lek SelectedLek
        {
            get { return selectedLek; }
            set
            {
                selectedLek = value;
                OnPropertyChanged("SelectedLek");
                IspisiSastojkeLeka();
                LekoviSelectionChanged();
                OdobriLekCommand.RaiseCanExecuteChanged();
                VratiLekNaIzmenuCommand.RaiseCanExecuteChanged();
                IzmeniLekCommand.RaiseCanExecuteChanged();
                
            }
        }

        public Lek SelectedLekTemporary
        {
            get { return selectedLekTemporary; }
            set
            {
                selectedLekTemporary = value;
                OnPropertyChanged("SelectedLekTemporary");
            }
        }

        public bool VratiNaIzmenuLekIsEnabled
        {
            get { return vratiNaIzmenuLekIsEnabled; }
            set
            {
                vratiNaIzmenuLekIsEnabled = value;
                OnPropertyChanged("VratiNaIzmenuLekIsEnabled");
                OnPropertyChanged("SelectedLek");
                OnPropertyChanged("IzmeniLekIsEnabled");
                OnPropertyChanged("Lekovi");
            }
        }

        public bool OdobriLekIsEnabled
        {
            get { return odobriLekIsEnabled; }
            set
            {
                odobriLekIsEnabled = value;
                OnPropertyChanged("OdobriLekIsEnabled");
                OnPropertyChanged("SelectedLek");
                OnPropertyChanged("IzmeniLekIsEnabled");
                OnPropertyChanged("Lekovi");
            }
        }

        public bool IzmeniLekIsEnabled
        {
            get { return izmeniLekIsEnabled; }
        }

        private void IspisiSastojkeLeka()
        {
            if (DozvoliRadSaLekom())
                SastojciLeka = SelectedLek.Sastojci;
        }

        private bool DozvoliRadSaLekom()
        {
            return SelectedLek != null;
        }

        private void OdobriLekClick()
        {

            if (SelectedLek != null)
            {
                if (!SelectedLek.Odobren1)
                {
                    Lek noviLek = new Lek(SelectedLek.Naziv, SelectedLek.Doza, SelectedLek.Kolicina, SelectedLek.SifraSobe, SelectedLek.Zamena, SelectedLek.Sastojci, true, SelectedLek.Odobren2, SelectedLek.Izmena1, SelectedLek.Izmena2, lekar.Jmbg, SelectedLek.JmbgLekaraKojiJeIzmenio);
                    LekoviController.Instance.IzmeniLek(SelectedLek, noviLek);
                    OdobriLekIsEnabled = false;
                    VratiNaIzmenuLekIsEnabled = true;
                    MessageBox.Show("Potrebno da jos jedan lekar odobri lek!");
                }
                else if (!(SelectedLek.Odobren2 && SelectedLek.JmbgLekaraKojiJeOdobrio.Equals(lekar.Jmbg)))
                {
                    Lek noviLek = new Lek(SelectedLek.Naziv, SelectedLek.Doza, SelectedLek.Kolicina, SelectedLek.SifraSobe, SelectedLek.Zamena, SelectedLek.Sastojci, SelectedLek.Odobren1, true, false, false, "0", "0");
                    LekoviController.Instance.IzmeniLek(SelectedLek, noviLek);
                    OdobriLekIsEnabled = false;
                    VratiNaIzmenuLekIsEnabled = true;
                    parent.frejm.Content = null;
                    parent.frejm.Content = new PagePrikazLekova(parent, lekar.Jmbg);
                    MessageBox.Show("Lek je uspesno odobren.");
                }
            }
            else
                MessageBox.Show("Prvo izaberite lek!");
        }

        private void VratiNaIzmenuClick()
        {
            if (SelectedLek != null)
            {
                if (!SelectedLek.Izmena1)
                {
                    Lek noviLek = new Lek(SelectedLek.Naziv, SelectedLek.Doza, SelectedLek.Kolicina, SelectedLek.SifraSobe, SelectedLek.Zamena, SelectedLek.Sastojci, SelectedLek.Odobren1, SelectedLek.Odobren2, true, SelectedLek.Izmena2, SelectedLek.JmbgLekaraKojiJeOdobrio, lekar.Jmbg);
                    LekoviController.Instance.IzmeniLek(SelectedLek, noviLek);
                    VratiNaIzmenuLekIsEnabled = false;
                    OdobriLekIsEnabled = true;
                    MessageBox.Show("Potrebno da jos jedan lekar vrati lek na izmenu!");
                }
                else if (!(SelectedLek.Izmena2 && SelectedLek.JmbgLekaraKojiJeIzmenio.Equals(lekar.Jmbg)))
                {
                    Lek noviLek = new Lek(SelectedLek.Naziv, SelectedLek.Doza, SelectedLek.Kolicina, SelectedLek.SifraSobe, SelectedLek.Zamena, SelectedLek.Sastojci, false, false, SelectedLek.Izmena1, true, "0", "0");
                    LekoviController.Instance.IzmeniLek(SelectedLek, noviLek);
                    VratiNaIzmenuLekIsEnabled = false;
                    OdobriLekIsEnabled = true;
                    parent.frejm.Content = null;
                    parent.frejm.Content = new PagePrikazLekova(parent, lekar.Jmbg);
                    MessageBox.Show("Lek je uspesno vracen na izmenu.");
                }
            }
            else
                MessageBox.Show("Prvo izaberite lek!");

        }

        private void IzmeniLekClick()
        {
            
            if (SelectedLek != null)
            {
                WindowAzuriranjeLeka al = new WindowAzuriranjeLeka(parent, SelectedLek.Sifra, lekar.Jmbg);
                al.ShowDialog();
            }
            else
                MessageBox.Show("Prvo izaberite lek!");
        }

        private void LekoviSelectionChanged()
        {
            if (lekar.Jmbg.Equals(SelectedLek.JmbgLekaraKojiJeIzmenio) || SelectedLek.Izmena2)
            {
                VratiNaIzmenuLekIsEnabled = false;
                OdobriLekIsEnabled = true;
            }

            else if (lekar.Jmbg.Equals(SelectedLek.JmbgLekaraKojiJeOdobrio) || SelectedLek.Odobren2)
            {
                OdobriLekIsEnabled = false;
                VratiNaIzmenuLekIsEnabled = true;
            }
            else
            {
                OdobriLekIsEnabled = true;
                VratiNaIzmenuLekIsEnabled = true;
            }
        }


    }
}
