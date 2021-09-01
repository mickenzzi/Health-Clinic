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
    /// Interaction logic for ObrisiProstoriju.xaml
    /// </summary>
    public partial class ObrisiProstoriju : Window
    {
        public ObrisiProstoriju()
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

        private void onClickPotvrdi(object sender, RoutedEventArgs e)
        {
            Object temp = Sobe.SelectedItem;
            Soba izabranaSoba = (Soba)temp;
            SobeController.Instance.ObrisiSobu(izabranaSoba);

            this.Close();
            MainWindow.uv.Show();
            
        }

        private void onClickOdustani(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.uv.Show();
        }
    }
}
