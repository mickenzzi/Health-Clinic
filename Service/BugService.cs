using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Service
{
    public class BugService
    {
        private static BugService instance = null;

        private BugService()
        {
        }

        public static BugService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BugService();
                }
                return instance;
            }
        }

        public bool AddBug(Bug bug)
        {
            List<Bug> bagovi = new List<Bug>();
            bagovi = BugRepository.Instance.GetSveBagove();

            foreach (Bug b in bagovi)
                if (b.Id == bug.Id)
                    return false;

            bagovi.Add(bug);
            BugRepository.Instance.SetSveBagove(bagovi);
            return true;
        }
    }
}
