using Features.Panel.Scripts.Panels;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.Panel.Scripts.Listeners
{
    public class BannerListenerBehaviour : EventListenerBehaviour<BannerInteractionEventArgs>
    {
        [SerializeField] private BannerPanel panel;

        protected override void OnInvoked(BannerInteractionEventArgs e) => panel.Show(e.Banner);
    }
}