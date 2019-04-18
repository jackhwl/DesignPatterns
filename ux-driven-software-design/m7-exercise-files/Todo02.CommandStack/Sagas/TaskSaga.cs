using Todo02.CommandStack.Commands;
using Todo02.CommandStack.Events;
using Todo02.Infrastructure.Framework;
using Todo02.Infrastructure.Persistence.Model;
using Todo02.Infrastructure.Persistence.Repositories;

namespace Todo02.CommandStack.Sagas
{
    public class TaskSaga : Saga,
        IStartWithMessage<AddTaskCommand>,
        IHandleMessage<ChangeStateCommand>,
        IHandleMessage<DeleteTaskCommand>
    {
        private static readonly TodoRepository Repository = new TodoRepository();

        public TaskSaga(IBus bus, IEventStore eventStore) : base(bus, eventStore)
        {
        }

        public void Handle(AddTaskCommand command)
        {
            var item = new TodoItem
            {
                Description = command.Description,
                DueDate = command.DueDate,
                Priority = command.Priority
            };

            Repository.Save(item);

            var created = new TaskCreatedEvent(item.Id, item.Description, item.DueDate, item.Priority);
            Bus.RaiseEvent(created);
        }


        public void Handle(ChangeStateCommand command)
        {
            Repository.Update(command.TaskId, command.NewState);
        }

        public void Handle(DeleteTaskCommand command)
        {
            Repository.Delete(command.TaskId);
        }
    }
}





#region MORE

// 1) You can save the state here and log the event. That's a simple 
//    historical CRUD. Let's do more.
// Repository.Save(item);
// var created = new TaskCreatedEvent(item.Id, item.Description, item.DueDate, item.Priority);
// EventStore.Save(created);

// 2) Save the state and notify the event through the bus 
//    and the bus will log it.
#endregion