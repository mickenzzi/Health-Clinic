using Bolnica.View.pagesLekar.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Bolnica.View.pagesLekar
{
    /// <summary>
    /// Interaction logic for PagePrikazTermina.xaml
    /// </summary>
    public partial class PagePrikazTermina : Page
    {
        public PagePrikazTermina(LekarView parent, string jmbgLekara)
        {
            InitializeComponent();
            this.DataContext = new PagePrikazTerminaViewModel(parent, jmbgLekara);
        }

        private void Nazad(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
