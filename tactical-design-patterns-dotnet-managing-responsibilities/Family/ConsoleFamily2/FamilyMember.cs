using System;
using System.Collections.Generic;
using Family.Common;

namespace ConsoleFamily2
{
    class FamilyMember
    {
        //private readonly chain parts;
        //public FamilyMember(IEnumerable<object> parts)
        //{
        //    this.parts = new List<object>(parts);
        //}

        //public T As<T>()
        //{
        //    foreach(object obj in this.parts)
        //    {
        //        if (obj is T) return (T)obj;
        //    }
        //    return default(T);
        //}

        private readonly ChainElement components;
        public FamilyMember(ChainElement components)
        {
            this.components = components;
        }

        public T As<T>(T defaultValue) where T: class
        {
            return this.components.As<T>(defaultValue);
        }
    }
}
