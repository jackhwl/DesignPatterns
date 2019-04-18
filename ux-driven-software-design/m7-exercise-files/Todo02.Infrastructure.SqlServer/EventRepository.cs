using System;
using System.Collections.Generic;
using System.Linq;
using Todo02.Infrastructure.SqlServer.Model;

namespace Todo02.Infrastructure.EventStore.SqlServer
{
    public class EventRepository
    {
        private readonly TodoLoggerDatabase _db = new TodoLoggerDatabase();

        public void Store(LoggedEvent eventToLog)
        {
            eventToLog.TimeStamp = DateTime.Now;
            _db.LoggedEvents.Add(eventToLog);
            _db.SaveChanges();
        }

        public IList<LoggedEvent> All(int aggregateId)
        {
            var events = (from e in _db.LoggedEvents where e.AggregateId == aggregateId select e).ToList();
            return events;
        }
    }
}