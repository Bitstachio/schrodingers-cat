using Features.Panel.Banner.Scripts;

namespace Shared.Events.Interactable.Structs
{
    public readonly struct BannerInteractionEventArgs
    {
        public BannerContent Banner { get; }

        public BannerInteractionEventArgs(BannerContent banner) => Banner = banner;
    }
}