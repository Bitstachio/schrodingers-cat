using System;
using Features.Panel.DialoguePanel.Interface;
using Features.Panel.DialoguePanel.Models;
using Features.Panel.DialoguePanel.Scripts;

namespace Features.Panel.DialoguePanel.Services
{
    public class DialogueService : IDialogueService
    {
        public event EventHandler<DialogueInteractionEventArgs> Opened;
        
        public void Open(DialogueContent dialogue) => Opened?.Invoke(this, new DialogueInteractionEventArgs(dialogue));
    }
}