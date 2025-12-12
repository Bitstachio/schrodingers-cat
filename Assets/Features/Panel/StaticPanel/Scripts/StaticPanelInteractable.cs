using Features.Interactable.Interfaces;
using Features.Panel.Common.Interfaces;
using Features.Panel.StaticPanel.Models;
using UnityEngine;
using VContainer;

namespace Features.Panel.StaticPanel.Scripts
{
    public class StaticPanelInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private int panelId;

        //===== Dependency Injection =====

        private IPanelService<StaticPanelInteractionEventArgs> _panelService;

        [Inject]
        public void Construct(IPanelService<StaticPanelInteractionEventArgs> panelService) =>
            _panelService = panelService;

        //===== Interface Implementation =====

        public void Interact() => _panelService.Open(new StaticPanelInteractionEventArgs(panelId));
    }
}