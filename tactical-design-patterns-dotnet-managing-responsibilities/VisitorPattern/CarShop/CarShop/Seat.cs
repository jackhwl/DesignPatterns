using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Seat
    {
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public Seat(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public static IEnumerable<Seat> FourSeasonConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1),
                    new Seat("Rear bench", 2)
                };
            }
        }
        public static IEnumerable<Seat> TwoSeasonConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1)
                };
            }
        }
    }
}
