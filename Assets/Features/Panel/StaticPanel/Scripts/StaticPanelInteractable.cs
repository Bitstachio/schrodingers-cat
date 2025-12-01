using Features.Common.Interactable.Interfaces;
using Features.Panel.StaticPanel.Interfaces;
using UnityEngine;
using VContainer;

namespace Features.Panel.StaticPanel.Scripts
{
    public class StaticPanelInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private int panelId;

        //===== Dependency Injection =====

        private IPanelService _panelService;

        [Inject]
        public void Construct(IPanelService panelService) => _panelService = panelService;

        //===== Interface Implementation =====

        public void Interact() => _panelService.Open(panelId);
    }
}