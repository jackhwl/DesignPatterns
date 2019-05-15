using System;
using Family.Common;

namespace ConsoleFamily2
{
    class Hairy : ChainElement, IHairy
    {
        private readonly string owner;
        public Hairy(string owner, ChainElement next): base(next)
        {
            this.owner = owner;
        }
        public Hairy(string owner)
        {
            this.owner = owner;
        }
        public void GrowHair()
        {
            Console.WriteLine("{0}: hair gets long", this.owner);
        }
    }
}
