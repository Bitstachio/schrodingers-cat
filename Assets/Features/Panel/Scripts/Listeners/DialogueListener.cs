using Features.Panel.Scripts.Panels;
using Shared.EventBus.Interfaces;
using Shared.EventBus.Structs;
using UnityEngine;
using VContainer;

namespace Features.Panel.Scripts.Listeners
{
    public class DialogueListener : MonoBehaviour, IEventListener
    {
        [SerializeField] private DialoguePanel panel;

        //===== Dependency Injection =====

        private IEvent<DialogueInteractionEventArgs> _event;

        [Inject]
        public void Construct(IEvent<DialogueInteractionEventArgs> @event) => _event = @event;

        //===== Lifecycle =====
        // Handle subscription to dialogue service

        private void OnEnable() => _event.Invoked += OnDialogueOpened;

        private void OnDisable() => _event.Invoked -= OnDialogueOpened;

        //===== Event Handlers =====

        private void OnDialogueOpened(DialogueInteractionEventArgs e) => panel.Show(e.Dialogue);
    }
}