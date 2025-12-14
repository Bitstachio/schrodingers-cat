using UnityEngine;

namespace Shared.ScriptableObjects.Task
{
    [CreateAssetMenu(fileName = "Task Content", menuName = "Task/Task Content")]
    public class TaskContent : ScriptableObject
    {
        [SerializeField] private int id;
        [SerializeField] private string text;
        [SerializeField] private int target;

        public int Id => id;
        public string Text => text;
        public int Target => target;

        public int Progress { get; private set; }
        public bool IsComplete => Progress >= Target;

        public void MakeProgress()
        {
            if (!IsComplete) Progress++;
        }

        public void ResetProgress() => Progress = 0;
    }
}