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
    /// Interaction logic for PregledZdravstvenogKartonaPacijent.xaml
    /// </summary>
    public partial class PregledZdravstvenogKartonaPacijent : Window
    {
        PacijentDTO pacijentDTO;
        public PregledZdravstvenogKartonaPacijent(PacijentDTO pacijent)
        {
            pacijentDTO = new PacijentDTO();
            pacijentDTO.Pacijent = pacijent.Pacijent;
            pacijentDTO.ZdravstveniKarton = ZdravstveniKartoniController.Instance.GetOdgKarton(pacijent.Pacijent.Id);
            InitializeComponent();
            ucitajOsnovnePodatke();
            ucitajBolesti();
            ucitajAnamnezu();
        }

        public void ucitajOsnovnePodatke()
        {
            imePrezime.Text = pacijentDTO.Pacijent.Ime + " " + pacijentDTO.Pacijent.Prezime;
            JMBG.Text = pacijentDTO.Pacijent.Jmbg;
            datumRodjenja.Text = Convert.ToString(pacijentDTO.ZdravstveniKarton.DatumRodjenja.Date);
            mestoStanovanja.Text = pacijentDTO.ZdravstveniKarton.MestoStanovanja;
            pol.Text = pacijentDTO.ZdravstveniKarton.Pol == Pol.Muski ? "Muški" : "Ženski";
            switch(pacijentDTO.ZdravstveniKarton.BracniStatus)
            {
                case BracniStatus.NeozenjenNeudata:
                    bracniStatus.Text = "Neoženjen/Neudata";
                    break;
                case BracniStatus.OzenjenUdata:
                    bracniStatus.Text = "Oženjen/Udata";
                    break;
                case BracniStatus.RazvedenRazvedena:
                    bracniStatus.Text = "Razveden/Razvedena";
                    break;
                case BracniStatus.UdovacUdovica:
                    bracniStatus.Text = "Udovac/Udovica";
                    break;
            }
            ulicaIBroj.Text = pacijentDTO.ZdravstveniKarton.UlicaIbroj;
            telefon.Text = pacijentDTO.ZdravstveniKarton.Telefon;
        }
       
        public void ucitajBolesti()
        {
            foreach (Bolest bolest in pacijentDTO.Pacijent.ListaBolesti)
            {
                Bolesti.Items.Add(bolest);
            }
        }

        public void ucitajAnamnezu()
        {
            anamneza.Text = pacijentDTO.ZdravstveniKarton.Anamneza;
        }

        private void onClickNazad(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.pv.Show();
        }

        private void onClickPrikaziTerapiju(object sender, RoutedEventArgs e)
        {
            BolestDTO odabranaBolest = new BolestDTO(); 
            odabranaBolest.IzabranaBolest = (Bolest)Bolesti.SelectedItem;
            PrikazTerapijePacijent pt = new PrikazTerapijePacijent(odabranaBolest);
            pt.ShowDialog();
        }
    }
}
