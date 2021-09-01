using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using System;
using Bolnica.View.pagesSekretar.Views;
using System.Windows;
using System.Linq;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class DodavanjeLekaraViewModel : BindableBase
    {
        private SekretarView parent;
        public MyICommand AddLekarCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        private Lekar lekar = new Lekar();
        public DodavanjeLekaraViewModel(SekretarView parent)
        {
            this.parent = parent;
            AddLekarCommand = new MyICommand(OnAdd);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        private string imeLekara;
        private string prezimeLekara;
        private string jmbgLekara;
        private string oblastSpecijalizacijeLekara;
        private bool specijalista;
        private string mestoRodjenjaLekara;
        private string datumRodjenjaLekara;
        private bool checkBoxPrikaz;
        public string ImeLekara
        {
            get { return imeLekara; }
            set
            {
                if (imeLekara != value)
                {
                    imeLekara = value;
                    OnPropertyChanged("ImeLekara");
                }
            }
        }
        public string PrezimeLekara
        {
            get { return prezimeLekara; }
            set
            {
                if (prezimeLekara != value)
                {
                    prezimeLekara = value;
                    OnPropertyChanged("PrezimeLekara");
                }
            }
        }
        public string JmbgLekara
        {
            get { return jmbgLekara; }
            set
            {
                if (jmbgLekara != value)
                {
                    jmbgLekara = value;
                    OnPropertyChanged("JmbgLekara");
                }
            }
        }
        public string IzborSpecijalizacije
        {
            get { return oblastSpecijalizacijeLekara; }
            set
            {
                oblastSpecijalizacijeLekara = value;
                OnPropertyChanged("IzborSpecijalizacije");
            }
        }
        public string DatumRodjenjaLekara
        {
            get { return datumRodjenjaLekara; }
            set
            {
                if (datumRodjenjaLekara != value)
                {
                    datumRodjenjaLekara = value;
                    OnPropertyChanged("DatumRodjenja");
                }
            }
        }
        public string MestoRodjenjaLekara
        {
            get { return mestoRodjenjaLekara; }
            set
            {
                if (mestoRodjenjaLekara != value)
                {
                    mestoRodjenjaLekara = value;
                    OnPropertyChanged("MestoRodjenjaLekara");
                }
            }
        }
        public bool CheckBoxPrikaz
        {
            get { return checkBoxPrikaz; }
            set
            {
                checkBoxPrikaz = value;
                OnPropertyChanged("CheckBoxPrikaz");
            }
        }
        public bool Specijalista
        {
            get { return specijalista; }
            set
            {
                specijalista = value;
                OnPropertyChanged("Specijalista");
            }
        }
        public Lekar CurrentLekar
        {
            get { return lekar; }
            set
            {
                lekar = value;
                OnPropertyChanged("CurrentLekar");
            }
        }
        private void OnHome()
        {
            parent._mainFrame.NavigationService.Navigate(null);
        }
        private void OnBack() 
        {
            parent._mainFrame.NavigationService.Navigate(new LekarProzor(parent));
        }
        private void OnAdd()
        {
            bool provera1 = false;
            bool provera2 = false;
            bool provera3 = false;
            bool provera4 = false;
            bool provera5 = false;
            DateTime dt;
            string specijalizacija;
            if (CheckBoxPrikaz == false)
            {
                Specijalista = false;
                specijalizacija = null;
            }
            else
            {
                Specijalista = true;
                specijalizacija = IzborSpecijalizacije;
            }
            if (!string.IsNullOrWhiteSpace(ImeLekara))
            {
                if (ImeLekara.Any(c => c < 'A' || c > 'z'))
                {
                    if (ImeLekara.Any(c => c == '-'))
                    {
                        CurrentLekar.Ime = ImeLekara;
                        provera2 = true;
                    }
                    else 
                    {
                        MessageBox.Show("U imenu lekara moraju biti samo slova");
                        provera2 = false;
                    }
                }
                else if (!Char.IsUpper(ImeLekara, 0))
                {
                    MessageBox.Show("Ime mora pocinjati velikim slovom.");
                    provera2 = false;
                }
                else
                {
                    CurrentLekar.Ime = ImeLekara;
                    provera2 = true;
                }
            }
            else
            {
                CurrentLekar.Ime = ImeLekara;
                provera2 = true;
            }

            if (!string.IsNullOrWhiteSpace(PrezimeLekara))
            {
                if (PrezimeLekara.Any(c => c < 'A' || c > 'z'))
                {
                    if (PrezimeLekara.Any(c => c == '-'))
                    {
                        CurrentLekar.Prezime = PrezimeLekara;
                        provera3 = true;
                    }
                    else 
                    {
                        MessageBox.Show("U prezimenu lekara moraju biti samo slova");
                        provera3 = false;
                    }
                }
                else if (!Char.IsUpper(PrezimeLekara, 0))
                {
                    MessageBox.Show("Prezime mora pocinjati velikim slovom.");
                    provera3 = false;
                }
                else
                {
                    CurrentLekar.Prezime = PrezimeLekara;
                    provera3 = true;
                }
            }
            else
            {
                CurrentLekar.Prezime = PrezimeLekara;
                provera3 = true;
            }
            if (!string.IsNullOrWhiteSpace(JmbgLekara))
            {
                if (JmbgLekara.Any(c => c < '0' || c > '9'))
                {
                    MessageBox.Show("Jmbg mora sadrzati samo brojeve.");
                    provera5 = false;
                }
                else
                {
                    CurrentLekar.Jmbg = JmbgLekara;
                    provera5 = true;
                }
            }
            if (!string.IsNullOrWhiteSpace(MestoRodjenjaLekara))
            {
                if (MestoRodjenjaLekara.Any(c => c < 'A' || c > 'z'))
                {
                    if (MestoRodjenjaLekara.Any(c => c == ' '))
                    {
                        CurrentLekar.MestoRodjenja = MestoRodjenjaLekara;
                        provera4 = true;
                    }
                    else
                    {
                        MessageBox.Show("Mesto rodjenja lekara mora sadrzati samo slova");
                        provera4 = false;
                    }
                }
                else
                {
                    CurrentLekar.MestoRodjenja = MestoRodjenjaLekara;
                    provera4 = true;
                }
            }
            else
            {
                CurrentLekar.MestoRodjenja = MestoRodjenjaLekara;
                provera4 = true;
            }
            if (DatumRodjenjaLekara == null || DatumRodjenjaLekara == "")
            {
                CurrentLekar.DatumRodjenja = default;
            }
            else
            {
                if (DateTime.TryParse(DatumRodjenjaLekara, out dt))
                {
                    provera1 = true;
                    CurrentLekar.DatumRodjenja = DateTime.Parse(DatumRodjenjaLekara);
                }
                else
                {
                    provera1 = false;
                    MessageBox.Show("Niste uneli datum u odgovarajucem formatu.");
                }
            }
            CurrentLekar.Validate();
            if (CurrentLekar.IsValid && provera1 == true && provera2==true && provera3==true && provera4==true && provera5==true)
            {
                CurrentLekar.Specijalista = Specijalista;
                CurrentLekar.Specijalizacija = specijalizacija;
                LekariController.Instance.AddLekar(CurrentLekar);
                LekarProzor ko = new LekarProzor(parent);
                MessageBox.Show("Uspesno ste dodali lekara.");
                parent._mainFrame.NavigationService.Navigate(ko);
            }
        }
    }
}
