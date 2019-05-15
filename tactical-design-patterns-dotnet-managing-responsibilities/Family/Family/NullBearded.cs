using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public class NullBearded: IBearded
    {
        private static IBearded instance;
        private NullBearded() {}
        public static IBearded Instance
        {
            get
            {
                if (instance == null) instance = new NullBearded();
                return instance;
            }
        }

        public void GrownBeard() {}
    }
}
