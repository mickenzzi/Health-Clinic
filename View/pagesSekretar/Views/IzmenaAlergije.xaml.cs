using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class IzmenaAlergije : Page
    {
        private SekretarView parent;
        public IzmenaAlergije(SekretarView parent, int idAlergije, string mb)
        {
            this.parent = parent;
            InitializeComponent();
            this.DataContext = new IzmenaAlergijeViewModel(parent, idAlergije, mb); 
        }
    }
}
