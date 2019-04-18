using System.Data.Entity;
using Todo02.Infrastructure.Persistence.Model;

namespace Todo02.Infrastructure.Persistence
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