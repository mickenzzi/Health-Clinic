using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.View.pagesSekretar.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.View.pagesLekar.ViewModel
{
    public class PageKartonPacijentaViewModel : BindableBase
    {
        private Termin termin;
        private int idTermina;
        private LekarView parent;
        private Lekar lekar;
        private Pacijent pacijent;
        private ZdravstveniKarton zdravstveniKarton;
        private string jmbgPacijenta;
        private string imePacijenta;
        private string prezimePacijenta;
        private string telefonPacijenta;
        private string datumRodjenjaPacijenta;
        private string mestoStanovanjaPacijenta;
        private string ulicaPacijenta;
        private bool hitanSlucaj;
        private string bracniStatusPacijentaIndex;
        private string polPacijentaIndex;
        private Pol polPacijenta;
        private BracniStatus bracniStatusPacijenta;
        private bool hitanSlucajCheck;
        public ObservableCollection<Alergija> Alergije { get; set; }
        public MyICommand ZatvoriKartonCommand { get; set; }

        public PageKartonPacijentaViewModel(LekarView parent, int idTermina)
        {
            this.parent = parent;
            this.idTermina = idTermina;
            LoadKarton();
            ZatvoriKartonCommand = new MyICommand(OnZatvori);
        }

        public string ImePacijenta
        {
            get { return imePacijenta; }
            set
            {
                imePacijenta = value;
                OnPropertyChanged("ImePacijenta");
            }
        }

        public string PrezimePacijenta
        {
            get { return prezimePacijenta; }
            set
            {
                prezimePacijenta = value;
                OnPropertyChanged("PrezimePacijenta");
            }
        }

        public string JmbgPacijenta
        {
            get { return jmbgPacijenta; }
            set
            {
                jmbgPacijenta = value;
                OnPropertyChanged("JmbgPacijenta");
            }
        }

        public string TelefonPacijenta
        {
            get { return telefonPacijenta; }
            set
            {
                telefonPacijenta = value;
                OnPropertyChanged("TelefonPacijenta");
            }
        }


        public string DatumRodjenjaPacijenta
        {
            get { return datumRodjenjaPacijenta; }
            set
            {
                datumRodjenjaPacijenta = value;
                OnPropertyChanged("DatumRodjenjaPacijenta");
            }
        }

        public string MestoStanovanjaPacijenta
        {
            get { return mestoStanovanjaPacijenta; }
            set
            {
                mestoStanovanjaPacijenta = value;
                OnPropertyChanged("MestoStanovanjaPacijenta");
            }
        }

        public string UlicaPacijenta
        {
            get { return ulicaPacijenta; }
            set
            {
                ulicaPacijenta = value;
                OnPropertyChanged("UlicaPacijenta");
            }
        }

        public bool HitanSlucaj
        {
            get { return hitanSlucaj; }
            set
            {
                hitanSlucaj = value;
                OnPropertyChanged("HitanSlucaj");
            }
        }

        public bool HitanSlucajCheck
        {
            get { return hitanSlucajCheck; }
            set
            {
                hitanSlucajCheck = value;
                OnPropertyChanged("HitanSlucajCheck");
            }
        }

        public string PolPacijenta
        {
            get { return polPacijentaIndex; }
            set
            {
                polPacijentaIndex = value;
                OnPropertyChanged("PolPacijenta");
            }
        }

        public string BracniStatusPacijenta
        {
            get { return bracniStatusPacijentaIndex; }
            set
            {
                bracniStatusPacijentaIndex = value;
                OnPropertyChanged("BracniStatusPacijenta");
            }
        }

        public Pol PolPacijentaP
        {
            get { return polPacijenta; }
            set
            {
                polPacijenta = value;
                OnPropertyChanged("PolPacijentaP");
            }
        }

        public BracniStatus BracniStatusPacijentaP
        {
            get { return bracniStatusPacijenta; }
            set
            {
                bracniStatusPacijenta = value;
                OnPropertyChanged("BracniStatusPacijentaP");
            }
        }


        public void LoadAlergije(int idk)
        {
            List<Alergija> aler = new List<Alergija>();
            aler = AlergijaController.Instance.GetSveAlergije(idk);
            ObservableCollection<Alergija> alergije = new ObservableCollection<Alergija>(aler);
            Alergije = alergije;
        }

        private void OnZatvori()
        {
            parent.frejm.Content = new PagePrikazTermina(parent, lekar.Jmbg);
        }

        public void LoadKarton()
        {
            termin = TerminiController.Instance.GetTermin(idTermina);
            pacijent = PacijentiController.Instance.GetOdgPacijent(termin.JmbgPacijenta);
            lekar = LekariController.Instance.GetOdgLekarByJmbg(termin.JmbgLekara);
            zdravstveniKarton = ZdravstveniKartoniController.Instance.GetOdgKarton(pacijent.Id);
            
            ImePacijenta = pacijent.Ime;
            PrezimePacijenta = pacijent.Prezime;
            JmbgPacijenta = pacijent.Jmbg;
            HitanSlucaj = pacijent.HitanSlucaj;

            if (HitanSlucaj == true)
                HitanSlucajCheck = true;
            else
                HitanSlucajCheck = false;

            DatumRodjenjaPacijenta = zdravstveniKarton.DatumRodjenja.ToString();
            MestoStanovanjaPacijenta = zdravstveniKarton.MestoStanovanja;
            UlicaPacijenta = zdravstveniKarton.UlicaIbroj;
            TelefonPacijenta = zdravstveniKarton.Telefon;

            if (zdravstveniKarton.Pol == Pol.Muski)
                PolPacijenta = "Muski";
            else
                PolPacijenta = "Zenski";

            if (zdravstveniKarton.BracniStatus == BracniStatus.NeozenjenNeudata)
                BracniStatusPacijenta = "NeozenjenNeudata";
            else if (zdravstveniKarton.BracniStatus == BracniStatus.OzenjenUdata)
                BracniStatusPacijenta = "OzenjenUdata";
            else if (zdravstveniKarton.BracniStatus == BracniStatus.RazvedenRazvedena)
                BracniStatusPacijenta = "RazvedenRazvedena";
            else
                BracniStatusPacijenta = "UdovacUdovica";

            PolPacijentaP = zdravstveniKarton.Pol;
            BracniStatusPacijentaP = zdravstveniKarton.BracniStatus;
            LoadAlergije(zdravstveniKarton.Id);

        }
    }
}
