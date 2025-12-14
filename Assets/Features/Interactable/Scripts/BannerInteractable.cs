using Shared.EventBus.Structs;
using Shared.ScriptableObjects.Panel.Banner;
using UnityEngine;

namespace Features.Interactable.Scripts
{
    public class BannerInteractable : InteractableBehaviour<BannerInteractionEventArgs>
    {
        [SerializeField] private BannerContent banner;

        protected override void Interact() => InteractableService.Apply(new BannerInteractionEventArgs(banner));
    }
}