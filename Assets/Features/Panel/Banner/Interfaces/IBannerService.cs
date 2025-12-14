using System;
using Features.Panel.Banner.Scripts;
using Shared.Events.Interactable.Structs;

namespace Features.Panel.Banner.Interfaces
{
    public interface IBannerService
    {
        public event EventHandler<BannerInteractionEventArgs> Opened;
        
        void Open(BannerContent banner);
    }
}