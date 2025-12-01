using UnityEngine;

namespace Features.Dialogue.Scripts
{
    [CreateAssetMenu(fileName = "Dialogue Content", menuName = "Dialogue Content")]
    public class DialogueContent : ScriptableObject
    {
        [SerializeField] private string speaker;
        [SerializeField] private string[] lines;

        public string Speaker => speaker;
        public string[] Lines => lines;
    }
}