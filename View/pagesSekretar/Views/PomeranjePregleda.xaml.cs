using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class PomeranjePregleda : Page
    {
        private SekretarView parent;
        private string jmbg;
        private int idTermina;
        public PomeranjePregleda(SekretarView parent,string jmbg, int idTermina)
        {
            this.parent = parent;
            this.jmbg = jmbg;
            this.idTermina = idTermina;
            InitializeComponent();
            this.DataContext = new PomeranjePregledaViewModel(parent, jmbg,idTermina);
        }
    }
}
