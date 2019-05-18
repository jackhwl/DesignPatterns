using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class EngineStructure
    {
        public float Power {get; private set;}
        public float CylinderVolume {get; private set;}
        public EngineStructure(float power, float cylinderVolume)
        {
            this.Power = power;
            this.CylinderVolume = cylinderVolume;
        }
    }
}
