using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application(
                new VacationPartFactory(new HotelSector(), new HotelService(), new AirplaneService()))
                .Run();
            Console.ReadLine();
        }
    }
}
