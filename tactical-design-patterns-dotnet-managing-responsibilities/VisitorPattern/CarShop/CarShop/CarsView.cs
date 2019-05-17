using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class CarsView
    {
        private IEnumerable<Car> cars;
        public CarsView(IEnumerable<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }

        public void Render()
        {
            //foreach(Car car in cars)
            //    Console.WriteLine("{0} {1} {2}cc {3}KW {4} seat(s)", 
            //        car.make, car.model, 
            //        car.engine.CylinderVolume, car.engine.Power,
            //        car.seats.Sum(seat => seat.Capacity));
        }
    }
}
