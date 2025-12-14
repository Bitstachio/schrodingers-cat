using System;
using Shared.Contracts;

namespace Shared.Events
{
    public class InteractableEvents<T> : IInteractableEvents<T>, IInteractableEventPublisher<T>
    {
        public event Action<T> Interacted;
        
        public void Invoke(T content) => Interacted?.Invoke(content);
    }
}