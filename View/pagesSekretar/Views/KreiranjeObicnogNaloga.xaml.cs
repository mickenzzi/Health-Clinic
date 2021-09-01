using System.Windows;
using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;


namespace Bolnica.View.pagesSekretar.Views
{
    public partial class KreiranjeObicnogNaloga : Page
    {
        private SekretarView parent;
        public KreiranjeObicnogNaloga(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new ObicanNalogViewModel(parent);
        }
    }
}
