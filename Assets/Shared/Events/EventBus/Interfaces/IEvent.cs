using System;

namespace Shared.Events.EventBus.Interfaces
{
    public interface IEvent<out T>
    {
        event Action<T> Invoked;
    }
}