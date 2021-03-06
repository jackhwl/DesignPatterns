﻿using System;
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
            //Car car = new CarRepository().GetAll().Last();
            //car.Accept(()=> new SaveCarVisitor());

            //Console.WriteLine("Press ENTER to exit...");

            IEnumerable<Car> cars = new CarRepository().GetAll();
            foreach(Car car in cars)
                Console.WriteLine(car.Register());

            //CarsView view = new CarsView(cars);
            //view.Render();

            //Car car = new Car("Renault", "Megane", new Engine(66, 1598), Seat.FourSeasonConfiguration);

            //CarRegistration registration = car.Register();

            //Console.WriteLine(registration);

            //CarRegistration registration1 = new CarRegistration(car.make, car.model, car.engine.CylinderVolume, car.seats.Sum(seat => seat.Capacity));
            //Console.WriteLine(registration1);

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
