using System;
using Features.Panel.DialoguePanel.Models;
using Features.Panel.DialoguePanel.Scripts;

namespace Features.Panel.DialoguePanel.Interface
{
    public interface IDialogueService
    {
        public event EventHandler<DialogueInteractionEventArgs> Opened;
        
        void Open(DialogueContent dialogue);
    }
}