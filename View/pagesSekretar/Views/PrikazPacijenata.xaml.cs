using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class PrikazPacijenata : Page
    {
        private SekretarView parent;
        public PrikazPacijenata(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new PacijentViewModel(parent);
        }
    }
}
