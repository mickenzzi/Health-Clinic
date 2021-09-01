using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class IzmenaPacijenta : Page
    {
        private SekretarView parent;
        public IzmenaPacijenta(SekretarView parent, string jmbg)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new IzmenaPacijentaViewModel(parent, jmbg);
        }
    }
}
