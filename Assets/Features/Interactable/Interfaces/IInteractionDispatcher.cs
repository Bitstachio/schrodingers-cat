namespace Features.Interactable.Interfaces
{
    /// <summary>
    /// Marker interface for all interaction dispatcher components.
    /// 
    /// This interface is intentionally empty and exists solely to allow
    /// dispatchers (e.g., BannerDispatcher, DialogueDispatcher) to be
    /// recognized by the global dependency injection system.
    /// 
    /// Add any new dispatcher to the global injection configuration by
    /// implementing this interface.
    /// </summary>
    public interface IInteractionDispatcher
    {
    }
}