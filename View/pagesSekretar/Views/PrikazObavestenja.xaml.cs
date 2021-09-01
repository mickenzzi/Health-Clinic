using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class PrikazObavestenja : Page
    {
        private SekretarView parent;
        public PrikazObavestenja(int id, SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new PacijentObavestenjaViewModel(parent, id);
        }
    }
}
