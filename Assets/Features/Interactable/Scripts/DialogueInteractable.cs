using Shared.EventBus.Structs;
using Shared.ScriptableObjects.Panel.Dialogue;
using UnityEngine;

namespace Features.Interactable.Scripts
{
    public class DialogueInteractable : InteractableBehaviour<DialogueInteractionEventArgs>
    {
        [SerializeField] private DialogueContent dialogue;

        protected override void Interact() => InteractableService.Apply(new DialogueInteractionEventArgs(dialogue));
    }
}