using System;
using Family.Common;

namespace ConsoleFamily
{
    class Dog : IEmotional
    {
        public void BeHappy()
        {
            Console.WriteLine("tail waiving");
        }
    }
}
