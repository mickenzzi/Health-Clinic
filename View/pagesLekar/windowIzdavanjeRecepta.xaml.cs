using Bolnica.View.pagesLekar.ViewModel;
using System;
using System.Windows;

namespace Bolnica.View.pagesLekar
{
    /// <summary>
    /// Interaction logic for WindowIzdavanjeRecepta.xaml
    /// </summary>
    public partial class WindowIzdavanjeRecepta : Window
    {
        public WindowIzdavanjeRecepta(LekarView parent, int idTermina)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Owner = parent;
            WindowIzdavanjeReceptaViewModel irvm = new WindowIzdavanjeReceptaViewModel(parent, idTermina);
            this.DataContext = irvm;
            if (irvm.CloseAction == null)
                irvm.CloseAction = new Action(this.Close);
        }

        private void Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
