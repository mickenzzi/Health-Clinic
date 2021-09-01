using Bolnica.Controller;
using Bolnica.DTO;
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
    /// Interaction logic for KreiranjeBeleske.xaml
    /// </summary>
    public partial class KreiranjeBeleske : Window
    {
        PacijentDTO pacijentDTO;
        public KreiranjeBeleske(PacijentDTO pacijentDTO)
        {
            InitializeComponent();
            this.pacijentDTO = pacijentDTO;
        }

        private void onClickNazad(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void onClickPotvrdi(object sender, RoutedEventArgs e)
        {
            string nazivBeleske = imeBeleske.Text;
            string sadrzajBeleske = sadrzaj.Text;

            BeleskePacijentController.Instance.dodajBelesku(nazivBeleske, sadrzajBeleske, pacijentDTO);

            this.Close();
        }
    }
}
