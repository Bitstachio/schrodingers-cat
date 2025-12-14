namespace Features.Interactable.Interfaces
{
    public interface IInteractableService<in T>
    {
        void Apply(T content);
    }
}