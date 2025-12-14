using System;
using Shared.Events.EventBus.Interfaces;

namespace Shared.Events.EventBus.Implementation
{
    public class EventBus<T> : IEvent<T>, IEventPublisher<T>
    {
        public event Action<T> Invoked;
        
        public void Invoke(T content) => Invoked?.Invoke(content);
    }
}