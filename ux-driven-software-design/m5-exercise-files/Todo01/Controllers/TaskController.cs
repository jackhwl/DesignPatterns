using System;
using System.Linq;
using System.Web.Mvc;
using Todo01.Application;
using Todo01.Infrastructure.Persistence.Model;
using Todo01.Models;

namespace Todo01.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskService _service = new TaskService();

        public ActionResult List(DateTime? from, DateTime? to)
        {
            var model = _service.GetTaskListViewModel(from, to);
            return View(model);
        }

        [HttpGet]
        [ActionName("new")]
        public ActionResult NewViaGet()
        {
            var model = _service.GetTaskViewModel();
            return View("newtask", model);
        }

        [HttpPost]
        [ActionName("new")]
        public ActionResult NewViaPost(DateTime? duedate, 
            PriorityLevel priority, 
            [Bind(Prefix="description")] string[] lines)
        {
            var description = String.Join(" ", lines);
            _service.TryAddTask(description, duedate, priority);
            return RedirectToAction("list");
        }

        [HttpPost]
        public ActionResult Start(int id)
        {
            // PROCEED 
            _service.TrySetState(id, TaskStatus.InProgress);

            return Content("ok");
        }

        [HttpPost]
        public ActionResult Done(int id)
        {
            // PROCEED 
            _service.TrySetState(id, TaskStatus.Completed);


            return Content("ok");
        }

        [HttpPost]
        public ActionResult Suspend(int id)
        {
            // PROCEED 
            _service.TrySetState(id, TaskStatus.Standby);


            return Content("ok");
        }

        [HttpPost]
        public ActionResult Del(int id)
        {
            // PROCEED 
            _service.TryDelete(id);

            return Content("ok");
        }
    }
}