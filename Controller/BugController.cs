using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.Controller
{
    public class BugController
    {
        private static BugController instance = null;

        private BugController()
        {
        }

        public static BugController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BugController();
                }
                return instance;
            }
        }

        public bool AddBug(Bug bug)
        {
            return BugService.Instance.AddBug(bug);
        }
    }
}
