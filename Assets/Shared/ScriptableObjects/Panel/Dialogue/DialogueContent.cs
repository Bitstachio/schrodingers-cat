using UnityEngine;

namespace Shared.ScriptableObjects.Panel.Dialogue
{
    [CreateAssetMenu(fileName = "Dialogue Content", menuName = "Panel Content/Dialogue Content")]
    public class DialogueContent : ScriptableObject
    {
        [SerializeField] private string speaker;
        [SerializeField] private string[] lines;

        public string Speaker => speaker;
        public string[] Lines => lines;
    }
}