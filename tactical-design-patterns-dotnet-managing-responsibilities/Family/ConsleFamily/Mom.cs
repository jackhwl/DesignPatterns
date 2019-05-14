using System;
using Family.Common;

namespace ConsoleFamily
{
    class Mom : IHairy, IEmotional
    {
        public void BeHappy()
        {
            Console.WriteLine("hihi");
        }

        public void GrowHair()
        {
            Console.WriteLine("hair gets long");
        }
    }
}
