using System;
using Todo01.CommandStack.Commands;
using Todo01.CommandStack.Sagas;
using Todo01.Infrastructure.Persistence.Model;
using Todo01.Infrastructure.Persistence.Repositories;
using Todo01.Models;
using Todo01.QueryStack;

namespace Todo01.Application
{
    public class TaskService
    {
        private readonly TodoRepository _repository = new TodoRepository();
        #region QUERY
        public NewTaskViewModel GetTaskViewModel()
        {
            var item = new TodoItem();
            var model = new NewTaskViewModel { Task = item };
            return model;
        }

        public TaskListViewModel GetTaskListViewModel(DateTime? from, DateTime? to)
        {
            //var list = _repository.All(from.GetValueOrDefault(), to.GetValueOrDefault(DateTime.MaxValue));

            var list = ReadModel.All(from, to);
            var model = new TaskListViewModel { From = from, To = to, TaskList = list };
            return model;
        }
        #endregion

        #region COMMAND
        public void TryAddTask(string description, DateTime? dueDate, PriorityLevel priority)
        {
            //var item = new TodoItem
            //{
            //    Description = description,
            //    DueDate = dueDate,
            //    Priority = priority
            //};
            //_repository.Save(item);

            var command = new AddTaskCommand(description, dueDate, priority);
            TaskSaga.Handle(command);
        }

        public void TrySetState(int id, TaskStatus state)
        {
            // _repository.Update(id, state);
            var command = new ChangeStateCommand(id, state);
            TaskSaga.Handle(command);
        }


        public void TryDelete(int id)
        {
            //_repository.Delete(id);
            var command = new DeleteTaskCommand(id);
            TaskSaga.Handle(command);
        }
        #endregion
    }
}