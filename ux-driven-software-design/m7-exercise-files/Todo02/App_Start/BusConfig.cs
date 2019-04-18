using Todo02.CommandStack.Handlers;
using Todo02.CommandStack.Sagas;
using Todo02.Infrastructure.EventStore.SqlServer;
using Todo02.Infrastructure.Framework;

namespace Todo02
{
    public class BusConfig
    {
        public static void Initialize()
        {
            Todo02Application.Bus = new InMemoryBus(new SqlEventStore());
            Todo02Application.Bus.RegisterSaga<TaskSaga>();
            //Todo02Application.Bus.RegisterHandler<EmailHandler>();
        }
    }
}