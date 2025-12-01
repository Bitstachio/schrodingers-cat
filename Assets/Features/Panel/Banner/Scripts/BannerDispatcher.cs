using Features.Panel.Banner.Interfaces;
using Features.Panel.Banner.Models;
using UnityEngine;
using VContainer;

namespace Features.Panel.Banner.Scripts
{
    public class BannerDispatcher : MonoBehaviour
    {
        [SerializeField] private BannerPanel panel;

        //===== Dependency Injection =====

        private IBannerService _bannerService;

        [Inject]
        public void Construct(IBannerService bannerService) => _bannerService = bannerService;

        //===== Lifecycle =====
        // Handle subscription to dialogue service

        private void OnEnable() => _bannerService.Opened += OnBannerOpened;

        private void OnDisable() => _bannerService.Opened -= OnBannerOpened;

        //===== Event Handlers =====

        private void OnBannerOpened(object sender, BannerInteractionEventArgs e) => panel.Show(e.Banner);
    }
}