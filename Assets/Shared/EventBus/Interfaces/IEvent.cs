using System;

namespace Shared.EventBus.Interfaces
{
    public interface IEvent<out T>
    {
        event Action<T> Invoked;
    }
}