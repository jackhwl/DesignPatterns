namespace Todo02.Infrastructure.Framework
{
    public interface IEventStore
    {
       void Save<T>(T theEvent) where T : EventBase;
    }
}