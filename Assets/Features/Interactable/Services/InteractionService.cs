using Features.Interactable.Interfaces;
using Shared.Events.Interactable.Interfaces;
using VContainer;

namespace Features.Interactable.Services
{
    public class InteractionService<T> : IInteractableService<T>
    {
        //===== Dependency Injection =====

        private IInteractableEventPublisher<T> _eventPublisher;

        [Inject]
        public void Construct(IInteractableEventPublisher<T> eventPublisher) => _eventPublisher = eventPublisher;

        //===== Interface Implementation =====

        public void Apply(T content) => _eventPublisher.Invoke(content);
    }
}