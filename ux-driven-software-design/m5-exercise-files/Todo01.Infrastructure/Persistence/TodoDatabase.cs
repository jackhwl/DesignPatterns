using System.Data.Entity;
using Todo01.Infrastructure.Persistence.Model;

namespace Todo01.Infrastructure.Persistence
{
    public class TodoDatabase : DbContext
    {
        public TodoDatabase(string connStringOrDbName = "name=TodoDatabase")
            : base(connStringOrDbName)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}