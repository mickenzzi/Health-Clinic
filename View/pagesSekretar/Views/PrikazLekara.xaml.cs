using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class PrikazLekara : Page
    {
        private SekretarView parent;
        public PrikazLekara(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new LekarViewModel(parent);
        }
    }
}
