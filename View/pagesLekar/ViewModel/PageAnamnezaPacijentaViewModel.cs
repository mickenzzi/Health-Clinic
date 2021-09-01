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
    public class PageAnamnezaPacijentaViewModel : BindableBase
    {
        public ObservableCollection<Alergija> Alergije { get; set; }
        public ObservableCollection<Recept> Recepti { get; set; }
        public MyICommand HospitalizujPacijentaCommand { get; set; }
        public MyICommand SacuvajAnamnezuPacijentaCommand { get; set; }
        public MyICommand IzdajReceptPacijentuCommand { get; set; }
        public MyICommand OdustaniOdPregledaCommand { get; set; }

        private LekarView parent;
        private int idTermina;
        private Termin termin;
        private string imePacijenta;
        private string prezimePacijenta;
        private string jmbgPacijenta;
        private bool hitanSlucaj;
        private string lekarInfo;
        private string anamneza;
        private Lekar lekar;
        private Pacijent pacijent;
        private bool proveraHospitalizacije;

        public PageAnamnezaPacijentaViewModel(LekarView parent, int idTermina)
        {   
            
            this.parent = parent;
            this.idTermina = idTermina;
            LoadKarton();
            HospitalizujPacijentaCommand = new MyICommand(OnHospitalizacija);
            SacuvajAnamnezuPacijentaCommand = new MyICommand(OnSacuvaj);
            IzdajReceptPacijentuCommand = new MyICommand(OnIzdajRecept);
            OdustaniOdPregledaCommand = new MyICommand(OnOdustani);
        }

        public string LekarInfo
        {
            get { return lekarInfo; }
            set
            {
                lekarInfo = value;
                OnPropertyChanged("LekarInfo");
            }
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

        public bool HitanSlucaj
        {
            get { return hitanSlucaj; }
            set
            {
                hitanSlucaj = value;
                OnPropertyChanged("HitanSlucaj");
            }
        }

        public string Anamneza
        {
            get { return anamneza; }
            set
            {
                anamneza = value;
                OnPropertyChanged("Anamneza");
            }
        }

        public bool ProveraHospitalizacije
        {
            get { return proveraHospitalizacije; }
            set
            {
                proveraHospitalizacije = value;
                OnPropertyChanged("ProveraHospitalizacije");
            }
        }

        public void LoadKarton()
        {   
            termin = TerminiController.Instance.GetTermin(idTermina);
            pacijent = PacijentiController.Instance.GetOdgPacijent(termin.JmbgPacijenta);
            lekar = LekariController.Instance.GetOdgLekarByJmbg(termin.JmbgLekara);
            LekarInfo = lekar.Ime + " " + lekar.Prezime;
            ImePacijenta = pacijent.Ime;
            PrezimePacijenta = pacijent.Prezime;
            JmbgPacijenta = pacijent.Jmbg;
            Console.WriteLine("Id otvorenog termina: " + termin.Sifra);

            ZdravstveniKarton zk = ZdravstveniKartoniController.Instance.GetOdgKarton(pacijent.Id);
            List<Alergija> sveAlergije = new List<Alergija>();
            sveAlergije = AlergijaController.Instance.GetSveAlergije(zk.Id);
            ObservableCollection<Alergija> alergije = new ObservableCollection<Alergija>(sveAlergije);
            Alergije = alergije;

            List<Recept> sviRecepti = new List<Recept>();
            List<Recept> recepti = new List<Recept>();
            sviRecepti = ReceptiController.Instance.GetSveRecepte();
            foreach (Recept r in sviRecepti)
                if (r.JmbgPacijenta == pacijent.Jmbg)
                    recepti.Add(r);
            ObservableCollection<Recept> receptiObs = new ObservableCollection<Recept>(recepti);
            Recepti = receptiObs;

            Anamneza = PacijentiController.Instance.GetAnamnezu(pacijent.Jmbg);
            if (Anamneza == "")
                Anamneza = "Nije uneta anamneza";

            OnProveriHospitalizaciju();
        }

        public bool OnProveriHospitalizaciju()
        {
            ProveraHospitalizacije = true;
            List<Inventar> sviKreveti = InventarController.Instance.GetSveKrevete();
            foreach(Inventar i in sviKreveti)
            {
                if (i.JmbgPacijenta == termin.JmbgPacijenta)
                {
                    ProveraHospitalizacije = false;
                    break;
                }
            }
            return ProveraHospitalizacije;
        }

        private void OnHospitalizacija()
        {   
            WindowHospitalizacijaPacijenta hp = new WindowHospitalizacijaPacijenta(parent, termin.Sifra);
            hp.Show();
        }

        private void OnSacuvaj()
        {
            ZdravstveniKarton zk = ZdravstveniKartoniController.Instance.GetOdgKarton(pacijent.Id);
            zk.Anamneza = Anamneza;
            ZdravstveniKartoniController.Instance.SetKarton(zk);
            parent.frejm.Content = new PagePrikazTermina(parent, lekar.Jmbg);
        }

        private void OnIzdajRecept()
        {
            WindowIzdavanjeRecepta ir = new WindowIzdavanjeRecepta(parent, termin.Sifra);
            ir.Show();
        }

        private void OnOdustani()
        {
            parent.frejm.Content = new PagePrikazTermina(parent, lekar.Jmbg);
        }
    }
}
