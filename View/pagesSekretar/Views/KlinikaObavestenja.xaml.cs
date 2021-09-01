using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class KlinikaObavestenja : Page
    {
        private SekretarView parent;
        public KlinikaObavestenja(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new KlinikaObavestenjaViewModel(parent);
        }
    }
}
