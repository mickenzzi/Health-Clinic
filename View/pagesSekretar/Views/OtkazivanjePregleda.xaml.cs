using System.Windows;
using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class OtkazivanjePregleda : Page
    {
        private SekretarView parent;
        private string jmbg;
        public OtkazivanjePregleda(SekretarView parent,string jmbg)
        {
            this.parent = parent;
            this.jmbg = jmbg;
            InitializeComponent();
            this.DataContext = new PregledViewModel(parent, jmbg);
        }
    }
}
