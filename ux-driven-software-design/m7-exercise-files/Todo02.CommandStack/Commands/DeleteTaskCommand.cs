using Todo02.Infrastructure.Framework;

namespace Todo02.CommandStack.Commands
{
    public class DeleteTaskCommand : Command
    {
        public DeleteTaskCommand(int taskId)
        {
            TaskId = taskId;
        }

        public int TaskId { get; set; }
    }
}