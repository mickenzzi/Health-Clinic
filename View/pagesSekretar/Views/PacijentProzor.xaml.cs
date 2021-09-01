using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class PacijentProzor : Page
    {
        private SekretarView parent;
        public PacijentProzor(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void Povratak(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
        private void KreirajObican(object sender, RoutedEventArgs e)
        {
            KreiranjeObicnogNaloga ko = new KreiranjeObicnogNaloga(parent);
            parent._mainFrame.NavigationService.Navigate(ko);
        }
        private void KreirajGuest(object sender, RoutedEventArgs e)
        {
            KreiranjeGuestNaloga kg = new KreiranjeGuestNaloga(parent);
            parent._mainFrame.NavigationService.Navigate(kg);
        }
        private void PrikaziPacijente(object sender, RoutedEventArgs e)
        {
            PrikazPacijenata pp = new PrikazPacijenata(parent);
            parent._mainFrame.NavigationService.Navigate(pp);
        }
    }
}
