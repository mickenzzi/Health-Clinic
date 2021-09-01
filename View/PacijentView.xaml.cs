using Bolnica.DTO;
using Bolnica.Model;
using Bolnica.Repository;
using Bolnica.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for PacijentView.xaml
    /// </summary>
    public partial class PacijentView : Window
    {
        PacijentDTO pacijentDTO;
        public PacijentView()
        {
            InitializeComponent();

            MainWindow.p = new Pacijent();
            List<Pacijent> pacijenti = PacijentiRepository.Instance.GetSvePacijente();
            MainWindow.p = pacijenti.First<Pacijent>();
            pacijentDTO = new PacijentDTO();
            pacijentDTO.Pacijent = MainWindow.p;

        }
        public void exitApp(object sender, CancelEventArgs e)
        {
            MainWindow.Instance.Show();
        }

        private void onClickPretrazi(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PretragaTerminaPacijent pt = new PretragaTerminaPacijent(pacijentDTO);
            pt.Show();
        }

        private void onClickPrikazi(object sender, RoutedEventArgs e)
        {
            this.Hide();
            pacijentDTO.Pacijent = MainWindow.p;
            PregledZakazanihPacijent pzp = new PregledZakazanihPacijent(pacijentDTO);
            pzp.Show();
        }

        private void onClickOtkazi(object sender, RoutedEventArgs e)
        {
            this.Hide();
            pacijentDTO.Pacijent = MainWindow.p;
            OtkaziPacijent op = new OtkaziPacijent(pacijentDTO);
            op.Show();
        }

        private void onClickIstorijaTermina(object sender, RoutedEventArgs e)
        {
            this.Hide();
            IstorijaTerminaPacijent it = new IstorijaTerminaPacijent(pacijentDTO);
            it.Show();
        }
        private void onClickPrikazKartona(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PregledZdravstvenogKartonaPacijent pzk = new PregledZdravstvenogKartonaPacijent(pacijentDTO);
            pzk.Show();
        }
        private void onClickPrikazListeBeleski(object sender, RoutedEventArgs e)
        {
            BeleskePacijent plb = new BeleskePacijent(pacijentDTO);
            plb.ShowDialog();
        }


        private void onClickOcenjivanjeBolnicePacijent(object sender, RoutedEventArgs e)
        {
            TimeSpan vremeIzmedju = DateTime.Now.Subtract(MainWindow.p.DatumPoslednjegOcenjivanjaBolnice);
            if (vremeIzmedju.Days < 180)
            {
                MessageBox.Show("Nema aktivnih anketa!");
                return;
            }
            this.Hide();
            OcenjivanjeBolnicePacijent ob = new OcenjivanjeBolnicePacijent();
            ob.Show();
        }

    }
}