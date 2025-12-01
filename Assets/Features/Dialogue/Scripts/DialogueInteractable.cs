using Features.Common.Interactable.Interfaces;
using Features.Dialogue.Interface;
using UnityEngine;
using VContainer;

namespace Features.Dialogue.Scripts
{
    public class DialogueInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private DialogueContent dialogue;

        //===== Dependency Injection =====
        
        private IDialogueService _dialogueService;
        
        [Inject]
        public void Construt(IDialogueService dialogueService) => _dialogueService = dialogueService;

        //===== Interface Implementation =====
        
        public void Interact() => _dialogueService.Open(dialogue);
    }
}