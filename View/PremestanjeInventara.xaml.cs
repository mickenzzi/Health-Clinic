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
    /// Interaction logic for PremestanjeInventara.xaml
    /// </summary>
    public partial class PremestanjeInventara : Window
    {
        public PremestanjeInventara()
        {
            InitializeComponent();
        }

        private void onClickPovratak(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.uv.Show();
        }

        private void onClickPrikazi1(object sender, RoutedEventArgs e)
        {
            int brojSobe = Convert.ToInt32(soba1.Text);
            List<Inventar> inventar = InventarController.Instance.GetSavInventar();
            foreach (Inventar i in inventar)
            {
                if (i.BrojSobe == brojSobe)
                {
                    InventarSobe1.Items.Add(i);
                }
            }
        }

        private void onClickPrikazi2(object sender, RoutedEventArgs e)
        {
            int brojSobe = Convert.ToInt32(soba2.Text);
            List<Inventar> inventar = InventarController.Instance.GetSavInventar();
            foreach (Inventar i in inventar)
            {
                if (i.BrojSobe == brojSobe)
                {
                    InventarSobe2.Items.Add(i);
                }
            }
        }

        private void onClickPremesti(object sender, RoutedEventArgs e)
        {
            DateTime temp = (DateTime)DatumPomeranja.SelectedDate;
            DateTime vremeP = new DateTime(temp.Year, temp.Month, temp.Day, Convert.ToInt32(brojSati.Text), Convert.ToInt32(brojMinuta.Text), 0);
            int kolInv = Convert.ToInt32(kolicina.Text);
            List<Termin> termini = TerminiController.Instance.GetSveTermine();
            Inventar i = (Inventar)InventarSobe1.SelectedItem;

            int sobaD = Convert.ToInt32(soba2.Text);
            if (!InventarController.Instance.PremestiInventar(i, sobaD, kolInv, vremeP))
            {
                return;
            }
            this.Close();
            MainWindow.uv.Show();
        }

    }
}
