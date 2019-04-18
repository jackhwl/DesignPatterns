using System;

namespace Todo02.Infrastructure.Framework
{
    public class EventBase : Message
    {
        public DateTime TimeStamp { get; private set; }

        public EventBase()
        {
            TimeStamp = DateTime.Now;
            Name = this.GetType().Name;
        }
    }
}