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
    /// Interaction logic for PregledProstorija.xaml
    /// </summary>
    public partial class PregledProstorija : Window
    {
        public PregledProstorija()
        {
            InitializeComponent();

            List<Soba> sveSobe = SobeController.Instance.GetSveSobe();
            if (sveSobe == null)
                sveSobe = new List<Soba>();

            foreach (Soba s in sveSobe)
            {
                Sobe.Items.Add(s);
            }
        }
        private void onClickPovratak(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.uv.Show();
        }

        private void onClickAzuriraj(object sender, RoutedEventArgs e)
        {
            Soba s = (Soba)Sobe.SelectedItem;
            this.Close();
            AzuriranjeSobe az = new AzuriranjeSobe(s);
            az.Show();
        }

        private void onClickZakaziRenoviranje(Object sender, RoutedEventArgs e)
        {
            Soba s = (Soba)Sobe.SelectedItem;
            this.Close();
            ZakazivanjeRenoviranja zr = new ZakazivanjeRenoviranja(s);
            zr.Show();
        }
    }
}
