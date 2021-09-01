using Bolnica.Controller;
using Bolnica.DTO;
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
    /// Interaction logic for AzuriranjeTermina.xaml
    /// </summary>
    public partial class AzuriranjeTermina : Window
    {
        private TerminDTO termin;
        private PacijentDTO pacijent;

        public AzuriranjeTermina(TerminDTO termin, PacijentDTO pacijent)
        {
            InitializeComponent();
            this.termin = termin;
            this.pacijent = pacijent;

            if (!daLiJeBarDanPredTermin())
            {
                this.Close();
                this.ShowActivated = false;
                return;
                //MainWindow.pv.Show();
            }

            DateTime blackoutDate1 = termin.Termin.DatumVreme.AddDays(-3);
            DateTime blackoutDate2 = termin.Termin.DatumVreme.AddDays(3);

            DateTime trenutnoVreme = DateTime.Now;

            DatumPomeranja.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue, trenutnoVreme));
            DatumPomeranja.BlackoutDates.Add(new CalendarDateRange(trenutnoVreme, blackoutDate1));
            DatumPomeranja.BlackoutDates.Add(new CalendarDateRange(blackoutDate2, DateTime.MaxValue));

            DatumPomeranja.SelectedDate = termin.Termin.DatumVreme.Date;
            brojSati.Text = Convert.ToString(termin.Termin.DatumVreme.Hour);
            brojMinuta.Text = Convert.ToString(termin.Termin.DatumVreme.Minute);
        }

        private void onClickPotvrdi(object sender, RoutedEventArgs e)
        {
            DateTime temp = (DateTime)DatumPomeranja.SelectedDate;
            DateTime novoVreme = new DateTime(temp.Year, temp.Month, temp.Day, Convert.ToInt32(brojSati.Text), Convert.ToInt32(brojMinuta.Text), 0);

            bool daLiJeAzuriran = PacijentiController.Instance.AzurirajTermin(novoVreme, termin.Termin, pacijent.Pacijent);
            ispisPorukeAzuriranja(daLiJeAzuriran);
            this.Close();
            MainWindow.pv.Show();
        }

        private void ispisPorukeAzuriranja(bool uspesno)
        {
            if (!uspesno)
            {
                MessageBox.Show("Maksimalan broj ažuriranja termina u danu je 2!");
            }
            else
            {
                MessageBox.Show("Uspešno ste ažurirali termin!");
            }
        }
        private void onClickOdustani(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.pv.Show();
        }

        public bool daLiJeBarDanPredTermin()
        {
            DateTime trenutnoVreme = DateTime.Now;
            TimeSpan interval = termin.Termin.DatumVreme.Subtract(trenutnoVreme);

            if (interval.Days < 1 && interval.Hours < 24)
            {
                MessageBox.Show("Pomeranje termina mora biti bar 24h pre!");
                return false;
            }
            return true;
        }
    }
}