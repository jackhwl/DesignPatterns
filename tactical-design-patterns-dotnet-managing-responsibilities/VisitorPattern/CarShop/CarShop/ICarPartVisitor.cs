using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    interface ICarPartVisitor
    {
        void VisitEngine(EngineStructure structure, EngineStatus status);
        void VisitSeat(string name, int capacity);
    }
}
