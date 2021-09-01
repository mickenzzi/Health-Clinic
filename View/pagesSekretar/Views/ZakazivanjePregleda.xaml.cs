using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class ZakazivanjePregleda : Page
    {
        private SekretarView parent;
        private string jmbg;
        public ZakazivanjePregleda(SekretarView parent,string jmbg)
        {
            this.parent = parent;
            this.jmbg = jmbg;
            InitializeComponent();
            this.DataContext = new ZakazivanjePregledaViewModel(parent, jmbg);
        }
    }
}
