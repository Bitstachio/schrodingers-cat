using Features.Interactable.Interfaces;
using Shared.Events.EventBus.Interfaces;
using Shared.Events.EventBus.Structs;
using UnityEngine;
using VContainer;

namespace Features.Panel.Banner.Scripts
{
    public class BannerDispatcher : MonoBehaviour, IInteractionDispatcher
    {
        [SerializeField] private BannerPanel panel;

        //===== Dependency Injection =====

        private IEvent<BannerInteractionEventArgs> _event;

        [Inject]
        public void Construct(IEvent<BannerInteractionEventArgs> @event) => _event = @event;

        //===== Lifecycle =====
        // Handle subscription to dialogue service

        private void OnEnable() => _event.Invoked += OnBannerOpened;

        private void OnDisable() => _event.Invoked -= OnBannerOpened;

        //===== Event Handlers =====

        private void OnBannerOpened(BannerInteractionEventArgs e) => panel.Show(e.Banner);
    }
}