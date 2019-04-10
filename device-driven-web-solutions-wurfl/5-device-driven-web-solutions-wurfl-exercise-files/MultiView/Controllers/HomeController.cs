using System.Web.Mvc;
using MultiView.Services.Home;
using MultiView.Services.Shared;

namespace MultiView.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _service;
        public HomeController() : this(new HomeService())
        {
        }
        public HomeController(IHomeService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            // Basic info
            var model = _service.GetModelForIndex();
            return View(model);
        }

    }
}
