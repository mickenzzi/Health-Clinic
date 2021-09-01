using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class LekarProzor : Page
    {
        private SekretarView parent;
        public LekarProzor(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void DodajLekara(object sender, RoutedEventArgs e)
        {
            parent._mainFrame.NavigationService.Navigate(new DodavanjeLekara(parent));
        }
        private void PrikazLekara(object sender, RoutedEventArgs e)
        {
           parent._mainFrame.NavigationService.Navigate(new PrikazLekara(parent));
        }
        private void Nazad(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
