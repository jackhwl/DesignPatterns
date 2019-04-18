using System;
using Todo02.CommandStack.Commands;
using Todo02.Infrastructure.Persistence.Model;
using Todo02.Models;
using Todo02.QueryStack;

namespace Todo02.Application
{
    public class TaskService
    {
        //private readonly TodoRepository _repository = new TodoRepository();
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
            var command = new AddTaskCommand(description, dueDate, priority);
            Todo02Application.Bus.Send(command);
        }

        public void TrySetState(int id, TaskStatus state)
        {
            // _repository.Update(id, state);
            var command = new ChangeStateCommand(id, state);
            Todo02Application.Bus.Send(command);
            //TaskSaga.Handle(command);
        }


        public void TryDelete(int id)
        {
            var command = new DeleteTaskCommand(id);
            Todo02Application.Bus.Send(command);

            //TaskSaga.Handle(command);
        }
        #endregion
    }
}