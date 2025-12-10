using Features.Panel.Common.Interfaces;
using UnityEngine;
using VContainer;

namespace Features.Panel.Banner.Scripts
{
    public class BannerDispatcher : MonoBehaviour
    {
        [SerializeField] private BannerPanel panel;

        //===== Dependency Injection =====

        private IPanelService<BannerContent> _panelService;
        
        [Inject ]
        public void Construct(IPanelService<BannerContent> panelService) => _panelService = panelService;

        //===== Lifecycle =====
        // Handle subscription to dialogue service

        private void OnEnable() => _panelService.Opened += OnBannerOpened;

        private void OnDisable() => _panelService.Opened -= OnBannerOpened;

        //===== Event Handlers =====

        private void OnBannerOpened(object sender, BannerContent e) => panel.Show(e);
    }
}