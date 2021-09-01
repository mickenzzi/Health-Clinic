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
using Bolnica.Controller;
using Bolnica.DTO;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for OtkaziPacijent.xaml
    /// </summary>
    public partial class OtkaziPacijent : Window
    {

        PacijentDTO pacijent;
        public OtkaziPacijent(PacijentDTO pacijent)
        {
            InitializeComponent();

            this.pacijent = pacijent;
            List<Termin> zakazaniTermini = TerminiController.Instance.getZakazaneTermine(pacijent.Pacijent);
            foreach(Termin t in zakazaniTermini)
            {
                ZakazaniTermini.Items.Add(t);
            }
        }

        private void onClickPotvrdi(object sender, RoutedEventArgs e)
        {
            Object temp = ZakazaniTermini.SelectedItem;
            Termin izabrani = (Termin)temp;
            PacijentiController.Instance.OtkaziPregled(pacijent.Pacijent, izabrani);

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
