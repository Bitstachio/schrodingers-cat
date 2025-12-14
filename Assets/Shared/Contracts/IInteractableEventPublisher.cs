namespace Shared.Contracts
{
    public interface IInteractableEventPublisher<in T>
    {
        void Invoke(T content);
    }
}