using Features.Panel.Dialogue.Scripts;

namespace Features.Panel.Dialogue.Models
{
    public class DialogueInteractionEventArgs
    {
        public DialogueContent Dialogue { get; }
        
        public DialogueInteractionEventArgs(DialogueContent dialogue) => Dialogue = dialogue;
    }
}