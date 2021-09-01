using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Controller;
using System.Collections.ObjectModel;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class HitnoPomeranjePregledaViewModel:BindableBase
    {
        private SekretarView parent;
        private string jmbg;
        private Termin selectedTermin;
        public MyICommand PomeriPregledCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public ObservableCollection<Termin> Termini { get; set; }
        public HitnoPomeranjePregledaViewModel(SekretarView parent,string jmbg) 
        {
            this.jmbg = jmbg;
            this.parent = parent;
            LoadTermine();
            PomeriPregledCommand = new MyICommand(OnPomeri);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public void LoadTermine()
        {
            List<Soba> sobe = SobeController.Instance.GetSveSobe();
            List<Soba> odgSobe = new List<Soba>();
            List<Termin> sviTermini = TerminiController.Instance.GetSveTermine();
            List<Termin> noviTermini = new List<Termin>();
            List<Termin> odgTermini = new List<Termin>();
            foreach (Termin t in sviTermini)
            {
                if (t.Slobodan == false)
                {
                    noviTermini.Add(t);
                }
            }
            foreach (Soba s in sobe)
            {
                if (s.Slobodna == false && s.Tip == TipoviSobe.Ordinacija)
                {
                    odgSobe.Add(s);
                }
            }
            foreach (Soba s in odgSobe)
            {
                foreach (Termin t in noviTermini)
                {
                    if (s.Sifra == t.SifraSobe)
                    {
                        odgTermini.Add(t);
                    }
                }
            }
            ObservableCollection<Termin> termini = new ObservableCollection<Termin>(odgTermini);
            Termini = termini;
        }
        public Termin SelectedTermin
        {
            get { return selectedTermin; }
            set
            {
                selectedTermin = value;
                OnPropertyChanged("SelectedTermin");
                PomeriPregledCommand.RaiseCanExecuteChanged();
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
        private void OnPomeri() 
        {
            if (SelectedTermin != null)
            {
                PomeranjePregleda pp = new PomeranjePregleda(parent, jmbg, SelectedTermin.Sifra);
                parent._mainFrame.NavigationService.Navigate(pp);
            }
            else 
            {
                MessageBox.Show("Niste izabrali termin.");
            }
        }
    }
}
