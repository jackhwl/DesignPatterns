using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Car : ICar
    {
        private readonly string make;
        private readonly string model;
        private readonly Engine engine;
        private readonly IEnumerable<Seat> seats;
        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            this.make = make;
            this.model = model;
            this.engine = engine;
            this.seats = seats;
        }
        public CarRegistration Register()
        {
            return null;
            //return new CarRegistration(this.make.ToUpper(), this.model, this.engine.CylinderVolume, this.seats.Sum(seat => seat.Capacity));
        }

        public void Accept(Func<ICarVisitor> visitorFactory)
        {
            ICarVisitor visitor = visitorFactory();
            this.engine.Accept(()=>visitor);
            foreach(Seat seat in this.seats)
                seat.Accept(()=>visitor);
            visitor.VisitCar(this.make, this.model);
        }

        public T Accept<T>(Func<ICarVisitor<T>> visitorFactory)
        {
            ICarVisitor<T> visitor = visitorFactory();
            this.Accept(()=>(ICarVisitor)visitor);
            return visitor.ProduceResult();
        }

    }
}
