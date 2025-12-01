using Features.Panel.Dialogue.Interfaces;
using Features.Panel.Dialogue.Models;
using UnityEngine;
using VContainer;

namespace Features.Panel.Dialogue.Scripts
{
    public class DialogueDispatcher : MonoBehaviour
    {
        [SerializeField] private DialoguePanel panel;

        //===== Dependency Injection =====

        private IDialogueService _dialogueService;

        [Inject]
        public void Construct(IDialogueService panelService) => _dialogueService = panelService;

        //===== Lifecycle =====
        // Handle subscription to dialogue service

        private void OnEnable() => _dialogueService.Opened += OnDialogueOpened;

        private void OnDisable() => _dialogueService.Opened -= OnDialogueOpened;

        //===== Event Handlers =====

        private void OnDialogueOpened(object sender, DialogueInteractionEventArgs e) => panel.StartDialogue(e.Dialogue);
    }
}