using Bolnica.View.pagesLekar.ViewModel;
using System;
using System.Windows;

namespace Bolnica.View.pagesLekar
{
    /// <summary>
    /// Interaction logic for WindowIzmeniTermin.xaml
    /// </summary>
    public partial class WindowIzmeniTermin : Window
    {
        public WindowIzmeniTermin(LekarView parent, int idTermina)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Owner = parent;
            WindowIzmeniTerminViewModel itvm = new WindowIzmeniTerminViewModel(parent, idTermina);
            this.DataContext = itvm;
            if (itvm.CloseAction == null)
                itvm.CloseAction = new Action(this.Close);
        }

        private void Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
