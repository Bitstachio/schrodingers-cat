using Features.Interactable.Interfaces;
using Shared.EventBus.Structs;
using UnityEngine;
using VContainer;

namespace Features.Interactable.Scripts
{
    public class StaticPanelInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private int panelId;

        //===== Dependency Injection =====

        private IInteractableService<StaticPanelInteractionEventArgs> _interactableService;

        [Inject]
        public void Construct(IInteractableService<StaticPanelInteractionEventArgs> interactableService) =>
            _interactableService = interactableService;

        //===== Interface Implementation =====

        public void Interact() => _interactableService.Apply(new StaticPanelInteractionEventArgs(panelId));
    }
}