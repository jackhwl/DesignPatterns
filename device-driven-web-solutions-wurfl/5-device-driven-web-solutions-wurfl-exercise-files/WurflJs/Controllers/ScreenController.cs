using System.Web.Mvc;

namespace WurflJs.Controllers
{
    public class ScreenController : Controller
    {
        public ActionResult Default()
        {
            return PartialView();
        }
        public ActionResult Tablet()
        {
            return PartialView();
        }
        public ActionResult Smartphone()
        {
            return PartialView();
        }
	}
}