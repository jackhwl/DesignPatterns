using Todo01.CommandStack.Commands;
using Todo01.Infrastructure.Persistence.Model;
using Todo01.Infrastructure.Persistence.Repositories;

namespace Todo01.CommandStack.Sagas
{
    public class TaskSaga
    {
        private static readonly TodoRepository Repository = new TodoRepository();

        public static void Handle(AddTaskCommand command)
        {
            var item = new TodoItem
            {
                Description = command.Description,
                DueDate = command.DueDate,
                Priority = command.Priority
            };
            Repository.Save(item);
        }

        public static void Handle(ChangeStateCommand command)
        {
            Repository.Update(command.TaskId, command.NewState);
        }

        public static void Handle(DeleteTaskCommand command)
        {
            Repository.Delete(command.TaskId);
        }
    }
}