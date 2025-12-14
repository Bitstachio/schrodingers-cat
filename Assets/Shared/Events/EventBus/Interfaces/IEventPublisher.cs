namespace Shared.Events.EventBus.Interfaces
{
    public interface IEventPublisher<in T>
    {
        void Invoke(T content);
    }
}