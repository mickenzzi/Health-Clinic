using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Service
{
    class ZdravstveniKartoniService
    {
        private static ZdravstveniKartoniService instance = null;

        private ZdravstveniKartoniService()
        {
        }

        public static ZdravstveniKartoniService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZdravstveniKartoniService();
                }
                return instance;
            }
        }

        public List<ZdravstveniKarton> GetSveKartone()
        {
            return ZdravstveniKartoniRepository.Instance.GetSveKartone();
        }

        public void SetSveKartone(List<ZdravstveniKarton> zdravstveniKartoni)
        {
            ZdravstveniKartoniRepository.Instance.SetSveKartone(zdravstveniKartoni);
        }

        public bool AddZdravstveniKarton(ZdravstveniKarton zdravstveniKarton)
        {
            List<ZdravstveniKarton> zdravstveniKartoni = GetSveKartone();

            foreach (ZdravstveniKarton zk in zdravstveniKartoni)
            {
                if (zk.Id == zdravstveniKarton.Id)
                {
                    return false;
                }
            }
            zdravstveniKartoni.Add(zdravstveniKarton);

            SetSveKartone(zdravstveniKartoni);

            return true;
        }

        public bool SetKarton(ZdravstveniKarton zdravstveniKarton)
        {
            List<ZdravstveniKarton> zdravstveniKartoni = GetSveKartone();


            foreach (ZdravstveniKarton zk in zdravstveniKartoni)
            {
                if (zk.IdPacijenta == zdravstveniKarton.IdPacijenta)
                {
                    zk.DatumRodjenja = zdravstveniKarton.DatumRodjenja;
                    zk.MestoStanovanja = zdravstveniKarton.MestoStanovanja;
                    zk.Pol = zdravstveniKarton.Pol;
                    zk.Telefon = zdravstveniKarton.Telefon;
                    zk.UlicaIbroj = zdravstveniKarton.UlicaIbroj;
                    zk.BracniStatus = zdravstveniKarton.BracniStatus;
                    zk.Anamneza = zdravstveniKarton.Anamneza;

                }
            }

            SetSveKartone(zdravstveniKartoni);

            return true;
        }

        public ZdravstveniKarton GetOdgKarton(int idPacijenta) 
        {
            List<ZdravstveniKarton> zdravstveniKartoni = new List<ZdravstveniKarton>();
            ZdravstveniKarton zdravstveniKarton = new ZdravstveniKarton();
            zdravstveniKartoni = GetSveKartone();
            foreach (ZdravstveniKarton zk in zdravstveniKartoni)
            {
                if (zk.IdPacijenta == idPacijenta)
                {
                    zdravstveniKarton = zk;
                }
            }

            return zdravstveniKarton;
        }

        
       

    }
}
