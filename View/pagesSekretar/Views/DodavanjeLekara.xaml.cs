using System.Windows;
using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class DodavanjeLekara : Page
    {
        private SekretarView parent;
        public DodavanjeLekara(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new DodavanjeLekaraViewModel(parent);
        }
        private void Prikazi(object sender, RoutedEventArgs e)
        {
            OblastiSpecijalizacije.Visibility = Visibility.Visible;
            Specijalnosti.Visibility = Visibility.Visible;
        }
        private void Skloni(object sender, RoutedEventArgs e)
        {
            OblastiSpecijalizacije.Visibility = Visibility.Hidden;
            Specijalnosti.Visibility = Visibility.Hidden;
        }
    }
}
