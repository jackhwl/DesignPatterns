using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace Reservations
{
    class Program
    {
        static IUnityContainer InitializaIoCContainer()
        {
            return new UnityContainer()
                .RegisterType<Application, Application>()
                .RegisterType<IVacationPartFactory, VacationPartFactory>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelSelector, HotelSector>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelService, HotelService>(new ContainerControlledLifetimeManager())
                .RegisterType<IAirplaneService, AirplaneService>(new ContainerControlledLifetimeManager());
        }
        static void Main(string[] args)
        {
            //new Application(
            //    new VacationPartFactory(
            //        new HotelSector(), 
            //        new HotelService(), 
            //        new AirplaneService()))
            //    .Run();

            InitializaIoCContainer()
                .Resolve<Application>()
                .Run();
            Console.ReadLine();
        }
    }
}
