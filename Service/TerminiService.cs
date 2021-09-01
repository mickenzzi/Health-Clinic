using Bolnica.Model;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bolnica.Service
{
    class TerminiService
    {
        private static TerminiService instance = null;

        private TerminiService()
        {
        }

        public static TerminiService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TerminiService();
                }
                return instance;
            }
        }


        public List<Termin> GetSveTermine()
        {
            return TerminiRepository.Instance.GetSveTermine();
        }

        public void SetSveTermine(List<Termin> termini)
        {
            TerminiRepository.Instance.SetSveTermine(termini);
        }

        public void SetTermin(Termin termin)
        {
            List<Termin> termini = GetSveTermine();

            foreach (Termin t in termini)
            {
                if (t.Sifra == termin.Sifra)
                {
                    t.SifraSobe = termin.SifraSobe;
                    t.DatumVreme = termin.DatumVreme;
                    t.KrajTermina = termin.KrajTermina;
                    t.IdPacijenta = termin.IdPacijenta;
                    t.Pacijent = termin.Pacijent;
                    t.Lekar = termin.Lekar;
                    t.Pomeren = termin.Pomeren;
                    t.Slobodan = termin.Slobodan;
                    t.ImePrzLekar = termin.ImePrzLekar;
                    t.PacijentInfo = termin.PacijentInfo;
                    t.Ocenjen = termin.Ocenjen;

                }
            }

            SetSveTermine(termini);
        }

        public bool ZakaziOperaciju(Termin t)
        {
            Soba soba = SobeService.Instance.GetSobu(t.SifraSobe);
            soba.Slobodna = false;
            SobeService.Instance.SetSoba(soba);
            return AddTermin(t);
        }

        public bool ZakaziPregled(Termin t)
        {
            Soba soba = SobeService.Instance.GetSobu(t.SifraSobe);
            soba.Slobodna = false;
            SobeService.Instance.SetSoba(soba);
            return AddTermin(t);
        }

        public bool AddTermin(Termin termin)
        {
            List<Termin> termini = GetSveTermine();

            foreach (Termin t in termini)
                if (t.Sifra == termin.Sifra)
                    return false;

            termini.Add(termin);
            SetSveTermine(termini);
            return true;
        }

        public void OtkaziOperaciju(Termin termin)
        {
            Soba soba = SobeService.Instance.GetSoba(termin.SifraSobe);
            soba.Slobodna = true;
            SobeService.Instance.SetSoba(soba);
            RemoveTermin(termin);
        }

        public void OtkaziPregled(Termin termin)
        {
            Soba soba = SobeService.Instance.GetSoba(termin.SifraSobe);
            soba.Slobodna = true;
            SobeService.Instance.SetSoba(soba);
            RemoveTermin(termin);
        }

        public void RemoveTermin(Termin termin)
        {
            List<Termin> termini = GetSveTermine();

            for (int i = 0; i < termini.Count; i++)
                if (termini[i].Sifra == termin.Sifra)
                    termini.RemoveAt(i);

            SetSveTermine(termini);
        }

        public bool ZakaziTermin(Termin termin)
        {
            List<Termin> termini = GetSveTermine();

            foreach (Termin t in termini)
                if (t.DatumVreme == termin.DatumVreme && t.Soba.Sifra == termin.Soba.Sifra)
                    return false;

            termini.Add(termin);
            SetSveTermine(termini);
            return true;
        }

        public Lekar SlobodanLekar(DateTime datum)
        {
            List<Termin> termini = TerminiRepository.Instance.GetSveTermine();
            List<Lekar> lekari = LekariRepository.Instance.GetSveLekare();
            Lekar lekar = new Lekar();
            Boolean zauzetLekar;
            Boolean odgTermin;
            odgTermin = false;
            zauzetLekar = false;

            foreach (Termin t in termini)
            {
                if (t.DatumVreme.Year == datum.Year && t.DatumVreme.Month == datum.Month && t.DatumVreme.Day == datum.Day && datum.Hour >= t.DatumVreme.Hour && datum.Hour <= t.DatumVreme.Hour + 1)
                {
                    odgTermin = true;
                    break;
                }
                else
                {
                    odgTermin = false;
                }
            }
            if (odgTermin == true)
            {
                foreach (Lekar l in lekari)
                {
                    foreach (Termin t in termini)
                    {
                        if (t.Lekar.Id == l.Id)
                        {
                            zauzetLekar = true;
                            break;
                        }
                        else
                        {
                            zauzetLekar = false;
                        }
                    }

                    if (zauzetLekar == false)
                    {
                        lekar = l;
                        break;
                    }
                    else 
                    {
                        lekar = null;
                    }
                }
            }
            else
            {
                foreach (Lekar l in lekari)
                {
                    lekar = l;
                    break;
                }

            }
            return lekar;
        }
        public List<Termin> GetOdgTermine(int idPacijenta, TipoviSobe tip)
        {
            List<Termin> sviTermini = new List<Termin>();
            List<Termin> termini = new List<Termin>();
            List<Termin> odgTermini = new List<Termin>();
            List<Soba> sobe = new List<Soba>();
            sobe = SobeService.Instance.GetSobeByTip(tip, false);

            sviTermini = TerminiRepository.Instance.GetSveTermine();
            foreach (Termin t in sviTermini)
            {
                if (t.Slobodan == false && t.Pacijent.Id == idPacijenta)
                {
                    termini.Add(t);
                }
            }

            foreach (Soba s in sobe)
            {
                foreach (Termin t in termini)
                {
                    if (s.Sifra == t.SifraSobe)
                    {
                        odgTermini.Add(t);
                    }
                }
            }

            return odgTermini;
        }

        public bool GetOdgTermin(DateTime datum, int idLekara)
        {
            List<Termin> termini = new List<Termin>();
            termini = TerminiRepository.Instance.GetSveTermine();
            foreach (Termin t in termini)
            {
                if (t.DatumVreme == datum && t.Lekar.Id == idLekara)
                {
                    return true;
                }
            }
            return false;
        }

        public Termin GetTermin(int idTermina) 
        {
            Termin termin = new Termin();
            List<Termin> termini = new List<Termin>();
            termini = GetSveTermine();
            foreach(Termin t in termini) 
            {
                if (t.Sifra == idTermina) 
                {
                    termin = t;
                }
            }

            return termin;
        }

        public List<Termin> getZakazaneTermine(Pacijent pacijent)
        {
            List<Termin> sviTermini = TerminiRepository.Instance.GetSveTermine();
            List<Termin> zakazaniTermini = new List<Termin>();

            foreach(Termin t in sviTermini)
            {
                foreach(int sifra in pacijent.SifreZakazanihTermina)
                {
                    if(t.Sifra == sifra)
                    {
                        zakazaniTermini.Add(t);
                    }
                }
            }

            return zakazaniTermini;
        }
        public DateTime GetDatumTermina(int sifraSobe) 
        {
            DateTime datum = default;
            List<Termin> termini = new List<Termin>();
            termini = TerminiRepository.Instance.GetSveTermine();
            foreach (Termin t in termini)
            {
                if (t.SifraSobe == sifraSobe)
                {
                    datum = t.DatumVreme;
                }
            }
            return datum;
        }
        public bool IzmeniHospitalizaciju(Termin stari, Termin novi)
        {
            Boolean izmenjenTermin = false;

            List<Termin> termini = GetSveTermine();
            foreach (Termin t in termini)
            {
                if (t.Sifra == stari.Sifra)
                {
                    t.KrajTermina = novi.KrajTermina;
                    izmenjenTermin = true;
                    SetTermin(t);

                }
            }

            return izmenjenTermin;
        }
        public string[] GetVremena()
        {
            Termin termin = new Termin();
            return termin.Vremena;
        }
        public bool IzmeniTermin(Termin stari, Termin novi)
        {
            Boolean izmenjenTermin = false;

            List<Termin> termini = GetSveTermine();
            foreach (Termin t in termini)
            {
                if (t.Sifra == stari.Sifra)
                {
                    if (stari.JmbgLekara == null)
                    {
                        t.KrajTermina = novi.KrajTermina;
                        izmenjenTermin = true;
                        SetTermin(t);
                    }
                    else if (!(t.DatumVreme == novi.DatumVreme && t.SifraSobe == novi.SifraSobe)) // kod produzetka termina ovaj uslov nije ispunjen
                    {
                        izmenjenTermin = true;
                        t.DatumVreme = novi.DatumVreme;
                        if (novi.SifraSobe != 0)
                            t.SifraSobe = novi.SifraSobe;
                        SetTermin(t);
                    }
                }
            }

            return izmenjenTermin;
        }
    }
}
