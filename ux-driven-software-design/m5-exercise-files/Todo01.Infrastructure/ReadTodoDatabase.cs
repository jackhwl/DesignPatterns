using System.Data.Entity;
using System.Linq;
using Todo01.Infrastructure.Persistence.Model;

namespace Todo01.Infrastructure.Persistence
{
    public class ReadTodoDatabase : DbContext
    {
        public ReadTodoDatabase(string connStringOrDbName = "name=TodoDatabase")
            : base(connStringOrDbName)
        {
        }

        public IQueryable<TodoItem> TodoItems { get; set; }
    }
}