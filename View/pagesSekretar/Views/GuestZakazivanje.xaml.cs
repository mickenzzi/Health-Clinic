using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class GuestZakazivanje : Page
    {
        private SekretarView parent;
        public GuestZakazivanje(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new GuestZakazivanjeViewModel(parent);
        }
    }
}
