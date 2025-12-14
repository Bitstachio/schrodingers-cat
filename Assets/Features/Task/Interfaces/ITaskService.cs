namespace Features.Task.Interfaces
{
    public interface ITaskService
    {
        void Update(int taskListId, int taskId, int progress);
    }
}