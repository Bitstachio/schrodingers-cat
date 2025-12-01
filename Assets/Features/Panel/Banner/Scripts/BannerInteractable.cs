using Features.Common.Interactable.Interfaces;
using Features.Panel.Banner.Interfaces;
using UnityEngine;
using VContainer;

namespace Features.Panel.Banner.Scripts
{
    public class BannerInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private BannerContent banner;

        //===== Dependency Injection =====
        
        private IBannerService _bannerService;
        
        [Inject]
        public void Construt(IBannerService bannerService) => _bannerService = bannerService;

        //===== Interface Implementation =====
 
        public void Interact() => _bannerService.Open(banner);
    }
}