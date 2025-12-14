using Features.Task.Interfaces;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;

namespace Features.Task.Services
{
    public class TaskService : EventPublisherService<TaskListUpdateEventArgs>, ITaskService
    {
        public void Update(int taskListId, int taskId, int progress) =>
            Publisher.Invoke(new TaskListUpdateEventArgs(taskListId, taskId, progress));
    }
}