using System.Web.Mvc;
using WurflJs.ViewModels;

namespace WurflJs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new ViewModelBase());
        }

        public ActionResult Basic()
        {
            return View(new ViewModelBase());
        }
    }
}
