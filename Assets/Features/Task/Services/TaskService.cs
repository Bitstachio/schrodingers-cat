using Features.Task.Interfaces;
using Shared.EventBus.Interfaces;
using Shared.EventBus.Structs;
using UnityEngine;
using VContainer;

namespace Features.Task.Services
{
    public class TaskService : ITaskService
    {
        private IEventPublisher<TaskCompletionEventArgs> _publisher;

        [Inject]
        public void Construct(IEventPublisher<TaskCompletionEventArgs> publisher) => _publisher = publisher;

        public void Complete(int taskListId) => _publisher.Invoke(new TaskCompletionEventArgs(taskListId));
    }
}