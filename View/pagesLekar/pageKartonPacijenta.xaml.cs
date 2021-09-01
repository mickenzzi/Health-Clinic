using Bolnica.View.pagesLekar.ViewModel;
using System.Windows.Controls;

namespace Bolnica.View.pagesLekar
{
    /// <summary>
    /// Interaction logic for PageKartonPacijenta.xaml
    /// </summary>
    public partial class PageKartonPacijenta : Page
    {
        public PageKartonPacijenta(LekarView parent, int idTermina)
        {
            InitializeComponent();
            this.DataContext = new PageKartonPacijentaViewModel(parent, idTermina);
        }
    }
}
