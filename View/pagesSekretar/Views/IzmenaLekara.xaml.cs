using System.Windows;
using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class IzmenaLekara : Page
    {
        private SekretarView parent;
        public IzmenaLekara(SekretarView parent,int idLekara)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new IzmenaLekaraViewModel(parent, idLekara);
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
