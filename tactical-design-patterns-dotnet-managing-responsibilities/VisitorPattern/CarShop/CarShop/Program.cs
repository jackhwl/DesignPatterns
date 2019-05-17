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
            IEnumerable<Car> cars = new CarRepository().GetAll();

            CarsView view = new CarsView(cars);
            view.Render();

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
