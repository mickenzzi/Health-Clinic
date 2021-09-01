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
    /// Interaction logic for KreiranjeProstorije.xaml
    /// </summary>
    public partial class KreiranjeProstorije : Window
    {
        public KreiranjeProstorije()
        {
            InitializeComponent();
        }

        private void onClickPotvrdi(object sender, RoutedEventArgs e)
        {
            string temp1 = Sifra.Text;
            int brojSobe = Convert.ToInt32(temp1);
            TipoviSobe tip;
            switch (TipSobe.SelectedIndex) 
            {
                case 0:
                    tip = TipoviSobe.OperacionaSala;
                    break;
                case 1:
                    tip = TipoviSobe.Ordinacija;
                    break;
                case 2:
                    tip = TipoviSobe.Bolesnicka;
                    break;
                default:
                    tip = TipoviSobe.Magacin;
                    break;
            }

            string temp2;
            string temp3 = Sprat.Text;
            int sprat = Convert.ToInt32(temp3);
            int brKreveta = 0;
            if (tip.Equals(TipoviSobe.Bolesnicka))
            {
                temp2 = BrojKreveta.Text;
                brKreveta = Convert.ToInt32(temp2);
                Soba soba = new Soba(brojSobe, tip, sprat, brKreveta);
                bool uspesno = SobeController.Instance.DodajSobu(soba);

                this.Close();
                MainWindow.uv.Show();

            }
            else 
            {
                Soba soba = new Soba(brojSobe, tip, sprat, 0);
                bool uspesno = SobeController.Instance.DodajSobu(soba);

                this.Close();
                MainWindow.uv.Show();
            }
        }

        private void onClickOdustani(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.uv.Show();
        }
    }
}
