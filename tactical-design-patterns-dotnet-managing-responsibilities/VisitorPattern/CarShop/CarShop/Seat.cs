using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Seat
    {
        private string name;
        private int capacity;
        public Seat(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }
        public void Accept(ICarVisitor visitor)
        {
            visitor.VisitSeat(this.name, this.capacity);
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
