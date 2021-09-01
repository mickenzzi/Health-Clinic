using System;
using Bolnica.View.pagesSekretar.Views;
using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using System.Windows;
using System.Linq;

namespace Bolnica.View.pagesSekretar.ViewModel
{
    public class IzmenaLekaraViewModel : BindableBase
    {
        private SekretarView parent;
        private Lekar lekar;
        private int idLekara;
        public MyICommand IzmenaLekaraCommand { get; set; }
        public MyICommand BackCommand { get; set; }
        public MyICommand HomeCommand { get; set; }
        public IzmenaLekaraViewModel(SekretarView parent, int idLekara)
        {
            this.parent = parent;
            this.idLekara = idLekara;
            LoadLekar();
            IzmenaLekaraCommand = new MyICommand(OnIzmeni);
            BackCommand = new MyICommand(OnBack);
            HomeCommand = new MyICommand(OnHome);
        }
        private string imeLekara;
        private string prezimeLekara;
        private string jmbgLekara;
        private string datumRodjenjaLekara;
        private string mestoRodjenjaLekara;
        private string datumPocetkaOdmora;
        private string datumKrajaOdmora;
        private string pocetakRadnogVremena;
        private bool checkBoxPrikaz;
        private string krajRadnogVremena;
        private bool specijalista;
        private string oblastSpecijalizacije;
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
        public string DatumRodjenja
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
        public string MestoRodjenja
        {
            get { return mestoRodjenjaLekara; }
            set
            {
                if (mestoRodjenjaLekara != value)
                {
                    mestoRodjenjaLekara = value;
                    OnPropertyChanged("MestoRodjenja");
                }
            }
        }
        public string DatumPocetkaOdmora
        {
            get { return datumPocetkaOdmora; }
            set
            {
                if (datumPocetkaOdmora != value)
                {
                    datumPocetkaOdmora = value;
                    OnPropertyChanged("DatumPocetkaOdmora");
                }
            }
        }
        public string DatumKrajaOdmora
        {
            get { return datumKrajaOdmora; }
            set
            {
                if (datumKrajaOdmora != value)
                {
                    datumKrajaOdmora = value;
                    OnPropertyChanged("DatumKrajaOdmora");
                }
            }
        }
        public string PocetakRadnogVremena
        {
            get { return pocetakRadnogVremena; }
            set
            {
                if (pocetakRadnogVremena != value)
                {
                    pocetakRadnogVremena = value;
                    OnPropertyChanged("PocetakRadnogVremena");
                }
            }
        }
        public string KrajRadnogVremena
        {
            get { return krajRadnogVremena; }
            set
            {
                if (krajRadnogVremena != value)
                {
                    krajRadnogVremena = value;
                    OnPropertyChanged("KrajRadnogVremena");
                }
            }
        }
        public string IzborSpecijalizacije
        {
            get { return oblastSpecijalizacije; }
            set
            {
                oblastSpecijalizacije = value;
                OnPropertyChanged("IzborSpecijalizacije");
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
        public bool CheckBoxPrikaz
        {
            get { return checkBoxPrikaz; }
            set
            {
                checkBoxPrikaz = value;
                OnPropertyChanged("CheckBoxPrikaz");
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
        public void LoadLekar()
        {
            lekar = LekariController.Instance.GetOdgLekar(idLekara);
            ImeLekara = lekar.Ime;
            PrezimeLekara = lekar.Prezime;
            JmbgLekara = lekar.Jmbg;
            DatumRodjenja = lekar.DatumRodjenja.ToString();
            MestoRodjenja = lekar.MestoRodjenja;
            DatumPocetkaOdmora = lekar.DatumPocetkaOdmora.ToString();
            DatumKrajaOdmora = lekar.DatumKrajaOdmora.ToString();
            PocetakRadnogVremena = lekar.PocetakRadnogVremena.ToString();
            KrajRadnogVremena = lekar.KrajRadnogVremena.ToString();
            Specijalista = lekar.Specijalista;
            string specijalizacija;
            if (Specijalista == true)
            {
                CheckBoxPrikaz = true;
                IzborSpecijalizacije = lekar.Specijalizacija;
            }
            else
            {
                CheckBoxPrikaz = false;
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
        private void OnIzmeni()
        {
            DateTime dt;
            bool provera1 = false;
            bool provera2 = false;
            bool provera3 = false;
            bool provera4 = false;
            bool provera5 = false;
            bool provera6 = false;
            bool provera7 = false;
            bool provera8 = false;
            string specijalizacija;
            if (!string.IsNullOrWhiteSpace(ImeLekara))
            {
                if (ImeLekara.Any(c => c < 'A' || c > 'z'))
                {
                    if (ImeLekara.Any(c => c == '-'))
                    {
                        provera6 = true;
                        lekar.Ime = ImeLekara;
                    }
                    else
                    {
                        provera6 = false;
                        MessageBox.Show("Ime lekara mora sadrzati samo slova.");
                    }
                }
                else if(!Char.IsUpper(ImeLekara, 0))
                {
                    provera6 = false;
                    MessageBox.Show("Ime mora pocinjati velikim slovom.");
                }
                else 
                {
                    provera6 = true;
                    lekar.Ime = ImeLekara;
                }
            }
            else
            {
                provera6 = false;
                lekar.Ime = ImeLekara;
            }

            if (!string.IsNullOrWhiteSpace(PrezimeLekara))
            {
                if (PrezimeLekara.Any(c => c < 'A' || c > 'z'))
                {
                    if(PrezimeLekara.Any(c => c == '-')) 
                    {
                        provera7 = true;
                        lekar.Prezime = PrezimeLekara;
                    }
                    else 
                    {
                        provera7 = false;
                        MessageBox.Show("Prezime lekara mora sadrzati samo slova.");
                    }
                }
                else if (!Char.IsUpper(PrezimeLekara, 0))
                {
                    provera7 = false;
                    MessageBox.Show("Prezime mora pocinjati velikim slovom.");
                }
                else
                {
                    provera7 = true;
                    lekar.Prezime = PrezimeLekara;
                }
            }
            else
            {
                provera7 = false;
                lekar.Prezime = PrezimeLekara;
            }

            if (!string.IsNullOrWhiteSpace(MestoRodjenja))
            {
                if (MestoRodjenja.Any(c => c < 'A' || c > 'z'))
                {
                    if (MestoRodjenja.Any(c => c==' '))
                    {
                        provera8 = true;
                        lekar.MestoRodjenja = MestoRodjenja;
                    }
                    else 
                    {
                        provera8 = false;
                        MessageBox.Show("Mesto rodjenja lekara mora sadrzati samo slova.");
                    }
                }
                else
                {
                    provera8 = true;
                    lekar.MestoRodjenja = MestoRodjenja;
                }
            }
            else
            {
                lekar.MestoRodjenja = MestoRodjenja;
            }
            if (!string.IsNullOrWhiteSpace(JmbgLekara))
            {
                if (JmbgLekara.Any(c => c < '0' || c > '9'))
                {
                    MessageBox.Show("Jmbg mora sadrzati samo brojeve.");
                }
                else 
                {
                    lekar.Jmbg = JmbgLekara;
                }
            }
            else
            {
                lekar.Jmbg = JmbgLekara;
            }

            if (string.IsNullOrWhiteSpace(DatumRodjenja))
            {
                provera1 = false;
                MessageBox.Show("Unesite datum rodjenja lekara.");
            }
            else
            {
                if (DateTime.TryParse(DatumRodjenja, out dt))
                {
                    provera1 = true;
                    lekar.DatumRodjenja = DateTime.Parse(DatumRodjenja);
                }
                else
                {
                    provera1 = false;
                    MessageBox.Show("Niste uneli datum u odgovarajucem formatu.");
                }
            }
            if (string.IsNullOrWhiteSpace(DatumPocetkaOdmora))
            {
                provera2 = false;
                MessageBox.Show("Unesite datum pocetka odmora lekara.");
            }
            else
            {
                if (DateTime.TryParse(DatumPocetkaOdmora, out dt))
                {
                    provera2 = true;
                    lekar.DatumPocetkaOdmora = DateTime.Parse(DatumPocetkaOdmora);
                }
                else
                {
                    provera2 = false;
                    MessageBox.Show("Niste uneli datum u odgovarajucem formatu.");
                }
            }
            if (string.IsNullOrWhiteSpace(DatumKrajaOdmora))
            {
                provera3 = false;
                MessageBox.Show("Unesite datum kraja odmora lekara.");
            }
            else
            {
                if (DateTime.TryParse(DatumKrajaOdmora, out dt))
                {
                    provera3 = true;
                    lekar.DatumKrajaOdmora = DateTime.Parse(DatumKrajaOdmora);
                }
                else
                {
                    provera3 = false;
                    MessageBox.Show("Niste uneli datum u odgovarajucem formatu.");
                }
            }

            if (string.IsNullOrWhiteSpace(PocetakRadnogVremena))
            {
                provera4 = false;
                MessageBox.Show("Niste uneli pocetak radnog vremena lekara.");
            }
            else
            {
                if (DateTime.TryParse(PocetakRadnogVremena, out dt))
                {
                    provera4 = true;
                    lekar.PocetakRadnogVremena = DateTime.Parse(PocetakRadnogVremena);
                }
                else
                {
                    provera4 = false;
                    MessageBox.Show("Niste uneli datum u odgovarajucem formatu.");
                }
            }

            if (string.IsNullOrWhiteSpace(KrajRadnogVremena))
            {
                provera5 = false;
                MessageBox.Show("Niste uneli kraj radnog vremena lekara.");
            }
            else
            {
                if (DateTime.TryParse(KrajRadnogVremena, out dt))
                {
                    provera5 = true;
                    lekar.KrajRadnogVremena = DateTime.Parse(KrajRadnogVremena);
                }
                else
                {
                    provera5 = false;
                    MessageBox.Show("Niste uneli datum u odgovarajucem formatu.");
                }
            }
            if (CheckBoxPrikaz == true)
            {
                Specijalista = true;
                lekar.Specijalista = Specijalista;
                lekar.Specijalizacija = IzborSpecijalizacije;
            }
            else
            {
                Specijalista = false;
                lekar.Specijalista = Specijalista;
                specijalizacija = null;
                lekar.Specijalizacija = specijalizacija;
            }
            lekar.Validate();
            if (lekar.IsValid && provera1==true && provera2==true && provera3==true && provera4==true && provera5==true && provera6==true && provera7==true && provera8==true)
            {
                {
                    LekariController.Instance.SetLekar(lekar);
                    PrikazLekara pl = new PrikazLekara(parent);
                    MessageBox.Show("Uspesno ste izmenili podatke lekara.");
                    parent._mainFrame.NavigationService.Navigate(pl);
                }
            }
        }
    }
}
