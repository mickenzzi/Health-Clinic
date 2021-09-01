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
    public class LekarViewModel : BindableBase
    {
        private Lekar selectedLekar;
        private LekarView parent;
        public ObservableCollection<Lekar> Lekari { get; set; }
        public MyICommand PrikazTerminaCommand { get; set; }
        public MyICommand PrikazLekovaCommand { get; set; }

        public LekarViewModel(LekarView parent)
        {
            this.parent = parent;
            MainWindow.l = new Lekar();
            LoadLekare();
            PrikazTerminaCommand = new MyICommand(OnPrikazTermina);
            PrikazLekovaCommand = new MyICommand(OnPrikazLekova);
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

        public void LoadLekare()
        {
            List<Lekar> lekari = LekariController.Instance.GetSviLekari();
            Lekari = new ObservableCollection<Lekar>(lekari);
        }


        private void OnPrikazTermina()
        {
            if (SelectedLekar == null)
                MessageBox.Show("Prvo izaberite lekara!");
            else
                parent.frejm.Content = new PagePrikazTermina(parent, SelectedLekar.Jmbg);
        }

        public void OnPrikazLekova()
        {
            if (SelectedLekar == null)
                MessageBox.Show("Prvo izaberite lekara!");
            else
                parent.frejm.Content = new PagePrikazLekova(parent, SelectedLekar.Jmbg);
        }
    }
}
