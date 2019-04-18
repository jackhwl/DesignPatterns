using System.Web.Mvc;
using Todo02.Models;

namespace Todo02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ViewModelBase();
            return View(model);
        }
    }
}