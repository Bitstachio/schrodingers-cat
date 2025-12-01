using Features.Common.Interactable.Interfaces;
using Features.Panel.DialoguePanel.Interface;
using UnityEngine;
using VContainer;

namespace Features.Panel.DialoguePanel.Scripts
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