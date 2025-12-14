using Features.Interactable.Interfaces;
using Shared.Events.Interactable.Interfaces;
using Shared.Events.Interactable.Structs;
using UnityEngine;
using VContainer;

namespace Features.Panel.Banner.Scripts
{
    public class BannerDispatcher : MonoBehaviour, IInteractionDispatcher
    {
        [SerializeField] private BannerPanel panel;

        //===== Dependency Injection =====

        private IInteractableEvents<BannerInteractionEventArgs> _interactableEvents;

        [Inject]
        public void Construct(IInteractableEvents<BannerInteractionEventArgs> interactableEvents) =>
            _interactableEvents = interactableEvents;

        //===== Lifecycle =====
        // Handle subscription to dialogue service

        private void OnEnable() => _interactableEvents.Interacted += OnBannerOpened;

        private void OnDisable() => _interactableEvents.Interacted -= OnBannerOpened;

        //===== Event Handlers =====

        private void OnBannerOpened(BannerInteractionEventArgs e) => panel.Show(e.Banner);
    }
}