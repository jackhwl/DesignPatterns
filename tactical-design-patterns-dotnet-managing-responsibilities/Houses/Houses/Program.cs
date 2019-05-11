using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    class Program
    {
        static void Main(string[] args)
        {
            var owner = new LandOwner(14);

            owner.MaintainHouses();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
