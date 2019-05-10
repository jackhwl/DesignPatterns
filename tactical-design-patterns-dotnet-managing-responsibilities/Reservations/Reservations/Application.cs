using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Application
    {
        private IVacationPartFactory partFactory;
        public Application(IVacationPartFactory partFactory)
        {
            this.partFactory = partFactory;
        }
        public void Run()
        {
            VacationSpecificationBuilder builder = 
                new VacationSpecificationBuilder(this.partFactory, 
                new DateTime(2019, 7, 14), 7, "PEA", "HaliFax");
            
            builder.SelectHotel("Holiday Inn");
            builder.SelectAirplane("Air Canada");

            VacationSpecification spec = builder.BuildVacation();
        }
    }
}
