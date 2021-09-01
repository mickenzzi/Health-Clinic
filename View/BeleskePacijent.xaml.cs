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
    /// Interaction logic for BeleskePacijent.xaml
    /// </summary>
    public partial class BeleskePacijent : Window
    {
        private PacijentDTO pacijentDTO;
        public BeleskePacijent(PacijentDTO pacijentDTO)
        {
       
            InitializeComponent();
            this.pacijentDTO = new PacijentDTO();
            this.pacijentDTO = pacijentDTO;
            BeleskeDTO sveBeleske = new BeleskeDTO();
            sveBeleske.ListaBeleski = BeleskePacijentController.Instance.GetSveBeleske();
            ucitajBeleske(sveBeleske);
            
        }
        public void ucitajBeleske(BeleskeDTO sveBeleske) 
        {
            Beleske.Items.Clear();
            for (int i = 0; i < sveBeleske.ListaBeleski.Count; i++)
            {
                foreach (int sifraBeleske in pacijentDTO.Pacijent.ListaSifriBeleski)
                {
                    if (sifraBeleske == sveBeleske.ListaBeleski.ElementAt(i).SifraBeleske)
                    {
                        Beleske.Items.Add(sveBeleske.ListaBeleski.ElementAt(i));
                    }
                }
            }
        }
        private void onClickNazad(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void onClickPrikazOdabraneBeleske(object sender, RoutedEventArgs e)
        {
            BeleskeDTO odabranaBeleska = new BeleskeDTO();
            odabranaBeleska.ListaBeleski.Add((Model.Beleska)Beleske.SelectedItem);
            PrikazOdabraneBeleske pob = new PrikazOdabraneBeleske(odabranaBeleska);
            pob.ShowDialog();
        }

        private void onClickNapraviBelesku(object sender, RoutedEventArgs e)
        {
            KreiranjeBeleske kb = new KreiranjeBeleske(pacijentDTO);
            kb.ShowDialog();
            BeleskeDTO sveBeleske = new BeleskeDTO();
            sveBeleske.ListaBeleski = BeleskePacijentController.Instance.GetSveBeleske();
            ucitajBeleske(sveBeleske);
        }

        private void onClickObrisiBelesku(object sender, RoutedEventArgs e)
        {
            BeleskeDTO odabranaBeleska = new BeleskeDTO();
            odabranaBeleska.ListaBeleski.Add((Model.Beleska)Beleske.SelectedItem);
            if (BeleskePacijentController.Instance.obrisiBelesku(odabranaBeleska.ListaBeleski.First().SifraBeleske))
            {
                MessageBox.Show("Uspešno ste obrisali belešku!");
                BeleskeDTO sveBeleske = new BeleskeDTO();
                sveBeleske.ListaBeleski = BeleskePacijentController.Instance.GetSveBeleske();
                ucitajBeleske(sveBeleske);
                return;
            }
            MessageBox.Show("Greška pri brisanju odabrane beleške!");

        }

    }
}
