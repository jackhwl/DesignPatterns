using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFamily2
{
    class FamilyMember
    {
        private readonly IEnumerable<object> parts;
        public FamilyMember(IEnumerable<object> parts)
        {
            this.parts = new List<object>(parts);
        }

        public T As<T>()
        {
            foreach(object obj in this.parts)
            {
                if (obj is T) return (T)obj;
            }
            return default(T);
        }
    }
}
