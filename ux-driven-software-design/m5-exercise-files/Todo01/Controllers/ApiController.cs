using System;
using System.Security.Cryptography;
using System.Web.Mvc;
using Todo01.Infrastructure.Persistence.Model;
using Todo01.Infrastructure.Persistence.Repositories;

namespace Todo01.Controllers
{
    public class ApiController : Controller
    {
        private readonly TodoRepository _repository = new TodoRepository();

        [HttpPost]
        public ActionResult Add(
            [Bind(Prefix = "t")] string description,
            [Bind(Prefix = "d")] int daysFromNow = 0,
            [Bind(Prefix = "p")] PriorityLevel priority = PriorityLevel.Normal)
        {
            var item = new TodoItem
            {
                DueDate = DateTime.Today.Date.AddDays(daysFromNow),
                Description = description,
                Priority = priority
            };

            var id = _repository.Save(item);
            return Content(id.ToString());
        }

        [HttpGet]
        public JsonResult List(
            [Bind(Prefix = "d")] int days = 5)
        {
            var from = DateTime.MinValue;
            var to = DateTime.Today.Date.AddDays(days);
            var list = _repository.All(from, to, TaskStatus.Pending | TaskStatus.InProgress);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}