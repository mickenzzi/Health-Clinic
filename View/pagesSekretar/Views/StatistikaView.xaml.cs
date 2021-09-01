using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls.DataVisualization.Charting;
using Bolnica.Model;
using Bolnica.Controller;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class StatistikaView : Window
    {
      
        public StatistikaView()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Owner = Application.Current.MainWindow;
            LoadPieChartData();
        }
        private void LoadPieChartData()
        {
            int brojObicnih = 0;
            int brojHitnih = 0;
            List<Pacijent> pacijenti = new List<Pacijent>();
            pacijenti = PacijentiController.Instance.GetSvePacijente();
            foreach(Pacijent p in pacijenti) 
            {
                if (p.HitanSlucaj == true) 
                {
                    brojHitnih++;
                }
                else 
                {
                    brojObicnih++;
                }
            }
            ((PieSeries)mcChart.Series[0]).ItemsSource =
                new KeyValuePair<string, int>[]{
            new KeyValuePair<string, int>("Obican slucaj",brojObicnih),
            new KeyValuePair<string, int>("Hitan slucaj", brojHitnih) };
        }

        private void Nazad(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow.sv.Show();
        }
    }
}
