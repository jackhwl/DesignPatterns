using System;
using System.Collections.Generic;
using Todo02.Infrastructure.Persistence.Model;

namespace Todo02.Models
{
    public class TaskListViewModel : ViewModelBase
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public IList<TodoItem> TaskList { get; set; }
    }
}