using System;
using Features.Panel.Dialogue.Models;
using Features.Panel.Dialogue.Scripts;

namespace Features.Panel.Dialogue.Interfaces
{
    public interface IDialogueService
    {
        public event EventHandler<DialogueInteractionEventArgs> Opened;
        
        void Open(DialogueContent dialogue);
    }
}