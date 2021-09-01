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
    /// Interaction logic for PretragaTerminaPacijent.xaml
    /// </summary>
    public partial class PretragaTerminaPacijent : Window
    {
        PacijentDTO pacijent;
        public PretragaTerminaPacijent(PacijentDTO p)
        {
            InitializeComponent();
            pacijent = p;
            DatumOd.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue, DateTime.Now));
            DatumDo.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue, DateTime.Now));

            lekari.Items.Add("Bilo koji lekar");
            List<Termin> sviTermini = TerminiController.Instance.GetSveTermine();
            foreach (Termin t in sviTermini)
            {
                if (!lekari.Items.Contains(t.ImePrzLekar))
                    lekari.Items.Add(t.ImePrzLekar);
            }
            lekari.SelectedItem = "Bilo koji lekar";
        }

        private void onClickOdustani(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.pv.Show();
        }

        private void onClickCheckBox(object sender, RoutedEventArgs e)
        {
            if (!(bool)bitnoVreme.IsChecked)
            {
                DatumDo.IsEnabled = false;
                DatumOd.IsEnabled = false;
                brojMinutaDo.IsEnabled = false;
                brojMinutaOd.IsEnabled = false;
                brojSatiDo.IsEnabled = false;
                brojSatiOd.IsEnabled = false;
            }
            else
            {
                DatumDo.IsEnabled = true;
                DatumOd.IsEnabled = true;
                brojMinutaDo.IsEnabled = true;
                brojMinutaOd.IsEnabled = true;
                brojSatiDo.IsEnabled = true;
                brojSatiOd.IsEnabled = true;
            }
        }
        private void onClickPretrazi(object sender, RoutedEventArgs e)
        {

            String lekar = "";
            if (lekari.SelectedItem != "Bilo koji lekar")
            {
                lekar = (String)lekari.SelectedItem;
            }

            if ((bool)bitnoVreme.IsChecked)
            {
                if (!daLiSuSvaPoljaPopunjena())
                {
                    return;
                }
                DateTime tempPocetno = (DateTime)DatumOd.SelectedDate;
                DateTime pocetnoVreme = new DateTime(tempPocetno.Year, tempPocetno.Month, tempPocetno.Day, Convert.ToInt32(brojSatiOd.Text), Convert.ToInt32(brojMinutaOd.Text), 0);

                DateTime tempKrajnje = (DateTime)DatumDo.SelectedDate;
                DateTime krajnjeVreme = new DateTime(tempKrajnje.Year, tempKrajnje.Month, tempKrajnje.Day, Convert.ToInt32(brojSatiDo.Text), Convert.ToInt32(brojMinutaDo.Text), 0);
                if (daLiJeVremePocetnogTerminaManjeOdKrajnjeg(pocetnoVreme, krajnjeVreme)) 
                {
                    return;
                }

                if (!daLiPostojeTerminiPoZadatimKriterijumima(pocetnoVreme, krajnjeVreme, lekar)) 
                {
                    return;
                }
            }
            else
            {
                if (!daLiPostojeTerminiKodOdabranogLekara(lekar)) 
                {
                    return;
                }
            }
        }

        private bool daLiSuSvaPoljaPopunjena()
        {
            if (!DatumOd.SelectedDate.HasValue || !DatumDo.SelectedDate.HasValue
                       || brojSatiDo.Text == "" || brojSatiOd.Text == ""
                       || brojMinutaDo.Text == "" || brojMinutaOd.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
                return false;
            }
            return true;
        }
        private bool daLiJeVremePocetnogTerminaManjeOdKrajnjeg(DateTime pocetnoVreme, DateTime krajnjeVreme)
        {
            TimeSpan interval = krajnjeVreme.Subtract(pocetnoVreme);
            if (interval.Days < 0 || (interval.Days == 0 && interval.Hours < 0)
                || (interval.Days == 0 && interval.Hours == 0 && interval.Minutes < 0))
            {
                MessageBox.Show("Pocetni termin pretrage mora biti manji od krajnjeg!");
                return true;
            }
            return false;
        }

        private bool daLiPostojeTerminiPoZadatimKriterijumima(DateTime pocetnoVreme, DateTime krajnjeVreme, String lekar)
        {
            pacijent.ListaTermina = PacijentiController.Instance.GetTermineOdDo(pacijent.Pacijent, pocetnoVreme, krajnjeVreme, lekar);
            if (pacijent.ListaTermina.Count > 0)
            {
                ZakazivanjePacijent zp = new ZakazivanjePacijent(pacijent);
                this.Hide();
                zp.Show();
            }
            else
            {
                MessageBox.Show("Nema slobodnih termina za zadate kriterijume");
                return false;
            }
            return true;
        }
        private bool daLiPostojeTerminiKodOdabranogLekara(string lekar)
        {
            pacijent.ListaTermina = PacijentiController.Instance.GetTerminePoLekaru(lekar);

            if (pacijent.ListaTermina.Count > 0)
            {
                ZakazivanjePacijent zp = new ZakazivanjePacijent(pacijent);
                this.Hide();
                zp.Show();
            }
            else
            {
                MessageBox.Show("Nema slobodnih termina za zadate kriterijume");
                return false;
            }
            return true;
        }
    }
}
