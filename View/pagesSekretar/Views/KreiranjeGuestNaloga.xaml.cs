using System.Windows;
using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class KreiranjeGuestNaloga : Page
    {
        private SekretarView parent;
        public KreiranjeGuestNaloga(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new GuestNalogViewModel(parent);
        }
    }
}
