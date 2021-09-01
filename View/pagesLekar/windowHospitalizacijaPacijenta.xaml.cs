using Bolnica.View.pagesLekar.ViewModel;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
namespace Bolnica.View.pagesLekar
{
    /// <summary>
    /// Interaction logic for WindowHospitalizacijaPacijenta.xaml
    /// </summary>
    public partial class WindowHospitalizacijaPacijenta : Window
    {   
        private LekarView parent;
        private int idTermina;
        public WindowHospitalizacijaPacijenta(LekarView parent,  int idTermina)
        {
            this.parent = parent;
            this.idTermina = idTermina;
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Owner = parent;
           
            WindowHospitalizacijaPacijentaViewModel hpvm = new WindowHospitalizacijaPacijentaViewModel(parent, idTermina);
            this.DataContext = hpvm;
            if (hpvm.CloseAction == null)
                hpvm.CloseAction = new Action(this.Close);
        }

        private void TrenutnaHospitalizacija_Checked(object sender, RoutedEventArgs e)
        {
            DatumHospitalizacije.IsEnabled = false;
        }

        private void TrenutnaHospitalizacija_Unchecked(object sender, RoutedEventArgs e)
        {
            DatumHospitalizacije.IsEnabled = true;
        }

        private void Odustani(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
