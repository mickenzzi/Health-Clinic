using Bolnica.View.pagesLekar.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Bolnica.View.pagesLekar
{
    /// <summary>
    /// Interaction logic for PagePrikazLekova.xaml
    /// </summary>
    public partial class PagePrikazLekova : Page
    {
        public PagePrikazLekova(LekarView parent, string jmbgLekara)
        {
            InitializeComponent();
            this.DataContext = new PagePrikazLekovaViewModel(parent, jmbgLekara);
        }  

        private void NazadClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
