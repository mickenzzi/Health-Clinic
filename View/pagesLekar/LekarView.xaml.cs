using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Windows.Threading;
using System.Xml.Serialization;
using Bolnica.Controller;
using Bolnica.View.pagesLekar;
using Bolnica.View.pagesLekar.ViewModel;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for LekarView.xaml
    /// </summary>
    public partial class LekarView : Window
    {
        private string _currentTime;
        public LekarView()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Owner = Application.Current.MainWindow;
            this.DataContext = new LekarViewModel(this);
            UpdateTime();
        }

        // StatusBar Clock

        private async void UpdateTime()
        {
            CurrentTime = DateTime.Now.ToString("HH:mm   |   dd/MM/yyyy   ");
            Vreme.Text = CurrentTime;
            await Task.Delay(1000);
            UpdateTime();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string CurrentTime
        {
            get { return _currentTime; }
            set { _currentTime = value; OnPropertyChanged(); }
        }

        //

        public void exitApp(object sender, CancelEventArgs e)
        {
            MainWindow.Instance.Show();
        }

        private void Odjava_click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mv = new MainWindow();
            mv.Show();
        }

        private void Pocetna_click(object sender, RoutedEventArgs e)
        {
            frejm.Content = null;
        }
    }
}
