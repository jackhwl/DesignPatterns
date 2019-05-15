using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public class NullChainElement : IChainElement
    {
        private static IChainElement instance;
        private NullChainElement() { }
        public static IChainElement Instance
        {
            get
            {
                if (instance == null) instance = new NullChainElement();
                return instance;
            }
        }
        public T As<T>(T defaultValue) where T : class
        {
            return defaultValue;
        }
    }
}
