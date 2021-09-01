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
    /// Interaction logic for PrikazOdabraneBeleske.xaml
    /// </summary>
    public partial class PrikazOdabraneBeleske : Window
    {
        public PrikazOdabraneBeleske(BeleskeDTO odabranaBeleska)
        {
            InitializeComponent();
            sadrzajBeleske.Text = odabranaBeleska.ListaBeleski.First().SadrzajBeleske;
            nazivBeleske.Content = odabranaBeleska.ListaBeleski.First().NazivBeleske;

        }

        private void onClickNazad(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
