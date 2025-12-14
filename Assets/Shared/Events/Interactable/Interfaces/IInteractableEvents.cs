using System;

namespace Shared.Events.Interactable.Interfaces
{
    public interface IInteractableEvents<out T>
    {
        event Action<T> Interacted;
    }
}