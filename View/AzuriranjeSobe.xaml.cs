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
    /// Interaction logic for AzuriranjeSobe.xaml
    /// </summary>
    public partial class AzuriranjeSobe : Window
    {
        private Soba staraSoba;
        public AzuriranjeSobe(Soba soba)
        {

            InitializeComponent();

            staraSoba = soba;
            Sifra.Text = Convert.ToString(soba.BrojSobe);
            switch (soba.Tip)
            {
                case TipoviSobe.Bolesnicka:
                    TipSobe.SelectedIndex = 2;
                    break;
                case TipoviSobe.Magacin:
                    TipSobe.SelectedIndex = 3;
                    break;
                case TipoviSobe.OperacionaSala:
                    TipSobe.SelectedIndex = 0;
                    break;
                case TipoviSobe.Ordinacija:
                    TipSobe.SelectedIndex = 1;
                    break;
            }
            Sprat.Text = Convert.ToString(soba.Sprat);

            if (soba.Tip == TipoviSobe.Bolesnicka)
            {
                BrojKreveta.Text = Convert.ToString(soba.Kapacitet);
            }
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
                soba.Sifra = staraSoba.Sifra;
                SobeController.Instance.SetSoba(soba);

                this.Close();
                MainWindow.uv.Show();

            }
            else
            {
                Soba soba = new Soba(brojSobe, tip, sprat, 0);
                soba.Sifra = staraSoba.Sifra;
                SobeController.Instance.SetSoba(soba);

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
