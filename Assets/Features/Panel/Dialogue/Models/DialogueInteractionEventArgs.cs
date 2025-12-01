using Features.Panel.DialoguePanel.Scripts;

namespace Features.Panel.DialoguePanel.Models
{
    public class DialogueInteractionEventArgs
    {
        public DialogueContent Dialogue { get; }
        
        public DialogueInteractionEventArgs(DialogueContent dialogue) => Dialogue = dialogue;
    }
}