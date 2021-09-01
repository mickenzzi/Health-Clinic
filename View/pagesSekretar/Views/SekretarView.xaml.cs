using System.Windows;
using System.Windows.Input;
using Bolnica.Model;
using System.ComponentModel;
using System;
using Bolnica.Model;
using Bolnica.Controller;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections.Generic;

namespace Bolnica.View.pagesSekretar.Views
{
    public partial class SekretarView : Window
    {
        public SekretarView()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Owner = Application.Current.MainWindow;
            MainWindow.s = new Sekretar(); 
        }
        private void Registrovanje(object sender, RoutedEventArgs e)
        {
            
            _mainFrame.NavigationService.Navigate(new PacijentProzor(this));
        }
        private void TerminiRad(object sender, RoutedEventArgs e)
        {
         
            _mainFrame.NavigationService.Navigate(new PredZakazivanje(this));
        }
        private void KreirajStatistiku(object sender, RoutedEventArgs e)
        {
            StatistikaView stv = new StatistikaView();
            stv.Show();
            this.Hide();
        }
        private void Povratak(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mv = new MainWindow();
            mv.Show();
        }
       private void exitApp(object sender, CancelEventArgs e)
        {
            MainWindow.Instance.Show();
        }
        private void PrikaziMenu(object sender, MouseButtonEventArgs e)
        {
            Menu.Visibility = Visibility.Visible;
        }
        private void SkloniMenu(object sender, MouseButtonEventArgs e)
        {
            Menu.Visibility = Visibility.Collapsed;
        }
        private void PrikaziProfil(object sender, RoutedEventArgs e)
        {
            Profil1.Visibility = Visibility.Visible;
            Menu.Visibility = Visibility.Collapsed;
        }
        private void Odjava(object sender, RoutedEventArgs e)
        {
            MainWindow mv = new MainWindow();
            this.Hide();
            mv.Show();
        }
        private void Nastavi(object sender, MouseButtonEventArgs e)
        {
            Profil1.Visibility = Visibility.Collapsed;
        }
        private void goToObavestenja(object sender, RoutedEventArgs e)
        {
          
            Menu.Visibility = Visibility.Collapsed;
            _mainFrame.NavigationService.Navigate(new KlinikaObavestenja(this));
        }
        private void goToProfil(object sender, RoutedEventArgs e)
        {


            Menu.Visibility = Visibility.Collapsed;
            Menu.Visibility = Visibility.Collapsed;
            _mainFrame.NavigationService.Navigate(new ProfilKorisnika(this));
        }
        private void Lekari(object sender, RoutedEventArgs e)
        {
        
            _mainFrame.NavigationService.Navigate(new LekarProzor(this));
        }

        private void GoToInfo(object sender, RoutedEventArgs e)
        {

            _mainFrame.NavigationService.Navigate(new Klinika(this));
        }

        private void GoToKontakt(object sender, RoutedEventArgs e)
        {
         
            _mainFrame.NavigationService.Navigate(new Kontakt(this));
        }

        private void GoToBugs(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new DodavanjeBugova(this));
        }

        private void GenerisanjeIzvestaja(object sender, RoutedEventArgs e)
        {
            var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
            string path = @"c:\Users\Nikola\Desktop\BolnicaDobro\Reports\IzvestajSoba.pdf";
            PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
            pdfDoc.Open();

            var spacer = new Paragraph("")
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f,
            };

            pdfDoc.Add(spacer);

            var DocumentDescription = new PdfPTable(new[] { .75f, 1f }) { };
            DocumentDescription.AddCell("Datum: ");
            DocumentDescription.AddCell(DateTime.Now.ToString("dd.MM.yyyy"));
            DocumentDescription.AddCell("Vreme: ");
            DocumentDescription.AddCell(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
            DocumentDescription.AddCell("Opis dokumenta: ");
            DocumentDescription.AddCell("Izveštaj o zakazanim terminima u prostoriji");

            pdfDoc.Add(DocumentDescription);
            pdfDoc.Add(spacer);
            pdfDoc.Add(spacer);

            var columnWidth = new[] { 0.75f, 1.0f, 1.0f};


            List<Soba> sobe = SobeController.Instance.GetZauzeteSobe();

            if (sobe.Count != 0)
            {
                var pdfTableSobe = new PdfPTable(columnWidth) { };
                var zaglavlje = new PdfPCell(new Phrase("Zauzetost sobe"))
                {
                    Colspan = 4,
                    HorizontalAlignment = 1,
                    MinimumHeight = 3
                };

                pdfTableSobe.AddCell(zaglavlje);

                pdfTableSobe.AddCell("Sifra sobe");
                pdfTableSobe.AddCell("Tip sobe");
                pdfTableSobe.AddCell("Datum zauzeca");

                foreach (Soba s in sobe)
                {

                    pdfTableSobe.AddCell(s.Sifra.ToString());
                    pdfTableSobe.AddCell(s.Tip.ToString());
                    pdfTableSobe.AddCell(TerminiController.Instance.GetDatumTermina(s.Sifra).ToString());
                }

                pdfDoc.Add(pdfTableSobe);
            }
            else
            {
                var nemaTermina = new Paragraph("Nema zauzetih prostorija")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };

                pdfDoc.Add(nemaTermina);
            }
            pdfDoc.Add(spacer);
            pdfDoc.Add(spacer);
            pdfDoc.Close();
            MessageBox.Show("PDF fajl je uspešno izgenerisan!");
        }

  
    }
}
