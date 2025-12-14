using Features.Interactable.Interfaces;
using Shared.EventBus.Interfaces;
using VContainer;

namespace Features.Interactable.Services
{
    public class InteractionService<T> : IInteractableService<T>
    {
        private IEventPublisher<T> _eventPublisher;

        [Inject]
        public void Construct(IEventPublisher<T> eventPublisher) => _eventPublisher = eventPublisher;

        public void Apply(T content) => _eventPublisher.Invoke(content);
    }
}