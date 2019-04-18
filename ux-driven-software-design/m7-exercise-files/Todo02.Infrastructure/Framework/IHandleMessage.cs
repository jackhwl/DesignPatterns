namespace Todo02.Infrastructure.Framework
{
    public interface IHandleMessage<in T> where T : Message
    {
        void Handle(T message);
    }
}