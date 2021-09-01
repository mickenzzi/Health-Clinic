using Bolnica.Controller;
using Bolnica.DTO;
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
    /// Interaction logic for OcenjivanjePacijent.xaml
    /// </summary>
    public partial class OcenjivanjePacijent : Window
    {
        private TerminDTO termin;

        public OcenjivanjePacijent(TerminDTO termin)
        {
            InitializeComponent();
            this.termin = termin;
        }



        private void onClickPotvrdiOcenjivanje(object sender, RoutedEventArgs e)
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
            Lekar lekar = LekariController.Instance.GetOdgLekarByJmbg(termin.Termin.Lekar.Jmbg);

            Ocena ocena = new Ocena(vrednostOcene, lekar , dodatniKomentar);
            OceneController.Instance.DodajOcenu(ocena);
            termin.Termin.Ocenjen = true;
            TerminiController.Instance.SetTermin(termin.Termin);
            MessageBox.Show("Uspešno ste ocenili lekara za odabrani termin!");
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
