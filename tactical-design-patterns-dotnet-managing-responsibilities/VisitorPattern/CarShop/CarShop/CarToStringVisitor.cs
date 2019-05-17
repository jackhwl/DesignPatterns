using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class CarToStringVisitor : ICarVisitor
    {
        private string carDetails;
        private string engineDetails;
        private int seatsCount;
        public string GetCarDescripttion()
        {
            return string.Format("{0} {1} {2} seats", this.carDetails, this.engineDetails, this.seatsCount);
        }
        public void VisitCar(string make, string model)
        {
            //cannot access car.make car.model;
            carDetails = string.Format("{0} {1}", make, model);
        }
        public void VisitEngine(float power, float cylinderVolume, float temperatureC)
        {
            engineDetails = string.Format(" {0}cc {1}KW", cylinderVolume, power);
        }

        public void VisitSeat(string name, int capacity)
        {
            this.seatsCount += capacity;
        }

    }
}
