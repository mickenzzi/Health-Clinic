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
    /// Interaction logic for AzuriranjeLeka.xaml
    /// </summary>
    public partial class AzuriranjeLeka : Window
    {
        private Lek stariLek;
        
        public AzuriranjeLeka(Lek lek)
        {
            this.stariLek = lek;
            InitializeComponent();

            if (lek != null)
            {
                SifraSobe.Text = Convert.ToString(lek.SifraSobe);
                KolicinaLeka.Text = Convert.ToString(lek.Kolicina);
                NazivLeka.Text = Convert.ToString(lek.Naziv);
                Sastojci.Text = lek.Sastojci;

                int sifraZameneLeka = lek.Zamena;
                Lek nazivZamene = LekoviController.Instance.GetLekById(sifraZameneLeka);
                PostojecaZamena.Text = nazivZamene.Naziv;

                List<Lek> lekovi = LekoviController.Instance.GetSveLekove();
                if (lekovi == null)
                    lekovi = new List<Lek>();
                foreach (Lek l in lekovi)
                    if (l.Sifra != lek.Sifra && l.Sifra != lek.Zamena)
                        Lekovi.Items.Add(l);
            }
            else
                MessageBox.Show("Prvo izaberite lek!");

        }

        private void onClickPotvrdi(object sender, RoutedEventArgs e)
        {
            String naziv = NazivLeka.Text;
            string doza = Doza.Text;
            int kolicina = Convert.ToInt32(KolicinaLeka.Text);
            int sifraSobe = Convert.ToInt32(SifraSobe.Text);
            string sastojci = Sastojci.Text;
            int sifraZamene = stariLek.Zamena;

            Lek zamenaLeka = (Lek)Lekovi.SelectedItem;

            if (zamenaLeka != null)
                sifraZamene = zamenaLeka.Sifra;

            Lek noviLek = new Lek(naziv, doza, kolicina, sifraSobe, sifraZamene, sastojci);
            LekoviController.Instance.IzmeniLek(stariLek, noviLek);

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
