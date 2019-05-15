using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public class NullHairy : IHairy
    {
        private static IHairy instance;
        private NullHairy() {}
        public static IHairy Instance
        {
            get
            {
                if (instance == null) instance = new NullHairy();
                return instance;
            }
        }
        public void GrowHair() { }
    }
}
