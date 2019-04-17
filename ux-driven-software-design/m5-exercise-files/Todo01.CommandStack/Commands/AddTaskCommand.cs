using System;
using Todo01.Infrastructure.Persistence.Model;

namespace Todo01.CommandStack.Commands
{
    public class AddTaskCommand
    {
        public AddTaskCommand(string description, DateTime? duedate, PriorityLevel priority)
        {
            Description = description;
            DueDate = duedate;
            Priority = priority;
        }

        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public PriorityLevel Priority { get; set; }
    }
}