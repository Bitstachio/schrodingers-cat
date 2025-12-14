using Features.Interactable.Interfaces;
using Shared.EventBus.Structs;
using Shared.ScriptableObjects.Panel.Dialogue;
using UnityEngine;
using VContainer;

namespace Features.Interactable.Scripts
{
    public class DialogueInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private DialogueContent dialogue;

        //===== Dependency Injection =====

        private IInteractableService<DialogueInteractionEventArgs> _interactableService;

        [Inject]
        public void Construct(IInteractableService<DialogueInteractionEventArgs> interactableService) =>
            _interactableService = interactableService;

        //===== Interface Implementation =====

        public void Interact() => _interactableService.Apply(new DialogueInteractionEventArgs(dialogue));
    }
}