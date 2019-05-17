using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class CarRepository
    {
        public IEnumerable<Car> GetAll()
        {
            return new Car[]
            {
                new Car("Renault", "Megane", new Engine(66, 1598)),
                new Car("Ford", "Focus", new Engine(74, 1596)),
                new Car("Toyota", "Corolla", new Engine(78, 1587))
            };
        }
    }
}
