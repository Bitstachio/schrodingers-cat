using Features.TaskSummary.Utils;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using Shared.ScriptableObjects.Task;
using TMPro;
using UnityEngine;

namespace Features.TaskSummary.Scripts
{
    public class TaskDisplayListener : EventListenerBehaviour<TaskListUpdateEventArgs>
    {
        [SerializeField] private TaskContent task;
        [SerializeField] private TextMeshProUGUI summaryText;

        private void Awake()
        {
            // TODO: This is a temporary solution; investigate a better approach to prevent SO from persisting progress
            task.ResetProgress();

            // This is fine, no need to remove this
            summaryText.SetText(TaskSummaryUtils.FormatProgress(task.Text, task.Progress, task.Target));
        }

        protected override void OnInvoked(TaskListUpdateEventArgs e)
        {
            if (e.TaskId == task.Id)
                summaryText.SetText(TaskSummaryUtils.FormatProgress(task.Text, task.Progress, task.Target));
        }
    }
}