using System.Collections.Generic;
using System.Web.Script.Serialization;
using Todo02.Infrastructure.Framework;
using Todo02.Infrastructure.SqlServer.Model;


namespace Todo02.Infrastructure.EventStore.SqlServer
{
    public class SqlEventStore : IEventStore
    {
        private static readonly EventRepository EventRepository = new EventRepository();

        public IEnumerable<EventBase> All(string matchId)
        {
            return null; 
        }

        public void Save<T>(T theEvent) where T : EventBase
        {
            var loggedEvent = new LoggedEvent()
            {
                Action = theEvent.Name,
                AggregateId = theEvent.SagaId,
                Cargo = new JavaScriptSerializer().Serialize(theEvent)
            };

            EventRepository.Store(loggedEvent);
        }
    }
}