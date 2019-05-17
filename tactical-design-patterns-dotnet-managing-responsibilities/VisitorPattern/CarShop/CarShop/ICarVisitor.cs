using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    interface ICarVisitor : ICarPartVisitor
    {
        void VisitCar(string make, string model);
    }
}
