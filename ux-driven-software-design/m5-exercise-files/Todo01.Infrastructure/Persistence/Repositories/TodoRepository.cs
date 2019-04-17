using System;
using System.Collections.Generic;
using System.Linq;
using Todo01.Infrastructure.Persistence.Model;

namespace Todo01.Infrastructure.Persistence.Repositories
{
    public class TodoRepository
    {
        public IList<TodoItem> All(DateTime fromDate, DateTime toDate, TaskStatus state)
        {
            using (var db = new TodoDatabase())
            {
                var tasks = (from t in db.TodoItems
                    where t.DueDate >= fromDate.Date &&
                          t.DueDate <= toDate.Date &&
                          ((int) t.State <= (int) state)
                    orderby t.State descending, t.DueDate
                    select t).ToList();
                return tasks;
            }
        }

        public int Save(TodoItem task)
        {
            using (var db = new TodoDatabase())
            {
                db.TodoItems.Add(task);
                db.SaveChanges();
            }

            return task.Id;
        }

        public void Update(int id, TaskStatus state)
        {
            using (var db = new TodoDatabase())
            {
                var task = (from t in db.TodoItems where t.Id == id select t).FirstOrDefault();
                if (task == null)
                    return;

                // NB: THIS IS A CRUD APPROACH
                task.State = state;

                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TodoDatabase())
            {
                var task = (from t in db.TodoItems where t.Id == id select t).FirstOrDefault();
                if (task == null)
                    return;

                db.TodoItems.Remove(task);
                db.SaveChanges();
            }
        }
    }
}