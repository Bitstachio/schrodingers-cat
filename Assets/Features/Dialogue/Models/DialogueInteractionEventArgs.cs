using Features.Dialogue.Scripts;

namespace Features.Dialogue.Models
{
    public class DialogueInteractionEventArgs
    {
        public DialogueContent Dialogue { get; }
        
        public DialogueInteractionEventArgs(DialogueContent dialogue) => Dialogue = dialogue;
    }
}