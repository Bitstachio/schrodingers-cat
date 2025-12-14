using UnityEngine;

namespace Shared.ScriptableObjects.Task
{
    [CreateAssetMenu(fileName = "Task List", menuName = "Task/Task List")]
    public class TaskList : ScriptableObject
    {
        [SerializeField] private TaskContent[] tasks;
        
        public TaskContent[] Tasks => tasks;
    }
}