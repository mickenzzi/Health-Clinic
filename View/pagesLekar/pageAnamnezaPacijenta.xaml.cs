using Bolnica.View.pagesLekar.ViewModel;
using System.Windows.Controls;

namespace Bolnica.View.pagesLekar
{
    /// <summary>
    /// Interaction logic for PageAnamnezaPacijenta.xaml
    /// </summary>
    public partial class PageAnamnezaPacijenta : Page
    {
        public PageAnamnezaPacijenta(LekarView parent, int idTermina)
        {
            InitializeComponent();
            this.DataContext = new PageAnamnezaPacijentaViewModel(parent, idTermina);
        }
    }
}
