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
    /// Interaction logic for PregledZakazanihPacijent.xaml
    /// </summary>
    public partial class PregledZakazanihPacijent : Window
    {
        private PacijentDTO pacijent;
        public PregledZakazanihPacijent(PacijentDTO pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;

            List<Termin> zakazaniTermini = TerminiController.Instance.getZakazaneTermine(pacijent.Pacijent);
           if(zakazaniTermini == null)
            {
                zakazaniTermini = new List<Termin>();
            }
            foreach (Termin t in zakazaniTermini)
            {
                ZakazaniTermini.Items.Add(t);
            }
        }

        private void onClickPovratak(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.pv.Show();
        }

        private void onClickPomeri(object sender, RoutedEventArgs e)
        {
            this.Hide();
            TerminDTO termin = new TerminDTO();
            termin.Termin = (Termin)ZakazaniTermini.SelectedItem;
            AzuriranjeTermina at = new AzuriranjeTermina(termin, pacijent);
            if (at.ShowActivated)
            {
                at.Show();
            }
            this.Show();
        }
    }
}
