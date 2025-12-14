using System;
using Shared.Events.Interactable.Interfaces;

namespace Shared.Events.Interactable.Implementation
{
    public class InteractableEvents<T> : IInteractableEvents<T>, IInteractableEventPublisher<T>
    {
        public event Action<T> Interacted;
        
        public void Invoke(T content) => Interacted?.Invoke(content);
    }
}