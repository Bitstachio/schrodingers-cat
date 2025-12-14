namespace Shared.Events.Interactable.Interfaces
{
    public interface IInteractableEventPublisher<in T>
    {
        void Invoke(T content);
    }
}