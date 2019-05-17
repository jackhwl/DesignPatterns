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
            foreach(Car car in cars)
                Console.WriteLine("{0} {1} {2}cc {3}KW", 
                    car.Make, car.Model, car.Engine.CylinderVolume, car.Engine.Power);
        }
    }
}
