using System.Web.Routing;
using MultiView.Common.Config;

namespace MultiView
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
