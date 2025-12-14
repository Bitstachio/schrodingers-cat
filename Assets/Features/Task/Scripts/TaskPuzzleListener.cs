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

        protected override void OnInvoked(PuzzleAttemptEventArgs e)
        {
            Debug.Log($"Detected Task - ({e.Id}, {e.Result}, {taskList.Tasks[0].IsComplete})");
            Debug.Log($"target = {taskList.Tasks[0].Target}, progress = {taskList.Tasks[0].Progress}");
            if (e.Result) taskList.Tasks.FirstOrDefault(t => t.Id == e.Id)?.MakeProgress();
        }
    }
}