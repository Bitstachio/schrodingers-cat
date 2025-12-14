using System.Linq;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using Shared.ScriptableObjects.Task;
using UnityEngine;

namespace Features.Task.Scripts
{
    public class TaskPuzzleListener : EventListenerBehaviour<PuzzleAttemptEventArgs>
    {
        [SerializeField] private TaskList taskList;

        // TODO: This is a temporary solution; investigate a better approach to prevent SO from persisting progress
        private void Awake() => taskList.ResetProgress();

        protected override void OnInvoked(PuzzleAttemptEventArgs e)
        {
            if (e.Result) taskList.Tasks.FirstOrDefault(t => t.Id == e.Id)?.MakeProgress();
        }
    }
}