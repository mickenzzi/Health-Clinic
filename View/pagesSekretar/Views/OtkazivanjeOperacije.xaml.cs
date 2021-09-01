using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class OtkazivanjeOperacije : Page
    {
        private SekretarView parent;
        private string jmbg;
        public OtkazivanjeOperacije(SekretarView parent, string jmbg)
        {
            this.parent = parent;
            this.jmbg = jmbg;
            InitializeComponent();
            this.DataContext = new OperacijaViewModel(parent, jmbg);
        } 
    }
}
