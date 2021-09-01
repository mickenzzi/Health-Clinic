using System.Windows;
using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class IzmenaObavestenja : Page
    {
        private SekretarView parent;
        public IzmenaObavestenja(SekretarView parent,int idObavestenja)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new IzmenaObavestenjaViewModel(parent, idObavestenja);
        }
    }
}
