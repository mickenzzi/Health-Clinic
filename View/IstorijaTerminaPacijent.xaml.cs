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
    /// Interaction logic for IstorijaTerminaPacijent.xaml
    /// </summary>
    public partial class IstorijaTerminaPacijent : Window
    {
        private PacijentDTO pacijent;
        public IstorijaTerminaPacijent(PacijentDTO pacijent)
        {

            InitializeComponent();
            this.pacijent = pacijent;

            List<Termin> zakazaniTermini = TerminiController.Instance.getZakazaneTermine(pacijent.Pacijent);
            if (zakazaniTermini == null)
            {
                zakazaniTermini = new List<Termin>();
            }
            foreach (Termin t in zakazaniTermini)
            {
                if (DateTime.Now >= t.DatumVreme.AddMinutes(20))
                {
                    ZakazaniTermini.Items.Add(t);
                }
            }
        }

        private void onClickPovratak(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.pv.Show();
        }

        private void onClickOceni(object sender, RoutedEventArgs e)
        {
            TerminDTO termin = new TerminDTO(); 
            termin.Termin = (Termin)ZakazaniTermini.SelectedItem;
            if (termin.Termin.Ocenjen == true)
            {
                MessageBox.Show("Već ste ocenili lekara za dati termin!");
                return;
            }
            this.Close();
            OcenjivanjePacijent op = new OcenjivanjePacijent(termin);
            op.Show();
        }
    }
}
