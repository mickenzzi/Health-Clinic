using Bolnica.View.pagesLekar.ViewModel;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Bolnica.View.pagesLekar
{
    /// <summary>
    /// Interaction logic for WindowProduziHospitalizaciju.xaml
    /// </summary>
    public partial class WindowProduziHospitalizaciju : Window
    {
        public WindowProduziHospitalizaciju(LekarView parent, int idTermina)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Owner = parent;
            WindowProduziHospitalizacijuViewModel phvm = new WindowProduziHospitalizacijuViewModel(parent, idTermina);
            this.DataContext = phvm;
            if (phvm.CloseAction == null)
                phvm.CloseAction = new Action(this.Close);
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
