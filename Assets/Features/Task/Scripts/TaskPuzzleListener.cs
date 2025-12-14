using System.Linq;
using Features.Task.Interfaces;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using Shared.ScriptableObjects.Task;
using UnityEngine;
using VContainer;

namespace Features.Task.Scripts
{
    public class TaskPuzzleListener : EventListenerBehaviour<PuzzleAttemptEventArgs>
    {
        [SerializeField] private TaskList taskList;

        private ITaskService _taskService;

        [Inject]
        public void Construct(ITaskService taskService) => _taskService = taskService;

        // TODO: This is a temporary solution; investigate a better approach to prevent SO from persisting progress
        private void Awake() => taskList.ResetProgress();

        protected override void OnInvoked(PuzzleAttemptEventArgs e)
        {
            if (!e.Result) return;

            var task = taskList.Tasks.FirstOrDefault(t => t.Id == e.Id);
            if (task == null) return;

            task.MakeProgress();
            _taskService.Update(taskList.Id, task.Id, task.Progress);
        }
    }
}