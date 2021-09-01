using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Service
{
    class ReceptiService
    {
        private static ReceptiService instance = null;

        private ReceptiService()
        {
        }

        public static ReceptiService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceptiService();
                }
                return instance;
            }
        }
        public List<Recept> GetSveRecepte()
        {
            return ReceptiRepository.Instance.GetSveRecepte();
        }

        public bool SetSveRecepte(List<Recept> recepti)
        {
            return ReceptiRepository.Instance.SetSveRecepte(recepti);
        }

        public void DodajRecept(Recept recept)
        {
            List<Recept> ucitaniRecepti = GetSveRecepte();
            ucitaniRecepti.Add(recept);
            SetSveRecepte(ucitaniRecepti);
        }


        public void ObrisiRecept(Recept recept)
        {
            List<Recept> ucitaniRecepti = GetSveRecepte();
            foreach (Recept r in ucitaniRecepti)
                if (r.SifraRecepta == recept.SifraRecepta)
                    ucitaniRecepti.Remove(r);
            SetSveRecepte(ucitaniRecepti);
        }

        public void SetRecept(Recept recept)
        {
            List<Recept> ucitaniRecepti = GetSveRecepte();
            foreach (Recept r in ucitaniRecepti)
            {
                if (r.SifraRecepta == recept.SifraRecepta)
                {
                    r.SifraLeka = recept.SifraLeka;
                    r.KolicinaLeka = recept.KolicinaLeka;
                    r.NacinUpotrebe = recept.NacinUpotrebe;
                    r.JmbgPacijenta = recept.JmbgPacijenta;
                    r.DatumIzdavanjaLeka = recept.DatumIzdavanjaLeka;
                }
            }
        }
    }
}
