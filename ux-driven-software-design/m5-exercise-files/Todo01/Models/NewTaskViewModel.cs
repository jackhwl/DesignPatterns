using Todo01.Infrastructure.Persistence.Model;

namespace Todo01.Models
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