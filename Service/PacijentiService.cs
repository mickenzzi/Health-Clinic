using Bolnica.Model;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows;
using Bolnica.DTO;

namespace Bolnica.Service
{
    class PacijentiService
    {
        private static PacijentiService instance = null;

        private PacijentiService()
        {
        }

        public static PacijentiService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PacijentiService();
                }
                return instance;
            }
        }
        public void setPacijent(Pacijent pacijent)
        {
            PacijentiRepository.Instance.SetPacijent(pacijent);
        }
        public bool AddPacijent(Pacijent pacijent)
        {
            return PacijentiRepository.Instance.AddPacijent(pacijent);
        }

        public List<Pacijent> GetSvePacijente()
        {
            return PacijentiRepository.Instance.GetSvePacijente();
        }

        public void RemovePacijent(Pacijent pacijent)
        {
            PacijentiRepository.Instance.RemovePacijent(pacijent);
        }

        public bool PotvrdaPostojanjaPacijenta(string jmbg)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            pacijenti = PacijentiRepository.Instance.GetSvePacijente();
            foreach (Pacijent p in pacijenti)
            {
                if (p.Jmbg == jmbg)
                {
                    return true;
                }
            }

            return false;
        }

        public Pacijent GetOdgPacijent(string jmbg)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            Pacijent pacijent = new Pacijent();
            pacijenti = PacijentiRepository.Instance.GetSvePacijente();
            foreach (Pacijent p in pacijenti)
            {
                if (p.Jmbg == jmbg)
                {
                    pacijent = p;
                }
            }

            return pacijent;
        }

        public bool DaLiImaMaksimalniBrojZakazanihPregleda(Pacijent pacijent)
        {
            List<Termin> sviPacijentoviTermini = new List<Termin>();
            int brojPregleda = 0;
            foreach (int sifra in pacijent.SifreZakazanihTermina)
            {
                Termin termin = TerminiService.Instance.GetTermin(sifra);
                Soba soba = SobeService.Instance.GetSobu(termin.SifraSobe);
                if (soba.Tip == TipoviSobe.Ordinacija)
                {
                    brojPregleda++;
                    if (brojPregleda >= 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public IspisiDTO ZakaziPregled(Pacijent pacijent, Termin termin)
        {
            IspisiDTO ispis = new IspisiDTO();

            if (DaLiImaMaksimalniBrojZakazanihPregleda(pacijent))
            {
                ispis.Status1 = true;
            }
            if (!(DateTime.Now.Year == pacijent.DatumPoslednjegZakazivanja.Year && DateTime.Now.Month == pacijent.DatumPoslednjegZakazivanja.Month && DateTime.Now.Day == pacijent.DatumPoslednjegZakazivanja.Day))
            {
                pacijent.BrojZakazivanjaUDanu = 0;
            }
            if (DaLiJeZakazivaoMaksimalnoPuta(pacijent))
            {
                pacijent.Blokiran = true;
                PacijentiRepository.Instance.SetPacijent(pacijent);
                ispis.Status2 = true;
            }
            if (ispis.Status1 == true || ispis.Status2)
            {
                return ispis;
            }

            List<Pacijent> sviPacijenti = PacijentiRepository.Instance.GetSvePacijente();
            foreach (Pacijent p in sviPacijenti)
            {
                if (p.Id == pacijent.Id)
                {
                    p.Blokiran = false;
                    p.SifreZakazanihTermina.Add(termin.Sifra);
                    p.BrojZakazivanjaUDanu++;
                    p.DatumPoslednjegZakazivanja = DateTime.Now;
                    MainWindow.p = p;
                }
            }

            PacijentiRepository.Instance.setSvePacijente(sviPacijenti);

            List<Termin> sviTermini = TerminiRepository.Instance.GetSveTermine();
            foreach (Termin t in sviTermini)
            {
                if (t.Sifra == termin.Sifra)
                {
                    t.Slobodan = false;
                    t.IdPacijenta = pacijent.Id;
                    t.Pacijent = pacijent;
                }
            }
            TerminiRepository.Instance.SetSveTermine(sviTermini);
            return ispis;
        }

        public void ResetujAkoTreba(Pacijent pacijent)
        {
            if (!(DateTime.Now.Year == pacijent.DatumPoslednjegPomeranja.Year && DateTime.Now.Month == pacijent.DatumPoslednjegPomeranja.Month && DateTime.Now.Day == pacijent.DatumPoslednjegPomeranja.Day))
            {
                pacijent.BrojPomeranjaUDanu = 0;
            }
        }
        public bool DaLiJePomeraoDvaPuta(Pacijent pacijent)
        {
            if (pacijent.BrojPomeranjaUDanu >= 2)
            {
                return true;
            }
            return false;
        }
        public bool DaLiJeZakazivaoMaksimalnoPuta(Pacijent pacijent)
        {
            if (pacijent.BrojZakazivanjaUDanu >= 4)
            {
                return true;
            }
            return false;
        }
        public bool AzurirajTermin(DateTime novoVreme, Termin termin, Pacijent pacijent)
        {
            ResetujAkoTreba(pacijent);

            if (DaLiJePomeraoDvaPuta(pacijent))
            {
                pacijent.Blokiran = true;
                PacijentiRepository.Instance.SetPacijent(pacijent);
                return false;
            }

            pacijent.BrojPomeranjaUDanu++;
            pacijent.DatumPoslednjegPomeranja = DateTime.Now;
            PacijentiRepository.Instance.SetPacijent(pacijent);
            termin.DatumVreme = novoVreme;
            TerminiService.Instance.SetTermin(termin);
            return true;
        }

        public void OtkaziPregled(Pacijent p, Termin t)
        {
            List<Pacijent> pacijenti = PacijentiRepository.Instance.GetSvePacijente();

            foreach(Pacijent pacijent in pacijenti)
            {
                if(pacijent.Id == p.Id)
                {
                    foreach(int sifraTermina in pacijent.SifreZakazanihTermina)
                    {
                        if(sifraTermina == t.Sifra)
                        {
                            pacijent.SifreZakazanihTermina.Remove(sifraTermina);
                            p.SifreZakazanihTermina.Remove(sifraTermina);
                            break;
                        }
                    }
                    break;
                }
            }
            
            PacijentiRepository.Instance.setSvePacijente(pacijenti);

            List<Termin> termini = TerminiRepository.Instance.GetSveTermine();

            foreach(Termin termin in termini)
            {
                if(termin.Sifra == t.Sifra) 
                {
                    termin.Slobodan = true;
                    termin.IdPacijenta = -1;
                    break;
                }
            }

            TerminiRepository.Instance.SetSveTermine(termini);

        }

        public String GetAnamnezu(String jmbg)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            pacijenti = PacijentiRepository.Instance.GetSvePacijente();
            List<ZdravstveniKarton> zdravstveniKartoni = new List<ZdravstveniKarton>();
            zdravstveniKartoni = ZdravstveniKartoniRepository.Instance.GetSveKartone();
            string anamneza = "Nema anamneze";
            foreach (Pacijent p in pacijenti)
            {
                if (p.Jmbg == jmbg)
                {
                    foreach (ZdravstveniKarton zk in zdravstveniKartoni)
                    {
                        if (p.IdZK == zk.Id)
                        {
                            anamneza = zk.Anamneza;
                        }
                    }
                }
            }
            return anamneza;
        }
  
        public List<Termin> GetTermineOdDo(Pacijent p, DateTime odDatum, DateTime doDatum, String lekar)
        {
            List<Termin> sviTermini = TerminiRepository.Instance.GetSveTermine();
            List<Termin> terminiOdDo = new List<Termin>();

            foreach (Termin t in sviTermini)
            {
                if (t.Slobodan && t.DatumVreme < doDatum && t.DatumVreme > odDatum)
                {
                    if (lekar == "" || lekar == t.ImePrzLekar)
                    {
                        terminiOdDo.Add(t);
                    }
                }
            }


            return terminiOdDo;
        }

        public List<Termin> GetTerminePoLekaru(String lekar)
        {
            List<Termin> sviTermini = TerminiRepository.Instance.GetSveTermine();
            List<Termin> terminiPoLekaru = new List<Termin>();

            foreach (Termin t in sviTermini)
            {
                if ((lekar == "" || lekar == t.ImePrzLekar) && t.Slobodan)
                {
                    terminiPoLekaru.Add(t);
                }
            }


            return terminiPoLekaru;
        }
    }
}
