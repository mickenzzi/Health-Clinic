using System.Windows;
using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class NormalnoZakazivanje : Page
    {
        private SekretarView parent;
        public NormalnoZakazivanje(SekretarView parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new NormalnoZakazivanjeViewModel(parent);
        }
    }
}
