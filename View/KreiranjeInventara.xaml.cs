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
    /// Interaction logic for KreiranjeInventara.xaml
    /// </summary>
    public partial class KreiranjeInventara : Window
    {
        public KreiranjeInventara()
        {
            InitializeComponent();
        }

        private void onClickOdustani(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.uv.Show();
        }

        private void onClickPotvrdi(object sender, RoutedEventArgs e)
        {
            TipoviInventara tip = TipoviInventara.BolnickiKrevet;
            switch(tipInventara.SelectedIndex)
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
            int kolInt = Convert.ToInt32(kolicina.Text);
            int brSobe = Convert.ToInt32(brojSobe.Text);
            int sifraSobe = 0;

            List<Soba> sobe = SobeController.Instance.GetSveSobe();
            foreach(Soba s in sobe)
            {
                if(s.BrojSobe == brSobe)
                {
                    sifraSobe = s.Sifra;
                }
            }

            Inventar inventar = new Inventar(tip, kolInt, sifraSobe);

            InventarController.Instance.DodajInventar(inventar);

            this.Close();
            MainWindow.uv.Show();

        }
    }
}
