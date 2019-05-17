using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable<Car> cars = new CarRepository().GetAll();

            //CarsView view = new CarsView(cars);
            //view.Render();

            Car car = new Car("Renault", "Megane", new Engine(66, 1598), Seat.FourSeasonConfiguration);

            CarRegistration registration = car.Register();

            Console.WriteLine(registration);

            //CarRegistration registration1 = new CarRegistration(car.make, car.model, car.engine.CylinderVolume, car.seats.Sum(seat => seat.Capacity));
            //Console.WriteLine(registration1);

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
