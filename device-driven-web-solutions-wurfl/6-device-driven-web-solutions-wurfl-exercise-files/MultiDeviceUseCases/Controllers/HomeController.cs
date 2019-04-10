using System.Web.Mvc;
using MultiDeviceUseCases.Services.Home;
using MultiDeviceUseCases.Services.Shared;

namespace MultiDeviceUseCases.Controllers
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
            var model = _service.GetModelForIndex(Request.UserAgent);

            return View(model);
        }

    }
}
