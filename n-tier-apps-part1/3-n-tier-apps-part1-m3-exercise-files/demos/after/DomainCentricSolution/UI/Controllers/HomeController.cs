using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Interfaces;
using Infrastructure;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageProvider _messageProvider;
        public HomeController(IMessageProvider messageProvider)
        {
            _messageProvider = messageProvider;
        }

        public HomeController() : this(new MessageProvider())
        {
        }

        public ActionResult Index()
        {
            string message = _messageProvider.GetMessage();
            ViewData.Add("message", message);
            return View();
        }
    }
}
