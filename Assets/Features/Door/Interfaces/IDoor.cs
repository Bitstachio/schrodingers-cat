namespace Features.Door.Interfaces
{
    /// <summary>
    /// This interface is used by the global dependency injector to identify  classes that require event-related
    /// dependencies to be injected. Refer to <see cref="Installers.GlobalInjectionConfig"/>.
    /// </summary>
    public interface IDoor
    {
        void Open();
        void Close();
    }
}