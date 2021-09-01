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
    /// Interaction logic for PretragaInventara.xaml
    /// </summary>
    public partial class PretragaInventara : Window
    {
        public PretragaInventara()
        {
            InitializeComponent();
        }

        private void onClickPrikazi(object sender, RoutedEventArgs e)
        {
            Inventar.Items.Clear();

            List<Inventar> inventar = InventarController.Instance.GetSavInventar();
            if (tipInventaraBitan.IsChecked == true && brojSobeBitan.IsChecked == false)
            {
                TipoviInventara tip = TipoviInventara.BolnickiKrevet;

                switch (tipInventara.SelectedIndex)
                {

                    case 3:
                        tip = TipoviInventara.AparatZaAnesteziju;
                        break;
                    case 0:
                        tip = TipoviInventara.BolnickiKrevet;
                        break;
                    case 2:
                        tip = TipoviInventara.Defibrilator;
                        break;
                    case 1:
                        tip = TipoviInventara.HirurskiSto;
                        break;
                    case 5:
                        tip = TipoviInventara.MasinaZaEKG;
                        break;
                    case 4:
                        tip = TipoviInventara.Sterilizator;
                        break;
                }
                foreach (Inventar i in inventar)
                {
                    if (i.TipInventara == tip)
                    {
                        Inventar.Items.Add(i);
                    }
                }
            }
            else if (brojSobeBitan.IsChecked == true && tipInventaraBitan.IsChecked == false)
            {
                int brojSobe = Convert.ToInt32(soba.Text);
                foreach (Inventar i in inventar)
                {
                    if (i.BrojSobe == brojSobe)
                    {
                        Inventar.Items.Add(i);
                    }
                }
            }
            else if (tipInventaraBitan.IsChecked == true && brojSobeBitan.IsChecked == true)
            {
                TipoviInventara tip = TipoviInventara.BolnickiKrevet;
                int brojSobe = Convert.ToInt32(soba.Text);

                switch (tipInventara.SelectedIndex)
                {

                    case 3:
                        tip = TipoviInventara.AparatZaAnesteziju;
                        break;
                    case 0:
                        tip = TipoviInventara.BolnickiKrevet;
                        break;
                    case 2:
                        tip = TipoviInventara.Defibrilator;
                        break;
                    case 1:
                        tip = TipoviInventara.HirurskiSto;
                        break;
                    case 5:
                        tip = TipoviInventara.MasinaZaEKG;
                        break;
                    case 4:
                        tip = TipoviInventara.Sterilizator;
                        break;
                }

                foreach (Inventar i in inventar)
                {
                    if (i.BrojSobe == brojSobe && i.TipInventara == tip)
                    {
                        Inventar.Items.Add(i);
                    }
                }
            }
            else
            {
                foreach (Inventar i in inventar)
                {
                    Inventar.Items.Add(i);
                }
            }


        }

        private void onClickOdustani(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.uv.Show();
        }

        private void onClickCheckBoxSobe(object sender, RoutedEventArgs e)
        {
            if (!(bool)brojSobeBitan.IsChecked)
            {
                soba.IsEnabled = false;
            }
            else
            {
                soba.IsEnabled = true;
            }
        }

        private void onClickCheckBoxTip(object sender, RoutedEventArgs e)
        {
            if (!(bool)tipInventaraBitan.IsChecked)
            {
                tipInventara.IsEnabled = false;
            }
            else
            {
                tipInventara.IsEnabled = true;
            }
        }












    }
}