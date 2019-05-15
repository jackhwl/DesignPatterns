using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public class NullEmotional : IEmotional
    {
        private static IEmotional instance;
        private NullEmotional() {}
        public static IEmotional Instance
        {
            get
            {
                if (instance == null) instance = new NullEmotional();
                return instance;
            }
        }

        public void BeHappy() {}
    }
}
