using System;
using Todo02.Infrastructure.Framework;
using Todo02.Infrastructure.Persistence.Model;

namespace Todo02.CommandStack.Commands
{
    public class AddTaskCommand : Command
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