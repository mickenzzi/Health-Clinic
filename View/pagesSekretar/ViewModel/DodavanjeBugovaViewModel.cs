using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;
using System.Windows.Controls;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class DodavanjeBugovaViewModel : BindableBase
    {
        private SekretarView parent;
        private string poruka;
        public MyICommand AddBugCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public DodavanjeBugovaViewModel(SekretarView parent) 
        {
            this.parent = parent;
            AddBugCommand = new MyICommand(OnAdd);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public string Poruka 
        {
            get { return poruka; }
            set 
            {
                poruka = value;
                OnPropertyChanged("Poruka");
            }
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnAdd() 
        {
            if (string.IsNullOrWhiteSpace(Poruka))
            {
                MessageBox.Show("Neophodno je uneti poruku.");
            }
            else
            {
                Bug bug = new Bug("Sekretar", Poruka);
                BugController.Instance.AddBug(bug);
                MessageBox.Show("Uspesno ste prijavili bug.");
                Poruka = "";
            }
        }

        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
    }
}
