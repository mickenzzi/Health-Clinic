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
    /// Interaction logic for OcenjivanjeBolnicePacijent.xaml
    /// </summary>
    public partial class OcenjivanjeBolnicePacijent : Window
    {
        public OcenjivanjeBolnicePacijent()
        {
            InitializeComponent();
        }

        private void onClickPotvrdiOcenjivanjeBolnice(object sender, RoutedEventArgs e)
        {
            Ocene vrednostOcene;
            if (jedan.IsChecked == true)
                vrednostOcene = Ocene.Jedan;
            else if (dva.IsChecked == true)
                vrednostOcene = Ocene.Dva;
            else if (tri.IsChecked == true)
                vrednostOcene = Ocene.Tri;
            else if (cetiri.IsChecked == true)
                vrednostOcene = Ocene.Cetiri;
            else
                vrednostOcene = Ocene.Pet;

            String dodatniKomentar = DodatniKomentar.Text;

            Ocena ocena = new Ocena(vrednostOcene, dodatniKomentar);
            OceneController.Instance.DodajOcenu(ocena);
            MainWindow.p.DatumPoslednjegOcenjivanjaBolnice = DateTime.Now;
            PacijentiController.Instance.SetPacijent(MainWindow.p);
            MessageBox.Show("Uspešno ste ocenili bolnicu!");
            this.Close();
            MainWindow.pv.Show();
        }

        private void onClickOdustani(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.pv.Show();
        }
    }
}
