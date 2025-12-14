using System.Linq;
using Features.Panel.Exceptions;
using Features.Panel.Scripts.Panels;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.Panel.Scripts.Listeners
{
    public class StaticPanelListenerBehaviour : EventListenerBehaviour<StaticPanelInteractionEventArgs>
    {
        private StaticPanel[] _panels;

        private void Awake()
        {
            _panels = GetComponentsInChildren<MonoBehaviour>(true)
                .OfType<StaticPanel>()
                .ToArray();
        }

        protected override void OnInvoked(StaticPanelInteractionEventArgs e)
        {
            var panel = _panels.FirstOrDefault(p => p.Id == e.PanelId) ?? throw new PanelIdNotFound(e.PanelId);
            panel.Show(e.PanelId);
        }
    }
}