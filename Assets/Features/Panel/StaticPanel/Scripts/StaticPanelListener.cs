using System.Linq;
using Features.Panel.StaticPanel.Exceptions;
using Shared.EventBus.Interfaces;
using Shared.EventBus.Structs;
using UnityEngine;
using VContainer;

namespace Features.Panel.StaticPanel.Scripts
{
    public class StaticPanelListener : MonoBehaviour, IEventListener
    {
        private StaticPanel[] _panels;

        //===== Dependency Injection =====

        private IEvent<StaticPanelInteractionEventArgs> _event;

        [Inject]
        public void Construct(IEvent<StaticPanelInteractionEventArgs> @event) => _event = @event;

        //===== Lifecycle =====

        private void Awake()
        {
            _panels = GetComponentsInChildren<MonoBehaviour>(true)
                .OfType<StaticPanel>()
                .ToArray();
        }

        // Handle subscription to panel service

        private void OnEnable() => _event.Invoked += OnPanelOpened;

        private void OnDisable() => _event.Invoked -= OnPanelOpened;

        //===== Event Handlers =====

        private void OnPanelOpened(StaticPanelInteractionEventArgs e)
        {
            var panel = _panels.FirstOrDefault(p => p.Id == e.PanelId) ?? throw new PanelIdNotFound(e.PanelId);
            panel.Show(e.PanelId);
        }
    }
}