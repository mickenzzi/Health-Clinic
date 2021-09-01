using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class DodavanjeBugova : Page
    {
        private SekretarView parent;
        public DodavanjeBugova(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new DodavanjeBugovaViewModel(parent);
        }
    }
}
