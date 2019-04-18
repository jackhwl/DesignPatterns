using System;
using Todo02.Infrastructure.Framework;
using Todo02.Infrastructure.Persistence.Model;

namespace Todo02.CommandStack.Events
{
    public class TaskCreatedEvent : EventBase
    {
        public TaskCreatedEvent(int id, string description, DateTime? duedate, PriorityLevel priority)
        {
            Description = description;
            DueDate = duedate;
            Priority = priority;
            Id = id;

            // Timestamp added in the base class
        }

        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public PriorityLevel Priority { get; set; }
        public int Id { get; set; }
        public DateTime? DateOfCreation { get; set; }
    }
}