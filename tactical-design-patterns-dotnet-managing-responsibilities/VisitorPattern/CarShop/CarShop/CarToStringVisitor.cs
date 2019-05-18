using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class CarToStringVisitor : ICarVisitor<string>
    {
        private string carDetails;
        private string engineDetails;
        private int seatsCount;
        public string ProduceResult()
        {
            return string.Format("{0} {1} {2} seats", this.carDetails, this.engineDetails, this.seatsCount);
        }
        public void VisitCar(string make, string model)
        {
            //cannot access car.make car.model;
            carDetails = string.Format("{0} {1}", make, model);
        }
        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            engineDetails = string.Format(" {0}cc {1}KW", structure.CylinderVolume, structure.Power);
        }

        public void VisitSeat(string name, int capacity)
        {
            this.seatsCount += capacity;
        }

    }
}
