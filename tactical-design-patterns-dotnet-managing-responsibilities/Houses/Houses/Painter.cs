using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    public class Painter
    {
        private int daysPerHouse;
        public Painter(int daysPerHouse)
        {
            this.daysPerHouse = daysPerHouse;
        }

        public void Paint(int totalHouses)
        {
            Console.WriteLine("Painting {0} houses for {1} days.", 
                totalHouses, totalHouses * this.daysPerHouse);
        }
    }
}
