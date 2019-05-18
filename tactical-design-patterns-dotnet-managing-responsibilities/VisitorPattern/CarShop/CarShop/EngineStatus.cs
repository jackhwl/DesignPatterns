using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class EngineStatus
    {
        public float TemperatureC {get; private set;}
        public float OilPressure {get; private set;}

        public EngineStatus(float temperatureC, float oilPressure)
        {
            this.TemperatureC = temperatureC;
            this.OilPressure = oilPressure;
        }
    }
}
