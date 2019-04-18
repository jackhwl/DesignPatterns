using Todo02.Infrastructure.Persistence.Model;

namespace Todo02.Models
{
    public class NewTaskViewModel : ViewModelBase
    {
        public NewTaskViewModel()
        {
            Task = new TodoItem();
        }

        public TodoItem Task { get; set; }
    }
}