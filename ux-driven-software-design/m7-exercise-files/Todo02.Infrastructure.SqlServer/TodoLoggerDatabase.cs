using System.Data.Entity;
using Todo02.Infrastructure.SqlServer.Model;

namespace Todo02.Infrastructure.EventStore.SqlServer
{
    public class TodoLoggerDatabase : DbContext
    {
        public TodoLoggerDatabase(string connStringOrDbName = "name=TodoDatabase")
            : base(connStringOrDbName)
        {
        }

        public DbSet<LoggedEvent> LoggedEvents { get; set; }
    }
}