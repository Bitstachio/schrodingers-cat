using System;
using Features.Dialogue.Interface;
using Features.Dialogue.Models;
using Features.Dialogue.Scripts;

namespace Features.Dialogue.Services
{
    public class DialogueService : IDialogueService
    {
        public event EventHandler<DialogueInteractionEventArgs> Opened;
        
        public void Open(DialogueContent dialogue) => Opened?.Invoke(this, new DialogueInteractionEventArgs(dialogue));
    }
}