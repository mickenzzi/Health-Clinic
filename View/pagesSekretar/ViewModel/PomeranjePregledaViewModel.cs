using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Controller;
using System.Collections.ObjectModel;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using Bolnica.View.pagesSekretar.Views;
using System;
using System.Windows;


namespace Bolnica.View.pagesSekretar.ViewModel 
{
    class PomeranjePregledaViewModel:BindableBase
    {
        private SekretarView parent;
        private string jmbg;
        private Lekar selectedLekar;
        private string datum;
        private int idTermina;
        public ObservableCollection<Lekar> Lekari { get; set; }
        public MyICommand PomeriPregledCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public PomeranjePregledaViewModel(SekretarView parent,string jmbg,int idTermina) 
        {
            this.parent = parent;
            this.jmbg = jmbg;
            this.idTermina = idTermina;
            LoadLekari();
            PomeriPregledCommand = new MyICommand(OnPomeri);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        public void LoadLekari()
        {
            List<Lekar> lek = new List<Lekar>();
            lek = LekariController.Instance.GetSviLekari();
            ObservableCollection<Lekar> lekari = new ObservableCollection<Lekar>(lek);
            Lekari = lekari;
        }
        public Lekar SelectedLekar
        {
            get { return selectedLekar; }
            set
            {
                selectedLekar = value;
                OnPropertyChanged("SelectedLekar");
                PomeriPregledCommand.RaiseCanExecuteChanged();
            }
        }
        public string Datum 
        {
            get { return datum; }
            set 
            { 
                datum = value;
                OnPropertyChanged("Datum");
            }
        }
        public int IdTermina 
        {
            get { return idTermina; }
            set 
            { 
                idTermina = value;
                OnPropertyChanged("IdTermina");
            }
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack()
        {
            parent._mainFrame.NavigationService.Navigate(new TerminProzor(parent, jmbg));
        }
        private void OnPomeri() 
        {
            bool provera1 = false;
            bool provera2 = false;
            DateTime dt;
            if (string.IsNullOrWhiteSpace(Datum))
            {
                MessageBox.Show("Niste izabrali datum");
                provera1 = false;
            }
            else
            {
                if (DateTime.TryParse(Datum, out dt))
                {
                    provera1 = true;
                }
                else
                {
                    MessageBox.Show("Niste uneli datum u odgovarajucem formatu.");
                    provera1 = false;
                }
            }

            if (SelectedLekar == null)
            {
                provera2 = false;
                MessageBox.Show("Niste izabrali lekara.");
            }
            else
            {
                provera2 = true;
            }

            if (provera1 == true && provera2 == true)
            {
                DateTime datumNovi = DateTime.Parse(Datum);
                DateTime datumStari;
                Termin t = TerminiController.Instance.GetTermin(idTermina);
                datumStari = t.DatumVreme;
                TimeSpan razlika = datumNovi.Subtract(datumStari);

                if (razlika.Days < 1)

                {
                    TerminProzor tp = new TerminProzor(parent, jmbg);
                    MessageBox.Show("Nije moguce pomerati termin unutar istog dana.");
                    parent._mainFrame.NavigationService.Navigate(tp);
                }
                else
                {
                    bool zauzetTermin = TerminiController.Instance.GetOdgTermin(datumNovi, SelectedLekar.Id);

                    if (zauzetTermin == true)
                    {
                        TerminProzor tp = new TerminProzor(parent, jmbg);
                        MessageBox.Show("Zeljeni termin je zauzet.Izaberite neki drugi termin.");
                        parent._mainFrame.NavigationService.Navigate(tp);
                    }
                    else
                    {
                        Pacijent pacijent = PacijentiController.Instance.GetOdgPacijent(jmbg);
                        string poruka;
                        poruka = "Pomerili ste pregled kod " + SelectedLekar.Ime + " " + SelectedLekar.Prezime + " za " + datumNovi.ToString() + ".";
                        Obavestenje o = new Obavestenje(poruka, pacijent.Id);
                        ObavestenjaController.Instance.AddObavestenje(o);
                        t.Lekar = SelectedLekar;
                        t.DatumVreme = datumNovi;
                        t.Pomeren = true;
                        TerminiController.Instance.SetTermin(t);
                        TerminProzor tp = new TerminProzor(parent, jmbg);
                        MessageBox.Show("Uspesno ste pomerili pregled.");
                        parent._mainFrame.NavigationService.Navigate(tp);
                    }
                }
            }
        }
    }
}
