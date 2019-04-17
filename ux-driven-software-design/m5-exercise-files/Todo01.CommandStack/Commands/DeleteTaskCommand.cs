namespace Todo01.CommandStack.Commands
{
    public class DeleteTaskCommand
    {
        public DeleteTaskCommand(int taskId)
        {
            TaskId = taskId;
        }

        public int TaskId { get; set; }
    }
}