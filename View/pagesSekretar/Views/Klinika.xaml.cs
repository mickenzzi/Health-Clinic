using System.Windows;
using System.Windows.Controls;


namespace Bolnica.View.pagesSekretar.Views
{
    public partial class Klinika : Page
    {
        private SekretarView parent;
        public Klinika(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void GoToPocetna(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
