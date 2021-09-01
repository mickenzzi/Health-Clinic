using Bolnica.Controller;
using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for ZakazivanjeRenoviranja.xaml
    /// </summary>
    public partial class ZakazivanjeRenoviranja : Window
    {
        private Soba soba;
        public ZakazivanjeRenoviranja(Soba soba)
        {

            InitializeComponent();

            this.soba = soba;
            DatumPocetka.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue, DateTime.Now));
            DatumZavrsetka.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue, DateTime.Now.AddDays(1)));
        }

        private void onClickPotvrdi(object sender, RoutedEventArgs e)
        {
            DateTime pocetakRenovranja = DatumPocetka.SelectedDate.Value;
            DateTime zavrsetakRenovranja = DatumZavrsetka.SelectedDate.Value;

            if (pocetakRenovranja.CompareTo(zavrsetakRenovranja) > 0)
            {
                MessageBox.Show("Datum zavrsetka mora biti nakon datuma pocetka!");
                return;
            }

            RenoviranjeController.Instance.ZakaziRenoviranje(soba, pocetakRenovranja, zavrsetakRenovranja);

            this.Close();
            MainWindow.uv.Show();
        }

        private void onClickOdustani(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.uv.Show();
        }
    }
}
