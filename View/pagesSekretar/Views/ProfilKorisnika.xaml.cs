using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class ProfilKorisnika : Page
    {
        private SekretarView parent;
        public ProfilKorisnika(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new ProfilKorisnikaViewModel(parent, "2212998180850");
        }
    }
}
