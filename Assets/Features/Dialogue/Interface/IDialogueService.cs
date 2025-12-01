using System;
using Features.Dialogue.Models;
using Features.Dialogue.Scripts;

namespace Features.Dialogue.Interface
{
    public interface IDialogueService
    {
        public event EventHandler<DialogueInteractionEventArgs> Opened;
        
        void Open(DialogueContent dialogue);
    }
}