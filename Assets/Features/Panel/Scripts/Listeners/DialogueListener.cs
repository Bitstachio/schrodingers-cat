using Features.Panel.Scripts.Panels;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.Panel.Scripts.Listeners
{
    public class DialogueListener : EventListener<DialogueInteractionEventArgs>
    {
        [SerializeField] private DialoguePanel panel;

        protected override void OnInvoked(DialogueInteractionEventArgs e) => panel.Show(e.Dialogue);
    }
}