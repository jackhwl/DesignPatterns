using System;
using Family.Common;

namespace ConsoleFamily
{
    class Dad : IBearded, IEmotional
    {
        public void BeHappy()
        {
            Console.WriteLine("hoho");
        }

        public void GrownBeard()
        {
            Console.WriteLine("beard grows");
        }
    }
}
