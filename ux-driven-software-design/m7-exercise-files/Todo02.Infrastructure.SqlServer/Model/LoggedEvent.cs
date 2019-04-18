
using System;

namespace Todo02.Infrastructure.SqlServer.Model
{
    public class LoggedEvent
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public int AggregateId { get; set; }
        public string Cargo { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
