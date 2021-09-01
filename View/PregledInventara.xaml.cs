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
    /// Interaction logic for PregledInventara.xaml
    /// </summary>
    public partial class PregledInventara : Window
    {
        public PregledInventara()
        {
            InitializeComponent();

            List<Inventar> savInventar = InventarController.Instance.GetSavInventar();
            if (savInventar == null)
                savInventar = new List<Inventar>();

            foreach (Inventar i in savInventar)
            {
                Inventar.Items.Add(i);
            }
        }

        private void onClickPovratak(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.uv.Show();
        }

        private void onClickAzuriraj(object sender, RoutedEventArgs e)
        {
            Inventar i = (Inventar)Inventar.SelectedItem;
            this.Close();
            AzuriranjeInventara ai = new AzuriranjeInventara(i);
            ai.Show();
        }
    }
}