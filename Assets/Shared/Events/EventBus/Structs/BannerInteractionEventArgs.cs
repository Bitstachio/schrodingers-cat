using Shared.ScriptableObjects.Panel.Banner;

namespace Shared.Events.EventBus.Structs
{
    public readonly struct BannerInteractionEventArgs
    {
        public BannerContent Banner { get; }

        public BannerInteractionEventArgs(BannerContent banner) => Banner = banner;
    }
}