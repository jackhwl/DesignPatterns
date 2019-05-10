using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class VacationPartFactory : IVacationPartFactory
    {
        private IHotelSelector hotelSelector;
        private IHotelService hotelService;
        private IAirplaneService airplaneService;

        public VacationPartFactory(IHotelSelector hotelSelector, IHotelService hotelService, IAirplaneService airplaneService)
        {
            this.hotelSelector = hotelSelector;
            this.hotelService = hotelService;
            this.airplaneService = airplaneService;
        }
        public IVacationPart CreateDailyTrip(string tripName, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateFerryBooking(string lineName, bool fromMainland, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateFlight(string companyName, string source, string destination, DateTime date)
        {
            return this.airplaneService.SelectFlight(companyName, source, destination, date);
        }

        public IVacationPart CreateHotelReservation(string town, string hotelName, DateTime arrivalDate, DateTime leaveDate)
        {
            HotelInfo hotel = this.hotelSelector.SelectHotel(town, hotelName);
            return this.hotelService.MakeBooking(hotel, arrivalDate, leaveDate);
        }

        public IVacationPart CreateMassage(string salon, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
