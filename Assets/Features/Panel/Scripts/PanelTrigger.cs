using Features.Common.Interactable.Interfaces;
using Features.Panel.Interfaces;
using UnityEngine;
using VContainer;

namespace Features.Panel.Scripts
{
    public class PanelTrigger : MonoBehaviour, IInteractable
    {
        [SerializeField] private int panelId;

        //===== Dependency Injection =====

        private IPanelService _panelService;

        [Inject]
        public void Construct(IPanelService panelService)
        {
            _panelService = panelService;
        }

        //===== Interface Implementation =====

        public void Interact() => _panelService.Open(panelId);
    }
}