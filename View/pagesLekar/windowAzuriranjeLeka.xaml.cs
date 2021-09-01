using Bolnica.View.pagesLekar.ViewModel;
using System;
using System.Windows;

namespace Bolnica.View.pagesLekar
{
    /// <summary>
    /// Interaction logic for WindowAzuriranjeLeka.xaml
    /// </summary>
    public partial class WindowAzuriranjeLeka : Window
    {
        private LekarView parent;
        public WindowAzuriranjeLeka(LekarView parent, int sifraLeka, string jmbgLekara)
        {
            this.parent = parent;
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Owner = parent;

            WindowAzuriranjeLekaViewModel alvm = new WindowAzuriranjeLekaViewModel(parent, sifraLeka, jmbgLekara);
            this.DataContext = alvm;
            if (alvm.CloseAction == null)
                alvm.CloseAction = new Action(this.Close);
        }
    }
}
