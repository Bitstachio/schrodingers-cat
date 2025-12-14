using Features.Interactable.Interfaces;
using Shared.Events.EventBus.Structs;
using Shared.ScriptableObjects.Panel.Banner;
using UnityEngine;
using VContainer;

namespace Features.Interactable.Scripts
{
    public class BannerInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private BannerContent banner;

        //===== Dependency Injection =====

        private IInteractableService<BannerInteractionEventArgs> _interactableService;

        [Inject]
        public void Construct(IInteractableService<BannerInteractionEventArgs> interactableService) =>
            _interactableService = interactableService;

        //===== Interface Implementation =====

        public void Interact() => _interactableService.Apply(new BannerInteractionEventArgs(banner));
    }
}