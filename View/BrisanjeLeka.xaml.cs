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
    /// Interaction logic for BrisanjeLeka.xaml
    /// </summary>
    public partial class BrisanjeLeka : Window
    {
        public BrisanjeLeka()
        {
            InitializeComponent();

            List<Lek> sviLekovi = LekoviController.Instance.GetSveLekove();
            if (sviLekovi == null)
                sviLekovi = new List<Lek>();

            foreach (Lek l in sviLekovi)
            {
                Lekovi.Items.Add(l);
            }
        }

        private void onClickObrisi(object sender, RoutedEventArgs e)
        {
            Lek obrisi = (Lek)Lekovi.SelectedItem;
            LekoviController.Instance.ObrisiLek(obrisi);

            this.Close();
            MainWindow.uv.Show();
        }

        private void onClickPovratak(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.uv.Show();
        }
    }
}
