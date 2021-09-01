using System.Windows;
using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class DodavanjeObavestenja : Page
    {
        private SekretarView parent;
        public DodavanjeObavestenja(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new DodavanjeObavestenjaViewModel(parent);
        }
    }
}
