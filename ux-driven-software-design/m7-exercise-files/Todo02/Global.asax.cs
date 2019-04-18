using System.Web.Routing;
using Todo02.Infrastructure.Framework;

namespace Todo02
{
    public class Todo02Application : System.Web.HttpApplication
    {
        public static IBus Bus { get; set; }
 
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BusConfig.Initialize();
        }
    }
}
