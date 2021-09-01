using System.Windows;
using System.Windows.Controls;
using Bolnica.View.pagesSekretar.ViewModel;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class HitnoPomeranjeOperacija : Page
    {
        private SekretarView parent;
        private string jmbg;
        public HitnoPomeranjeOperacija(SekretarView parent, string jmbg)
        {
            InitializeComponent();
            this.parent = parent;
            this.jmbg = jmbg;
            this.DataContext = new HitnoPomeranjeOperacijeViewModel(parent, jmbg);
        }
    }
}
