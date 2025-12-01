using System;
using Features.Panel.Dialogue.Interfaces;
using Features.Panel.Dialogue.Models;
using Features.Panel.Dialogue.Scripts;

namespace Features.Panel.Dialogue.Services
{
    public class DialogueService : IDialogueService
    {
        public event EventHandler<DialogueInteractionEventArgs> Opened;
        
        public void Open(DialogueContent dialogue) => Opened?.Invoke(this, new DialogueInteractionEventArgs(dialogue));
    }
}