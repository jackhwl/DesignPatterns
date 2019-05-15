using System;
using Family.Common;

namespace ConsoleFamily2
{
    class Bearded : ChainElement, IBearded
    {
        private readonly string owner;
        public Bearded(string owner, ChainElement next) : base(next)
        {
            this.owner = owner;
        }
        public void GrownBeard()
        {
            Console.WriteLine("{0}: beard grows", this.owner);
        }
    }
}
