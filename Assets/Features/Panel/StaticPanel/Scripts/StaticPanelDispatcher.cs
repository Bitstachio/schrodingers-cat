using System.Linq;
using Features.Common.Interactable.Interfaces;
using Features.Panel.Common.Interfaces;
using Features.Panel.StaticPanel.Exceptions;
using Features.Panel.StaticPanel.Interfaces;
using Features.Panel.StaticPanel.Models;
using UnityEngine;
using VContainer;

namespace Features.Panel.StaticPanel.Scripts
{
    public class StaticPanelDispatcher : MonoBehaviour, IInteractionDispatcher
    {
        private IPanel[] _panels;

        //===== Dependency Injection =====

        private IPanelService<StaticPanelInteractionEventArgs> _panelService;

        [Inject]
        public void Construct(IPanelService<StaticPanelInteractionEventArgs> panelService) =>
            _panelService = panelService;

        //===== Lifecycle =====

        private void Awake()
        {
            _panels = GetComponentsInChildren<MonoBehaviour>(true)
                .OfType<IPanel>()
                .ToArray();
        }

        // Handle subscription to panel service

        private void OnEnable() => _panelService.Opened += OnPanelOpened;

        private void OnDisable() => _panelService.Opened -= OnPanelOpened;

        //===== Event Handlers =====

        private void OnPanelOpened(object sender, StaticPanelInteractionEventArgs e)
        {
            var panel = _panels.FirstOrDefault(p => p.Id == e.PanelId) ?? throw new PanelIdNotFound(e.PanelId);
            panel.Show(e.PanelId);
        }
    }
}