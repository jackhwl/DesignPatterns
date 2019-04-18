using Todo02.Infrastructure.Framework;
using Todo02.Infrastructure.Persistence.Model;

namespace Todo02.CommandStack.Commands
{
    public class ChangeStateCommand : Command
    {
        public ChangeStateCommand(int taskId, TaskStatus newState)
        {
            TaskId = taskId;
            NewState = newState;
        }

        public int TaskId { get; set; }
        public TaskStatus NewState { get; set; }
    }
}