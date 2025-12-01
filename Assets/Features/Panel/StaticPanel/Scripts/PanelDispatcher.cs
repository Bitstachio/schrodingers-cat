using System.Linq;
using Features.Panel.StaticPanel.Interfaces;
using Features.Panel.StaticPanel.Models;
using UnityEngine;
using VContainer;

namespace Features.Panel.StaticPanel.Scripts
{
    public class PanelDispatcher : MonoBehaviour
    {
        //===== Internal Fields =====

        private IPanel[] _panels;

        //===== Dependency Injection =====

        private IPanelService _panelService;

        [Inject]
        public void Construct(IPanelService panelService)
        {
            _panelService = panelService;
        }

        //===== Lifecycle =====

        private void Awake()
        {
            _panels = GetComponentsInChildren<MonoBehaviour>(true)
                .OfType<IPanel>()
                .ToArray();
        }

        // Handle subscription to panel service

        private void OnEnable()
        {
            _panelService.Opened += OnPanelOpened;
        }

        private void OnDisable()
        {
            _panelService.Opened -= OnPanelOpened;
        }

        //===== Event Handlers =====

        private void OnPanelOpened(object sender, PanelInteractionEventArgs e)
        {
            foreach (var panel in _panels)
            {
                if (panel.Id == e.PanelId) panel.Show(e.PanelId);
            }
        }
    }
}