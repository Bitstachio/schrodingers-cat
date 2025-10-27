namespace Features.Console.Interfaces
{
    public interface IConsoleStateRepository
    {
        T GetOrCreate<T>(int machineId) where T : IConsoleData, new();
        void Save<T>(int machineId, T data) where T : IConsoleData;
    }
}