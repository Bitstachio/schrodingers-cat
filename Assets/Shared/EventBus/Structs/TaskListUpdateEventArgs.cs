namespace Shared.EventBus.Structs
{
    public readonly struct TaskListUpdateEventArgs
    {
        public int TaskListId { get; }
        public int TaskId { get; }
        public int Progress { get; }

        public TaskListUpdateEventArgs(int taskListId, int taskId, int progress)
        {
            TaskListId = taskListId;
            TaskId = taskId;
            Progress = progress;
        }
    }
}