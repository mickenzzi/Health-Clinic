using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Xml.Serialization;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for UpravnikView.xaml
    /// </summary>
    public partial class UpravnikView : Window
    {
        public UpravnikView()
        {
            InitializeComponent();

            MainWindow.u = new Upravnik();

        }

        private void onClickRegistruj(object sender, RoutedEventArgs e)
        {
            this.Hide();
            KreiranjeProstorije kp = new KreiranjeProstorije();
            kp.Show();

        }

        private void onClickPregled(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PregledProstorija pp = new PregledProstorija();
            pp.Show();
        }

        private void onClickObrisi(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ObrisiProstoriju op = new ObrisiProstoriju();
            op.Show();
        }

        private void onClickRegInventar(object sender, RoutedEventArgs e)
        {
            this.Hide();
            KreiranjeInventara ki = new KreiranjeInventara();
            ki.Show();

        }

        private void onClickPregledInventara(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PregledInventara pi = new PregledInventara();
            pi.Show();
        }


        private void onClickObrisiInventar(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BrisanjeInventara bi = new BrisanjeInventara();
            bi.Show();
        }


        private void onClickPremestiInventar(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PremestanjeInventara pi = new PremestanjeInventara();
            pi.Show();
        }

        private void onClickRegistrujLek(object sender, RoutedEventArgs e)
        {
            this.Hide();
            KreiranjeLeka kl = new KreiranjeLeka();
            kl.Show();
        }
        private void onClickPregledLekova(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PregledLekova pl = new PregledLekova();
            pl.Show();
        }
        private void onClickObrisiLek(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BrisanjeLeka bl = new BrisanjeLeka();
            bl.Show();
        }

        private void onClickPretragaInventara(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PretragaInventara pi = new PretragaInventara();
            pi.Show();
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {

            MainWindow.Instance.Show();

        }


    }
}
