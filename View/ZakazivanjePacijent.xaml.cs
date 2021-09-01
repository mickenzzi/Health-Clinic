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
    /// Interaction logic for ZakazivanjePacijent.xaml
    /// </summary>
    public partial class ZakazivanjePacijent : Window
    {
        PacijentDTO pacijent;
        public ZakazivanjePacijent(PacijentDTO pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;

            for(int i = 0; i < pacijent.ListaTermina.Count; i++)
            {
                SlobodniTermini.Items.Add(pacijent.ListaTermina.ElementAt(i));
            }

        }

        private void onClickZakazi(object sender, RoutedEventArgs e)
        {

            TerminDTO izabraniTermin = new TerminDTO();
            izabraniTermin.Termin = (Termin)SlobodniTermini.SelectedItem;
            IspisiDTO ispisi;
            ispisi = PacijentiController.Instance.ZakaziPregled(pacijent.Pacijent, izabraniTermin.Termin);
        
            IspisivanjePoruka(ispisi);
            this.Close();
            MainWindow.pv.Show();
        }
        public void IspisivanjePoruka(IspisiDTO poruka)
        {
            if (poruka.Status1 == true && poruka.Status2 == false)
            {
                MessageBox.Show("Maksimalan broj zakazanih pregleda je 3!");
            }
            else if (poruka.Status1 == false && poruka.Status2 == true)
            {
                MessageBox.Show("Maksimalan broj zakazivanja termina u danu je 4!");
            }
            else if (poruka.Status1 == true && poruka.Status2 == true)
            {
                MessageBox.Show("Maksimalan broj zakazanih pregleda je 3 i Maksimalan broj zakazivanja termina u danu je 4!");
            }
            else
            {
                MessageBox.Show("Uspešno ste zakazali pregled!");
            }
        }

        private void onClickOdustani(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.pv.Show();
        }
    }
}
