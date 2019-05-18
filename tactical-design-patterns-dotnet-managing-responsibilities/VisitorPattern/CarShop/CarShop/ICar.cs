using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    interface ICar
    {
        CarRegistration Register();
        void Accept(Func<ICarVisitor> visitorFactory);
        T Accept<T>(Func<ICarVisitor<T>> visitorFactory);
    }
}
