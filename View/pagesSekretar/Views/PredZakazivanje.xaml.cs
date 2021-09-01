using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class PredZakazivanje : Page
    {
        private SekretarView parent;
        public PredZakazivanje(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new ZakazivanjeViewModel(parent);
        }
    }
}
