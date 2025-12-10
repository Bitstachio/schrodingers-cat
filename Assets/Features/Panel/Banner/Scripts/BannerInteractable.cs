using Features.Common.Interactable.Interfaces;
using Features.Panel.Banner.Models;
using Features.Panel.Common.Interfaces;
using UnityEngine;
using VContainer;

namespace Features.Panel.Banner.Scripts
{
    public class BannerInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private BannerContent banner;

        //===== Dependency Injection =====
        
        private IPanelService<BannerInteractionEventArgs> _panelService;
        
        [Inject ]
        public void Construct(IPanelService<BannerInteractionEventArgs> panelService) => _panelService = panelService;

        //===== Interface Implementation =====
 
        public void Interact() => _panelService.Open(new BannerInteractionEventArgs(banner));
    }
}