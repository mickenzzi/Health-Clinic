using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Service;
using Bolnica.Model;

namespace Bolnica.Controller
{
    class ZdravstveniKartoniController
    {
        private static ZdravstveniKartoniController instance = null;

        private ZdravstveniKartoniController()
        {
        }

        public static ZdravstveniKartoniController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZdravstveniKartoniController();
                }
                return instance;
            }
        }

        public bool AddZdravstveniKarton(ZdravstveniKarton zk)
        {
            return ZdravstveniKartoniService.Instance.AddZdravstveniKarton(zk);
        }

        public bool SetKarton(ZdravstveniKarton zk)
        {
            return ZdravstveniKartoniService.Instance.SetKarton(zk);
        }

        public ZdravstveniKarton GetOdgKarton(int idPacijenta)
        {
            return ZdravstveniKartoniService.Instance.GetOdgKarton(idPacijenta);
        }

        public List<ZdravstveniKarton> GetSveKartone()
        {
            return ZdravstveniKartoniService.Instance.GetSveKartone();
        }

    }
}
