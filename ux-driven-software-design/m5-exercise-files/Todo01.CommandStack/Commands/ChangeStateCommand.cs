using Todo01.Infrastructure.Persistence.Model;

namespace Todo01.CommandStack.Commands
{
    public class ChangeStateCommand
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