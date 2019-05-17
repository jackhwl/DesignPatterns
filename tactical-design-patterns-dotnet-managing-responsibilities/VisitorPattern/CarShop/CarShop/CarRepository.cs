﻿using System;
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
                new Car("Renault", "Megane", new Engine(66, 1598), Seat.FourSeasonConfiguration),
                new Car("Ford", "Focus", new Engine(74, 1596), Seat.FourSeasonConfiguration),
                new Car("Toyota", "Corolla", new Engine(78, 1587), Seat.FourSeasonConfiguration),
                new Car("Mercedes-Benz", "SLK250", new Engine(78, 1587), Seat.TwoSeasonConfiguration)
            };
        }
    }
}
