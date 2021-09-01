using System.Windows.Controls;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class Kontakt : Page
    {
        private SekretarView parent;
        public Kontakt(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void GoToPocetna(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
