using Features.Panel.Common.Interfaces;
using Shared.EventBus.Interfaces;
using Shared.EventBus.Structs;
using UnityEngine;
using VContainer;

namespace Features.Panel.Dialogue.Scripts
{
    public class DialogueListener : MonoBehaviour, IEventListener
    {
        [SerializeField] private DialoguePanel panel;

        //===== Dependency Injection =====

        private IPanelService<DialogueInteractionEventArgs> _panelService;

        [Inject]
        public void Construct(IPanelService<DialogueInteractionEventArgs> panelService) => _panelService = panelService;

        //===== Lifecycle =====
        // Handle subscription to dialogue service

        private void OnEnable() => _panelService.Opened += OnDialogueOpened;

        private void OnDisable() => _panelService.Opened -= OnDialogueOpened;

        //===== Event Handlers =====

        private void OnDialogueOpened(object sender, DialogueInteractionEventArgs e) => panel.Show(e.Dialogue);
    }
}