using System.Linq;
using UnityEngine;

namespace Shared.ScriptableObjects.Task
{
    [CreateAssetMenu(fileName = "Task List", menuName = "Task/Task List")]
    public class TaskList : ScriptableObject
    {
        [SerializeField] private int id;
        [SerializeField] private TaskContent[] tasks;

        public int Id => id;
        public TaskContent[] Tasks => tasks;

        public bool IsComplete() => tasks.All(t => t.IsComplete);
        public void ResetProgress() => tasks.ToList().ForEach(t => t.ResetProgress());
    }
}