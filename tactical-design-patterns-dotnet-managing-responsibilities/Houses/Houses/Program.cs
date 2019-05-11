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
            var owner = new LandOwner(14, new Painter[]{
                new Painter("Joe", 4),
                new Painter("Jill", 5),
                new Painter("Buster", 3)
            });

            owner.MaintainHouses();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
