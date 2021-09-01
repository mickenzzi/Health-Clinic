using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.Service;
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
    /// Interaction logic for KreiranjeLeka.xaml
    /// </summary>
    public partial class KreiranjeLeka : Window
    {
        public KreiranjeLeka()
        {
            InitializeComponent();

            List<Lek> lekovi = LekoviController.Instance.GetSveLekove();
            if (lekovi == null)
                lekovi = new List<Lek>();
            foreach (Lek l in lekovi)
                Lekovi.Items.Add(l);

        }



        private void onClickPotvrdi(object sender, RoutedEventArgs e)
        {
            String naziv = NazivLeka.Text;
            string doza = Doza.Text;
            int kolicina = Convert.ToInt32(KolicinaLeka.Text);
            int sifraSobe = Convert.ToInt32(SifraSobe.Text);
            string sastojci = Sastojci.Text;
            int sifraZamene = 0;

            Lek zamenaLeka = (Lek)Lekovi.SelectedItem;
            
            if(zamenaLeka != null)
                sifraZamene = zamenaLeka.Sifra;
            
            Lek lek = new Lek(naziv, doza, kolicina, sifraSobe, sifraZamene, sastojci);
            if (!LekoviController.Instance.DodajLek(lek))
                MessageBox.Show("Lek vec postoji!");
            
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
