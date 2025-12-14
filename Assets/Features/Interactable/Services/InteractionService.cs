using Features.Interactable.Interfaces;
using Shared.EventBus.Implementation;

namespace Features.Interactable.Services
{
    public class InteractionService<T> : EventPublisherService<T>, IInteractableService<T>
    {
        public void Apply(T content) => Publisher.Invoke(content);
    }
}