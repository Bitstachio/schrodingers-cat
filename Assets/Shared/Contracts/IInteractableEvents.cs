using System;

namespace Shared.Contracts
{
    public interface IInteractableEvents<out T>
    {
        event Action<T> Interacted;
    }
}