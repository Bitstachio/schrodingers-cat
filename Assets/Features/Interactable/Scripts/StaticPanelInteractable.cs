using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.Interactable.Scripts
{
    public class StaticPanelInteractable : InteractableBehaviour<StaticPanelInteractionEventArgs>
    {
        [SerializeField] private int panelId;

        protected override void Interact() => InteractableService.Apply(new StaticPanelInteractionEventArgs(panelId));
    }
}