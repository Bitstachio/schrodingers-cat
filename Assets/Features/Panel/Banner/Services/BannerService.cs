using System;
using Features.Panel.Banner.Interfaces;
using Features.Panel.Banner.Models;
using Features.Panel.Banner.Scripts;

namespace Features.Panel.Banner.Services
{
    public class BannerService : IBannerService
    {
        public event EventHandler<BannerInteractionEventArgs> Opened;
        
        public void Open(BannerContent dialogue) => Opened?.Invoke(this, new BannerInteractionEventArgs(dialogue));
    }
}