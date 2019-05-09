using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class VacationSpecificationBuilder
    {
        private IHotelService hotelService;
        private IAirplaneService airplaneService;
        private IList<IVacationPart> parts = new List<IVacationPart>();
        private DateTime arrivalDate;
        private int totalNights;

        private string livingTown;
        private string destinationTown;

        public VacationSpecificationBuilder(IHotelService hotelService, IAirplaneService airplaneService, DateTime arrivalDate, int totalNights, string livingTown, string destinationTown)
        {
            this.hotelService = hotelService;
            this.airplaneService = airplaneService;
            this.arrivalDate = arrivalDate;
            this.totalNights = totalNights;
            this.livingTown = livingTown;
            this.destinationTown = destinationTown;
        }

        public void SelectHotel(string hotelName)
        {
            IVacationPart part = this.hotelService.MakeBooking(hotelName, this.arrivalDate, this.arrivalDate.AddDays(this.totalNights));
            this.parts.Add(part);
        }

        public void SelectAirplane(string companyName)
        {
            IVacationPart part = this.airplaneService.SelectFlight(companyName, this.livingTown, this.destinationTown, this.arrivalDate);
            this.parts.Add(part);
            part = this.airplaneService.SelectFlight(companyName, this.destinationTown, this.livingTown, this.arrivalDate.AddDays(this.totalNights));
            this.parts.Add(part);
        }
        public VacationSpecification BuildVacation()
        {
            foreach (IVacationPart part in this.parts)
                part.Purchase();

            return new VacationSpecification(this.parts);  // TODO implement
        }
    }
}
