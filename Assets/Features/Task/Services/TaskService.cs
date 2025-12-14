using Features.Task.Interfaces;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.Task.Services
{
    public class TaskService : EventPublisherService<TaskCompletionEventArgs>, ITaskService
    {
        public void Complete(int taskListId)
        {
            Debug.Log("Task completed");
            Publisher.Invoke(new TaskCompletionEventArgs(taskListId));
        }
    }
}