using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class CarToStringVisitor : ICarVisitor
    {
        private string report;
        private string seatsCount;
        public string GetCarDescripttion()
        {
            return this.report + string.Format(" {0} seats", this.seatsCount);
        }
        public void VisitCar(string make, string model)
        {
            //cannot access car.make car.model;
            this.report += string.Format("{0} {1}", make, model);
        }
        public void Visit(Engine engine)
        {
            this.report += string.Format(" {0}cc {1}KW", engine.CylinderVolume, engine.Power);
        }

        public void Visit(Seat seat)
        {
            this.seatsCount += seat.Capacity;
        }

    }
}
