using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class HotelSector : IHotelSelector
    {
        public HotelInfo SelectHotel(string town, string hotelName)
        {
            Console .WriteLine("Looking up hotel {0} in {1}", hotelName, town);
            return new HotelInfo() { Town = town, HotelName = hotelName};
        }
    }
}
