namespace Shared.EventBus.Structs
{
    public readonly struct TaskCompletionEventArgs
    {
        public int Id { get; }

        public TaskCompletionEventArgs(int id) => Id = id;
    }
}