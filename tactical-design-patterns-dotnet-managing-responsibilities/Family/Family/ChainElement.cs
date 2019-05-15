using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public class ChainElement
    {
        private readonly ChainElement next;
        public ChainElement(ChainElement next)
        {
            this.next = next;
        }

        public virtual T As<T>(T defaultValue) where T: class
        {
            if (this is T)
                return this as T;

            if (this.next != null)
                return this.next.As<T>(defaultValue);

            return defaultValue;
        }
    }
}
