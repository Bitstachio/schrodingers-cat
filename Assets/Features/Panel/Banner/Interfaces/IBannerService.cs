using System;
using Features.Panel.Banner.Models;
using Features.Panel.Banner.Scripts;

namespace Features.Panel.Banner.Interfaces
{
    public interface IBannerService
    {
        public event EventHandler<BannerInteractionEventArgs> Opened;
        
        void Open(BannerContent banner);
    }
}