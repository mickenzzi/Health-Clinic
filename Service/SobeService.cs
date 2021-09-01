using Bolnica.Model;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Service
{
    class SobeService
    {
        private static SobeService instance = null;

        private SobeService()
        {
        }

        public static SobeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SobeService();
                }
                return instance;
            }
        }

        public List<Soba> GetSveSobe()
        {
            return SobeRepository.Instance.GetSveSobe();
        }

        public void SetSveSobe(List<Soba> sobe)
        {
            SobeRepository.Instance.SetSveSobe(sobe);
        }

        public Soba GetSobu(int sifraSobe)
        {
            Soba soba = new Soba();
            List<Soba> sobe = SobeRepository.Instance.GetSveSobe();
            foreach(Soba s in sobe)
            {
                if(s.Slobodna==true && s.Sifra == sifraSobe)
                {
                    return s;
                }
            }
            return soba;
        }

        public Soba GetSobuById(int sifraSobe)
        {
            Soba soba = new Soba();
            List<Soba> sobe = GetSveSobe();
            foreach (Soba s in sobe)
                if (s.Sifra == sifraSobe)
                    soba = s;

            return soba;
        }

        public Soba GetSoba(int sifraSobe)
        {
            Soba soba = new Soba();
            List<Soba> sobe = SobeRepository.Instance.GetSveSobe();
            foreach (Soba s in sobe)
            {
                if (s.Sifra == sifraSobe)
                {
                    return s;
                }
            }
            return soba;
        }


        public Soba GetSlobodnaSoba(TipoviSobe tip) 
        {
            Soba soba = new Soba();
            List<Soba> sobe = SobeRepository.Instance.GetSveSobe();
            foreach(Soba s in sobe) 
            {
                if(s.Tip == tip && s.Slobodna==true) 
                {
                    soba = s;
                    break;
                }
            }
            return soba;
        }

        public bool SetSoba(Soba soba)
        {
            List<Soba> sobe = GetSveSobe();

            foreach (Soba s in sobe)
            {
                if (s.Sifra == soba.Sifra)
                {
                    s.BrojSobe = soba.BrojSobe;
                    s.Sprat = soba.Sprat;
                    s.Tip = soba.Tip;
                    s.Kapacitet = soba.Kapacitet;
                    s.Zauzetost = soba.Zauzetost;
                    s.Slobodna = soba.Slobodna;
                }
            }

            SetSveSobe(sobe);
            return true;
        }

        public List<Soba> GetSobeByTip(TipoviSobe tip,bool slobodna) 
        {
            List<Soba> sveSobe = SobeRepository.Instance.GetSveSobe();
            List<Soba> sobe = new List<Soba>();
            foreach(Soba s in sveSobe) 
            {
                if(s.Slobodna==slobodna && s.Tip == tip) 
                {
                    sobe.Add(s);
                }
            }
            return sobe;
        }

        public List<Soba> GetZauzeteSobe() 
        {
            List<Soba> sveSobe = SobeRepository.Instance.GetSveSobe();
            List<Soba> sobe = new List<Soba>();
            foreach(Soba s in sveSobe) 
            {
                if (s.Slobodna == false) 
                {
                    sobe.Add(s);
                }
            }
            return sobe;
        }

        public bool DodajSobu(Soba soba)
        {
            List<Soba> sobe = GetSveSobe();

            foreach (Soba s in sobe)
                if (s.Sifra == soba.Sifra)
                    return false;

            for (int i = 1; i <= soba.Kapacitet; i++)
            {
                Inventar inventar = new Inventar(TipoviInventara.BolnickiKrevet, i, soba.Sifra, null, false);
                soba.KrevetiInventar.Add(inventar.Sifra);
                InventarService.Instance.DodajInventar(inventar);

            }

            soba.Slobodna = true;
            sobe.Add(soba);
            SetSveSobe(sobe);
            return true;
        }

        public void ObrisiSobu(Soba soba)
        {
            List<Soba> sobe = GetSveSobe();

            for (int i = 0; i < sobe.Count; i++)
                if (sobe[i].Sifra == soba.Sifra)
                    sobe.RemoveAt(i);

            SetSveSobe(sobe);
        }
    }
}

