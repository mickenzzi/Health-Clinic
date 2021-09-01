using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class DodavanjeAlergije : Page
    {
        private SekretarView parent;
        public DodavanjeAlergije(SekretarView parent,string jmbg)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new DodavanjeAlergijaViewModel(parent, jmbg);
        }
    }
}
