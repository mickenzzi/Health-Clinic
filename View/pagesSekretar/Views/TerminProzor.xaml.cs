using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class TerminProzor : Page
    {
        private SekretarView parent;
        public TerminProzor(SekretarView parent,string jmbgP)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new TerminViewModel(parent, jmbgP);
        }
    }
}
